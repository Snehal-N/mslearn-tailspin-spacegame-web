using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace TailSpin.SpaceGame.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            CreateWebHostBuilder(args).Build().Run();
           // hello how are u jhkg hello snehla
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
