using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using riusco_mvc.Data;
using riusco_mvc.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace riusco_mvc.Controllers
{
    public class UsersController : Controller
    {
        private readonly MainDbContext _context;
        private readonly IWebHostEnvironment _environment;
        private readonly IConfiguration _configuration;

        public UsersController(MainDbContext context, IWebHostEnvironment environment, IConfiguration configuration)
        {
            _context = context;
            _environment = environment;
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsers([FromForm] string api_key)
        {
            if (api_key == _configuration["api_key"])
                return await _context.Users.ToListAsync();

            return BadRequest();
        }

        [HttpGet]
        public async Task<ActionResult<UserDTO>> GetUser(int value, [FromForm] string api_key)
        {
            var user = await _context.Users.FindAsync(value);

            if (user == null || (api_key != _configuration["api_key"] && api_key != user.ApiKey))
                return NotFound();

            return user;
        }

        [HttpPut]
        public async Task<IActionResult> PutUser(int value, [FromForm] User user, [FromForm] string api_key)
        {
            var oldUser = await _context.Users.FindAsync(value);
            if (oldUser == null || (api_key != _configuration["api_key"] &&
                                    api_key != oldUser.ApiKey))
                return NotFound();

            _context.Entry(oldUser).State = EntityState.Detached;
            if (user.Email != null)
                oldUser.Email = user.Email;
            if (user.Name != null)
                oldUser.Name = user.Name;
            if (user.Password != null)
                oldUser.Password = GetHash(user.Password, oldUser.Salt);
            var oldImage = oldUser.Image;
            if (user.Image != null && user.Image.FileName != "no_image")
                oldUser.Image = UploadImage(user.Image);
            if (user.Balance > 0)
                oldUser.Balance = user.Balance;
            if (user.City != null)
                oldUser.City = user.City;
            _context.Entry(oldUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                if (user.Image != null && user.Image.FileName != "no_image")
                    DeleteImage(oldImage);
            }
            catch (DbUpdateConcurrencyException)
            {
                DeleteImage(oldUser.Image);
                return BadRequest();
            }

            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePicture(int value, [FromForm] IFormFile image,
            [FromForm] string api_key)
        {
            var user = await _context.Users.FindAsync(value);
            api_key = WebUtility.HtmlDecode(api_key);
            if (user == null || (api_key != _configuration["api_key"] && api_key != user.ApiKey))
                return NotFound();

            _context.Entry(user).State = EntityState.Detached;
            var oldImage = user.Image;
            user.Image = UploadImage(image);
            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                DeleteImage(oldImage);
            }
            catch (DbUpdateConcurrencyException)
            {
                DeleteImage(user.Image);
                return BadRequest();
            }

            return NoContent();
        }
        
        [HttpPost]
        public async Task<ActionResult<UserDTO>> PostUser([FromForm] User userViewModel)
        {
            if (_context.Users.FirstOrDefault(x => x.Email == userViewModel.Email) != null)
                return BadRequest();
            
            var salt = new byte[128];
            var apiKey = new byte[32];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(salt);
            rng.GetBytes(apiKey);
            var user = new UserDTO(userViewModel.Name, GetHash(userViewModel.Password, Encoding.UTF8.GetString(salt)), userViewModel.Email, UploadImage(userViewModel.Image), Encoding.UTF8.GetString(salt), Convert.ToBase64String(apiKey), 1, userViewModel.City);
            await _context.Users.AddAsync(user);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                return BadRequest();
            }
            return CreatedAtAction("GetUser", new { name = user.Name }, user);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int value, [FromForm] string api_key)
        {
            var user = await _context.Users.FindAsync(value);
            if (user == null || (api_key != _configuration["api_key"] && api_key != user.ApiKey))
                return NotFound();
            
            var userId = user.UserID;
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            DeleteImage(user.Image);
            
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> AuthenticateUser([FromForm] string email, [FromForm] string password)
        {
            UserDTO user;
            try
            {
                user = await _context.Users.SingleAsync(x => x.Email == email);
            }
            catch (Exception)
            {
                return NotFound();
            }

            if (GetHash(password, user.Salt).Equals(user.Password))
                return Ok(user);
            
            return BadRequest();
        }
        
        private string UploadImage(IFormFile image)
        {
            var extension = Path.GetExtension(image.FileName);
            var imageName = Guid.NewGuid() + extension;
            if (extension == "" || (extension != ".jpg" && extension != ".jpeg" && extension != ".png" && extension != ".svg"))
                return "default_profile_picture.png";

            using var fileImage = Image.Load(image.OpenReadStream());
            if (fileImage.Height > 1080)
                fileImage.Mutate(x => x.Resize(0, 1080));
            if (fileImage.Width > 3840)
                fileImage.Mutate(x => x.Resize(3840, 0));
                        
            fileImage.Save(Path.Combine(_environment.WebRootPath, "images", "users", imageName));

            return imageName;
        }

        private void DeleteImage(string imageName)
        {
            if (imageName!= "default_profile_picture.png")
                System.IO.File.Delete(Path.Combine(_environment.WebRootPath, "images", "users", imageName));
        }
        
        private static string GetHash(string password, string salt)
        {
            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: Encoding.UTF8.GetBytes(salt),
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 32));
        }
    }
}