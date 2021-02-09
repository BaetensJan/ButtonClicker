using System;
using NUnit.Framework;
using HP.LFT.SDK;
using HP.LFT.SDK.WPF;

namespace UFTDeveloperTestProject1
{
    [TestFixture]
    public class UftDeveloperTest : UnitTestClassBase
    {

        private IAut application;

        [OneTimeSetUp]
        public void TestFixtureSetUp()
        {
            // Setup once per fixture
        }

        [SetUp]
        public void SetUp()
        {
            // Before each test


            // Define in autConfig located in your %localappdata%/LeanFT/config folder.
            // Create authConfig.json file if not present and structure it like described here
            // https://admhelp.microfocus.com/uftdev/en/15.0-15.0.2/HelpCenter/Content/HowTo/TestObjects_Manual.htm#Run
            // To make your app start up, follow instructions here
            // https://admhelp.microfocus.com/uftdev/en/15.0-15.0.2/NetSDKReference/webframe.html#CodeSamples_.NET/LaunchAUT_Samples.htm

            application = Desktop.LaunchAut("C:\\Users\\Jan Baetens\\source\\repos\\ButtonClicker\\ButtonClicker\\bin\\Debug\\ButtonClicker.exe");
        }

        [Test]
        public void Test()
        {
            var youClicked0TimesOnTheButtonWindow = Desktop.Describe<IWindow>(new WindowDescription
            {
                FullType = @"window",
                ObjectName = @"MainWindow",
                WindowTitleRegExp = @"MainWindow"
            });

            var clickMeButton = youClicked0TimesOnTheButtonWindow.Describe<IButton>(new ButtonDescription
            {
                ObjectName = @"clickMeButton",
                Text = @"Click Me!"
            });
            clickMeButton.Click();

            clickMeButton.Click();

            clickMeButton.Click();

            clickMeButton.Click();

            clickMeButton.Click();
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up after each test
            application.Close();
        }

        [OneTimeTearDown]
        public void TestFixtureTearDown()
        {
            // Clean up once per fixture
        }
    }
}
