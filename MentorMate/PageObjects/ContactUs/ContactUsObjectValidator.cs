namespace MusalaSoft.PageObjects.ContactUs
{
    using App.Base;
    using NUnit.Framework;

    public class ContactUsObjectValidator : BasePageValidator<ContactUsObjectElementMap>
    {
        public void ErrorMessageIsDisplayed()
        {
            Assert.That(this.Map.ErrorElement.Displayed);
            Assert.That(this.Map.ErrorText, Is.True);
        }
    }
}
