// This is a base element map that all other element maps are going to derive, along with the current Web Driver instance.

namespace App.Base
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class BasePageElementMap
    {
        protected IWebDriver Browser;
        protected WebDriverWait BrowserWait;

        public BasePageElementMap()
        {
            this.Browser = Driver.Browser;
            this.BrowserWait = Driver.BrowserWait;
        }
    }
}