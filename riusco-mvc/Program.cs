using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace riusco_mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}
/*
 TODO:
    - Style Home Page (Include Login and Register on a toggle panel)

    + Code review (Saving changes?)
    -- Security check
    + Code review
*/