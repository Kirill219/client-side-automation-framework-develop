﻿using Kpi.UkrNet.ClientTests.Model.Domain.Run;

namespace Kpi.UkrNet.ClientTests.Platform.Configuration.Run
{
    public class RunSettings : IRunSettings
    {
        public SeleniumGrid SeleniumGrid { get; set; }

        public RunType RunType { get; set; }
    }
}
