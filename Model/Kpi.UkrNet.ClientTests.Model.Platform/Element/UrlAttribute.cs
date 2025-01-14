﻿using System;

namespace Kpi.UkrNet.ClientTests.Model.Platform.Element
{
    public class UrlAttribute : Attribute
    {
        public UrlAttribute(string url)
        {
            Url = url;
        }

        public string Url { get; private set; }
    }
}
