﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace AppWithScheduler
{
    public class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                 .UseKestrel()
                 .UseContentRoot(Directory.GetCurrentDirectory())
                 .UseIISIntegration()
                 .UseStartup<Startup>()
                 .UseApplicationInsights()
                 .Build();

            host.Run();
        }
    }
}
