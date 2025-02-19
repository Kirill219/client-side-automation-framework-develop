﻿using System.Collections.Generic;
using OpenQA.Selenium;

namespace Kpi.UkrNet.ClientTests.Model.Platform.Element
{
    public interface INative
    {
        IWebElement FindElement(Locator.Locator locator, int index);

        IReadOnlyCollection<IWebElement> FindElements(Locator.Locator locator);
    }
}
