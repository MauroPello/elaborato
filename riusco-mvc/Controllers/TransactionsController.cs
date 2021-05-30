using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using riusco_mvc.Data;
using riusco_mvc.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace riusco_mvc.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly MainDbContext _context;
        private readonly IConfiguration _configuration;
        
        public TransactionsController(MainDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransactionDTO>>> GetTransactions([FromForm] string api_key)
        {
            if (api_key == _configuration["api_key"])
                return await _context.Transactions.OrderByDescending(t => t.LastUpdate).ToListAsync();

            return BadRequest();
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransactionDTO>>> GetTransactionsByUserID(int value, [FromForm] string api_key)
        {
            var user = await _context.Users.FindAsync(value);
            if (user == null)
                return NotFound();
            
            if (api_key != _configuration["api_key"] && api_key != user.ApiKey)
                return BadRequest();

            return await _context.Transactions.Where(x => x.OwnerID == user.UserID || x.BuyerID == user.UserID).OrderByDescending(t => t.LastUpdate).ToListAsync();
        }

        [HttpGet]
        public async Task<ActionResult<TransactionDTO>> GetTransaction(int value, [FromForm] string api_key)
        {
            var transaction = await _context.Transactions.FindAsync(value);
            if (transaction == null || (api_key != _configuration["api_key"] && api_key != transaction.Owner.ApiKey && api_key != transaction.Buyer.ApiKey))
                return BadRequest();

            return transaction;
        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateState(int value, [FromForm] int State, [FromForm] string api_key)
        {
            var oldTransaction = await _context.Transactions.FindAsync(value);
            if (oldTransaction == null)
                return NotFound();
            var owner = await _context.Users.FindAsync(oldTransaction.OwnerID);
            if (owner == null)
                return NotFound();
            var buyer = await _context.Users.FindAsync(oldTransaction.BuyerID);
            if (buyer == null)
                return NotFound();
            var product = await _context.Products.FindAsync(oldTransaction.ProductID);
            if (product == null)
                return NotFound();
            
            if (api_key != _configuration["api_key"] && api_key != owner.ApiKey && api_key != buyer.ApiKey)
                return BadRequest();

            if (oldTransaction.State != "Pending")
                return BadRequest();

            if (State == 2 && api_key != _configuration["api_key"] && api_key != buyer.ApiKey)
                return BadRequest();
            
            var state = State switch
            {
                0 => "Pending",
                1 => "Closed",
                2 => "Completed",
                _ => "Closed"
            };
            _context.Entry(oldTransaction).State = EntityState.Detached;
            oldTransaction.LastUpdate = DateTime.Now;
            oldTransaction.State = state;
            _context.Entry(oldTransaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Detached;
            product.IsAvailable = state == "Closed";
            product.LastUpdate = DateTime.Now;
            if (state == "Completed")
            {
                product.OwnerID = buyer.UserID;
            }
            _context.Entry(product).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest();
            }

            switch (state)
            {
                case "Completed":
                {
                    _context.Entry(owner).State = EntityState.Detached;
                    owner.Balance += 1;
                    _context.Entry(owner).State = EntityState.Modified;
                    try
                    {
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        return BadRequest();
                    }
                    break;
                }
                case "Closed":
                {
                    _context.Entry(buyer).State = EntityState.Detached;
                    buyer.Balance += 1;
                    _context.Entry(buyer).State = EntityState.Modified;
                    try
                    {
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        return BadRequest();
                    }
                    break;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<TransactionDTO>> PostTransaction([FromForm] int ProductID, [FromForm] int SellerID, [FromForm] int BuyerID, [FromForm] string api_key)
        {
            var product = await _context.Products.FindAsync(ProductID);
            var seller = await _context.Users.FindAsync(SellerID);
            var buyer = await _context.Users.FindAsync(BuyerID);
            if (seller == null || buyer == null || product == null || !product.IsAvailable)
                return BadRequest();

            if (api_key != _configuration["api_key"] && api_key != seller.ApiKey && api_key != buyer.ApiKey)
                return BadRequest();

            if (buyer.Balance < 1)
                return BadRequest();
            
            _context.Entry(buyer).State = EntityState.Detached;
            buyer.Balance -= 1;
            _context.Entry(buyer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {                
                return BadRequest();
            }

            var transactionDTO = new TransactionDTO(ProductID, SellerID, BuyerID, DateTime.Now, "Pending");
            await _context.Transactions.AddAsync(transactionDTO);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Detached;
            product.IsAvailable = false;
            product.LastUpdate = DateTime.Now;
            _context.Entry(product).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest();
            }
            
            return CreatedAtAction("GetTransaction", new { value = transactionDTO.TransactionID, api_key }, transactionDTO);
        }
    }
}