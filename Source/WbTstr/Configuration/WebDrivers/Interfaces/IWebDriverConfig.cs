﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WbTstr.Configuration.WebDrivers.Constants;

namespace WbTstr.Configuration.WebDrivers.Interfaces
{
    public interface IWebDriverConfig
    {
        WebDriverType Type { get; }
    }
}
