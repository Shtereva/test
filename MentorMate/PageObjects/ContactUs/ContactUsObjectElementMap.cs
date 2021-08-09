namespace MusalaSoft.PageObjects.ContactUs
{
    using App.Base;
    using OpenQA.Selenium;

    public class ContactUsObjectElementMap : BasePageElementMap
    {
        public IWebElement ContactUsElement
            => this.Browser.FindElement(By.ClassName("contact-label"));

        public IWebElement Name
            => this.Browser.FindElement(By.Id("cf-1"));

        public IWebElement Email
            => this.Browser.FindElement(By.Id("cf-2"));

        public IWebElement Subject
            => this.Browser.FindElement(By.Id("cf-4"));

        public IWebElement Message
            => this.Browser.FindElement(By.Id("cf-5"));

        public IWebElement SendButton
            => this.Browser.FindElement(By.ClassName("btn-cf-submit"));

        public IWebElement ErrorElement
            => this.BrowserWait.Until(e => e.FindElement(By.ClassName("wpcf7-not-valid-tip")));

        public bool ErrorText
            => this.BrowserWait.Until(e => e.PageSource.Contains("The e-mail address entered is invalid."));
    }
}
