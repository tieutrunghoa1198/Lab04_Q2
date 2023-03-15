using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Q2
{
    public class AppSetting
    {
        private static IConfigurationBuilder GetConfig()
        {
            return new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        }

        public static IConfigurationSection GetConnectionStrings()
        {
            return GetConfig().Build().GetSection("ConnectionStrings");
        }
    }
}
