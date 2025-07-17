using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using MobileAutomation.Core.Pages;
using NUnit.Framework;

namespace AppiumMobileAutomation
{
    public abstract class BaseTest
    {
        protected AndroidDriver driver;
        protected MainMenuPage mainMenuPage;

        [SetUp]
        public virtual void Init()
        {
            driver = MobileAutomation.Core.DriverManager.CreateDriver();
            mainMenuPage = new MainMenuPage(driver);
        }

        [TearDown]
        public virtual void Cleanup()
        {
            driver?.Quit();
            driver?.Dispose();
        }
    }
}