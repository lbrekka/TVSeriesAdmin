using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using TVSeriesAdmin.DataAccess;

namespace TVSeriesAdmin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var data = new Data();
            //var navn = data.GetTvShowNames();
            CreateWebHostBuilder(args).Build().Run();

            // testing
            
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
