﻿using System;
using WbTstr.Commands.Interfaces;
using WbTstr.Configuration.WebDrivers.Interfaces;
using WbTstr.Session.Trackers.Interfaces;

namespace WbTstr.Session.Performers.Interfaces
{
    public interface ISessionPerformer : IDisposable
    {
        ISessionPerformer Initialize(IWebDriverConfig webDriverConfig, ISessionTracker tracker = null);

        bool DirectPlay { get; set; }

        void Perform(IActionCommand actionCommand);

        T PerformAndReturn<T>(IReturnCommand<T> command);

        void Play();
    }
}
