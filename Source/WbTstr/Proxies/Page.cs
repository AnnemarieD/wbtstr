﻿using System.Collections.Generic;
using System.Drawing;
using WbTstr.Proxies.Interfaces;
using WbTstr.WebDrivers.Interfaces;

namespace WbTstr.WebDrivers
{
    public class Page : IPage
    {
        internal Page()
        {
        }

        /*-------------------------------------------------------------------*/

        public string Url { get; internal set; }

        public string Title { get; internal set; }

        public string InitialHTML { get; internal set; }

        public string CurrentHTML { get; internal set; }

        public Size Size { get; internal set; }

        public IReadOnlyList<string> Console { get; internal set; }

        public IReadOnlyDictionary<string, ICookie> Cookies { get; internal set; }
    }
}
