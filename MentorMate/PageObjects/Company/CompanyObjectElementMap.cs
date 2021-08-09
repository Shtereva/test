namespace MusalaSoft.PageObjects.Company
{
    using System.Linq;
    using App.Base;
    using OpenQA.Selenium;

    public class CompanyObjectElementMap : BasePageElementMap
    {
        public IWebElement CompanyLink
            => this.Browser
                .FindElement(By.Id("navbar"))
                .FindElements(By.ClassName("main-link"))
                .First();

        public bool CorrectUrl
            => this.Browser.Url.Equals("https://www.musala.com/company/");

        public IWebElement LeaderShipSection
            => this.Browser.FindElement(By.ClassName("company-members"));

        public IWebElement FacebookLink
            => this.Browser.FindElement(By.ClassName("musala-icon-facebook"));

        public IWebElement AcceptCookiesButton
            => this.BrowserWait.Until(
                e => e.FindElement(By.ClassName("_9o-t")));

        public bool CorrectFacebookUrl
            => this.Browser.Url.Equals("https://www.facebook.com/MusalaSoft?fref=ts");

        public IWebElement ProfilePictureElement
            => this.Browser.FindElement(By.ClassName("_2dgj"));
    }
}
