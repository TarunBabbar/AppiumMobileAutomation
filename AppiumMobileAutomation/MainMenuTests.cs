using NUnit.Framework;

namespace AppiumMobileAutomation
{
    public class MainMenuTests : BaseTest
    {
        /// <summary>
        /// Navigates through all main menu links in the ApiDemos app, clicks each one, and returns to the main menu.
        /// </summary>
        [Test]
        [Description("Verifies that all main menu links in the ApiDemos app can be clicked and navigated back successfully.")]
        [Author("TarunBabbar")]
        public void Should_Navigate_And_Click_All_MainMenu_Links()
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
    }
}