using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace SampleMvcApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureLogging((Microsoft.Extensions.Logging.ILoggingBuilder logging) =>
            {
                logging.ClearProviders();
                logging.AddConsole();
            })
                .UseStartup<Startup>();
    }
}
