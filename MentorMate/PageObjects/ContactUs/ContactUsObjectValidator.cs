namespace MentorMate.PageObjects.ContactUs
{
    using NUnit.Framework;
    using App.Base;

    public class ContactUsObjectValidator : BasePageValidator<ContactUsObjectElementMap>
    {
        public void ErrorMessageIsDisplayed()
        {
            Assert.That(this.Map.ErrorElement.Displayed);
            Assert.That(this.Map.ErrorText, Is.True);
        }
    }
}
