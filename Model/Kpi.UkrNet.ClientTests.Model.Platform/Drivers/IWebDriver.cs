﻿using System;

namespace Kpi.UkrNet.ClientTests.Model.Platform.Drivers
{
    public interface IWebDriver : IDisposable
    {
        void Get(string url);

        void Close();

        void Refresh();
    }
}
