namespace MentorMate.PageObjects.Careers
{
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

    }
}
