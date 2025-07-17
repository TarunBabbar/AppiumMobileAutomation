using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace MobileAutomation.Core.Pages
{
    public class MainMenuPage
    {
        private readonly AndroidDriver driver;

        public MainMenuPage(AndroidDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement Accessibility => driver.FindElement(MobileBy.AccessibilityId("Accessibility"));
        public IWebElement Animation => driver.FindElement(MobileBy.AccessibilityId("Animation"));
        public IWebElement App => driver.FindElement(MobileBy.AccessibilityId("App"));
        public IWebElement Content => driver.FindElement(MobileBy.AccessibilityId("Content"));
        public IWebElement Graphics => driver.FindElement(MobileBy.AccessibilityId("Graphics"));
        public IWebElement Media => driver.FindElement(MobileBy.AccessibilityId("Media"));
        public IWebElement NFC => driver.FindElement(MobileBy.AccessibilityId("NFC"));
        public IWebElement OS => driver.FindElement(MobileBy.AccessibilityId("OS"));
        public IWebElement Preference => driver.FindElement(MobileBy.AccessibilityId("Preference"));
        public IWebElement Text => driver.FindElement(MobileBy.AccessibilityId("Text"));
        public IWebElement Views => driver.FindElement(MobileBy.AccessibilityId("Views"));

        public void ClickAndBack(IWebElement element)
        {
            element.Click();
            driver.Navigate().Back();
        }
    }
}