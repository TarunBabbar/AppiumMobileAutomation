using System;
using System.Configuration;
using System.Linq;
using System.Xml.Linq;

namespace MobileAutomation.Core
{
    public static class ConfigurationHelper
    {
        public static string GetRunSettingsParameter(string name)
        {
            var runSettingsPath = "Appium.runsettings";
            var doc = XDocument.Load(runSettingsPath);
            var param = doc.Descendants("Parameter")
                           .FirstOrDefault(p => p.Attribute("name")?.Value == name);
            return param?.Attribute("value")?.Value ?? string.Empty;
        }
    }
}