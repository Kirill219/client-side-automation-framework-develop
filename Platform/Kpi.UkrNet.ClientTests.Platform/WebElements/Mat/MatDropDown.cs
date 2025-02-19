﻿using Kpi.UkrNet.ClientTests.Model.Platform.Locator;
using Kpi.UkrNet.ClientTests.Model.Platform.WebElements.Mat;
using Kpi.UkrNet.ClientTests.Platform.Element;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.UkrNet.ClientTests.Platform.WebElements.Mat
{
    public class MatDropDown : HtmlElement, IMatDropDown
    {
        [FindBy(How.XPath, ".//mat-select[@id='mat-select-0']")]
        private MatSelect MatSelect { get; set; }

        public void SetValue(string value)
        {
            MatSelect.Open();
            MatSelect.Select(value);
        }

        public string[] GetOptions() =>
            MatSelect.GetOptions();
    }
}
