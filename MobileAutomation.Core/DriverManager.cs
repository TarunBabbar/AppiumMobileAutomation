using System;
using System.IO;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace MobileAutomation.Core
{
    public static class DriverManager
    {
        public static AndroidDriver CreateDriver()
        {
            var platformName = ConfigurationHelper.GetRunSettingsParameter("PlatformName");
            var deviceName = ConfigurationHelper.GetRunSettingsParameter("DeviceName");
            var automationName = ConfigurationHelper.GetRunSettingsParameter("AutomationName");
            var apkFileName = ConfigurationHelper.GetRunSettingsParameter("AppFileName");
            var appFolder = ConfigurationHelper.GetRunSettingsParameter("AppFolder");
            var newCommandTimeout = int.Parse(ConfigurationHelper.GetRunSettingsParameter("NewCommandTimeout"));
            var appiumServerUrl = ConfigurationHelper.GetRunSettingsParameter("AppiumServerUrl");

            var apkPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, appFolder, apkFileName);

            var options = new AppiumOptions();
            options.AddAdditionalAppiumOption("platformName", platformName);
            options.DeviceName = deviceName;
            options.AutomationName = automationName;
            options.App = apkPath;
            options.AddAdditionalAppiumOption("newCommandTimeout", newCommandTimeout);

            return new AndroidDriver(new Uri(appiumServerUrl), options);
        }
    }
}