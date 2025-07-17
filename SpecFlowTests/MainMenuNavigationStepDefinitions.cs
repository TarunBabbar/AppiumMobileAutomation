using MobileAutomation.Core;
using MobileAutomation.Core.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace SpecFlowTests
{
    [Binding]
    public class MainMenuNavigationStepDefinitions
    {
        private AndroidDriver driver;
        private MainMenuPage mainMenuPage;

        [Given("the app is launched")]
        public void GivenTheAppIsLaunched()
        {
            driver = DriverManager.CreateDriver();
            mainMenuPage = new MainMenuPage(driver);
        }

        [When("I navigate and click all main menu links")]
        public void WhenINavigateAndClickAllMainMenuLinks()
        {
            mainMenuPage.ClickAndBack(mainMenuPage.Accessibility);
            mainMenuPage.ClickAndBack(mainMenuPage.Animation);
            mainMenuPage.ClickAndBack(mainMenuPage.App);
            mainMenuPage.ClickAndBack(mainMenuPage.Content);
            mainMenuPage.ClickAndBack(mainMenuPage.Graphics);
            mainMenuPage.ClickAndBack(mainMenuPage.Media);
            mainMenuPage.ClickAndBack(mainMenuPage.NFC);
            mainMenuPage.ClickAndBack(mainMenuPage.OS);
            mainMenuPage.ClickAndBack(mainMenuPage.Preference);
            mainMenuPage.ClickAndBack(mainMenuPage.Text);
            mainMenuPage.ClickAndBack(mainMenuPage.Views);
        }

        [Then("all main menu links should be accessible")]
        public void ThenAllMainMenuLinksShouldBeAccessible()
        {
            Assert.Pass("All main menu links were accessed successfully.");
        }

        [AfterScenario]
        public void Cleanup()
        {
            driver?.Quit();
            driver?.Dispose();
        }
    }
}
