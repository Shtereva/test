namespace MusalaSoft.PageObjects.Careers
{
    using System.Collections.Generic;
    using System.Linq;
    using App.Base;
    using OpenQA.Selenium;

    public class CareersObjectElementMap : BasePageElementMap
    {
        public IWebElement CareersLink
            => this.Browser
                .FindElement(By.Id("navbar"))
                .FindElements(By.ClassName("main-link"))[4];

        public IWebElement OpenPositionsButton
            => this.Browser.FindElement(By.ClassName("contact-label-code"));

        public bool JoinUsUrl
            => this.Browser.Url.Equals("https://www.musala.com/careers/join-us/");

        public IWebElement LocationsDropDown
            => this.Browser.FindElement(By.Id("get_location"));

        public IWebElement OpenPositionElement
            => this.BrowserWait.Until(es => es.FindElements(By.ClassName("card-jobsHot"))[4]);

        public IWebElement DescriptionElement
            => this.Browser.FindElements(By.ClassName("requirements"))
                .First(e => e.FindElement(By.TagName("h2")).Text == "General description");

        public IWebElement RequirementsElement
            => this.Browser.FindElements(By.ClassName("requirements"))
                .First(e => e.FindElement(By.TagName("h2")).Text == "Requirements");

        public IWebElement ResponsibilitiesElement
            => this.Browser.FindElements(By.ClassName("requirements"))
                .First(e => e.FindElement(By.TagName("h2")).Text == "Responsibilities");

        public IWebElement WhatWeOfferElement
            => this.Browser.FindElements(By.ClassName("requirements"))
                .First(e => e.FindElement(By.TagName("h2")).Text == "What we offer");

        public IWebElement ApplyButton
            => this.BrowserWait.Until(e => e.FindElement(By.ClassName("btn-join-us")));

        public IWebElement NameField
            => this.Browser.FindElement(By.Id("cf-1"));

        public IWebElement EmailField
            => this.Browser.FindElement(By.Id("cf-2"));

        public IWebElement MobileField
            => this.Browser.FindElement(By.Id("cf-3"));

        public IWebElement SendButton
            => this.Browser.FindElement(By.ClassName("btn-cf-submit"));

        public bool ErrorMessages
            => this.Browser.PageSource.Contains("The field is required.")
               && this.Browser.PageSource.Contains("The e-mail address entered is invalid.")
               && this.Browser.PageSource.Contains("The telephone number is invalid.");

        public IWebElement UploadFileElement
            => this.Browser.FindElement(By.Id("uploadtextfield"));

        public List<IWebElement> PositionsByCity
            => this.Browser.FindElements(By.ClassName("card-jobsHot"))
                .Where(
                    e => e.FindElement(By.ClassName("card-jobsHot__location")).Text.Contains("Sofia"))
                .ToList();
    }
}
