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

        public void ApplyButtonIsDisplayed()
            => Assert.That(this.Map.ApplyButton.Displayed);

        public void ErrorMessagesAreShown()
            => Assert.That(this.Map.ErrorMessages, Is.True);
    }
}
