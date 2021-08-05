namespace MentorMate.PageObjects.Careers
{
    using App.Base;
    using NUnit.Framework;

    public class CareersObjectValidator : BasePageValidator<CareersObjectElementMap>
    {
        public void JoinUsPageUrlIsCorrect()
            => Assert.That(this.Map.JoinUsUrl, Is.True);

        public void SectionsAreDisplayed()
        {
            Assert.That(this.Map.DescriptionElement.Displayed);
            Assert.That(this.Map.RequirementsElement.Displayed);
            Assert.That(this.Map.ResponsibilitiesElement.Displayed);
            Assert.That(this.Map.WhatWeOfferElement.Displayed);
        }
    }
}
