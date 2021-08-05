namespace MentorMate.PageObjects.Company
{
    using System;
    using System.Linq;
    using App.Base;

    public class CompanyObject : BasePage<CompanyObjectElementMap, CompanyObjectValidator>
    {
        public void NavigateToCompanyPage()
            => this.Map.CompanyLink.Click();

        public void ClickFacebookLink()
            => this.Map.FacebookLink.Click();

        public void AcceptCookies()
        {
            var windowsName = Driver.Browser.WindowHandles[1];
            Driver.Browser.SwitchTo().Window(windowsName);

            this.Map.AcceptCookiesButton.Click();
        }
    }
}
