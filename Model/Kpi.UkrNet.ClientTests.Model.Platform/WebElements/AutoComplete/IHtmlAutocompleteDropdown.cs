﻿namespace Kpi.UkrNet.ClientTests.Model.Platform.WebElements.AutoComplete
{
    public interface IHtmlAutocompleteDropdown
    {
        void Select(string value);

        string[] GetValues();
    }
}
