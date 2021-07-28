// The main goal of the class below is to provide a direct way to initialize and access the web driver instance.
// The driver is initialized through the StartBrowser method where the client is capable to set a particular browser
// type and timeout.
// The stop of the browser that is usually performed on TestTeardown is also an easy task via the static
// StopBrowser method.
// If the client tries to access the instance before the initialization, an exception is thrown.

namespace App.Base
{
    using System;
    using Configuration;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Support.UI;

    public static class Driver
    {
        private static WebDriverWait _browserWait;

        private static IWebDriver _browser;

        public static ChromeOptions ChromeOptions { get; set; }

        public static FirefoxOptions FirefoxOptions { get; set; }

        public static IWebDriver Browser
        {
            get => _browser ?? throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");
            private set => _browser = value;
        }

        public static WebDriverWait BrowserWait
        {
            get
            {
                if (_browserWait == null || _browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
                }

                return _browserWait;
            }
            private set => _browserWait = value;
        }

        public static void StartBrowser(BrowserTypes browserType = BrowserTypes.Chrome)
        {
            switch (browserType)
            {
                case BrowserTypes.Chrome:
                    ChromeOptions = new ChromeOptions();
                    ChromeOptions.AddArgument(ConfigurationService.Instance.GetWebSettings().BrowserMode);
                    Browser = new ChromeDriver(ChromeOptions);
                    break;
                case BrowserTypes.Firefox:
                    FirefoxOptions = new FirefoxOptions();
                    FirefoxOptions.AddArgument(ConfigurationService.Instance.GetWebSettings().BrowserMode);
                    Browser = new FirefoxDriver(FirefoxOptions);
                    break;
            }

            Browser.Manage().Window.Maximize();
            
            Browser.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(
                                        ConfigurationService.Instance.GetWebSettings().Firefox.PageLoadTimeout);

            Browser.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(
                                        ConfigurationService.Instance.GetWebSettings().Firefox.ScriptTimeout);

            Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(
                                        ConfigurationService.Instance.GetWebSettings().Firefox.ImplicitWait);

            BrowserWait = new WebDriverWait(
                Browser, TimeSpan.FromSeconds(ConfigurationService.Instance.GetWebSettings().ElementWaitTimeout));
        }

        public static void StopBrowser()
        {
            Browser.Quit();
            Browser = null;
            BrowserWait = null;
        }
    }
}