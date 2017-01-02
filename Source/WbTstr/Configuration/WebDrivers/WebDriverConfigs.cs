﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WbTstr.Configuration.WebDrivers.Interfaces;
using WbTstr.WebDrivers.Constants;

namespace WbTstr.Configuration.WebDrivers
{
    public static class WebDriverConfigs
    {
        public static IWebDriverConfig GetDefault()
        {
            return new ChromeWebDriverConfig();
        }

        public static IWebDriverConfig GetFromConfig(WebDriverName name)
        {
            IWebDriverConfig webDriverConfig;
            switch (name)
            {
                case WebDriverName.Chrome:
                    webDriverConfig = new ChromeWebDriverConfig();
                    break;
                default:
                    webDriverConfig = GetDefault();
                    break;
            }

            return webDriverConfig;
        }
    }
}
