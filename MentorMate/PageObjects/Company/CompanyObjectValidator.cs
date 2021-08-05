namespace MentorMate.PageObjects.Company
{
    using App.Base;
    using NUnit.Framework;

    public class CompanyObjectValidator : BasePageValidator<CompanyObjectElementMap>
    {
        public void CorrectUrlIsLoaded()
            => Assert.That(this.Map.CorrectUrl, Is.True);

        public void LeaderShipSectionIsDisplayed()
            => Assert.That(this.Map.LeaderShipSection.Displayed);

        public void CorrectFacebookUrlAndProfilePictureAreLoaded()
        {
            Assert.That(this.Map.CorrectFacebookUrl, Is.True);
            Assert.That(this.Map.ProfilePictureElement.Displayed);
        }
    }
}
