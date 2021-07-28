namespace MentorMate
{
    using App;
    using App.Base;
    using NUnit.Framework;

    public class Tests : BaseTest
    {
        [Test]
        [Repeat(5)]
        public void SubmittingContactUsFormWithInvalidEmailShouldReturnErrorMessage()
        {
            // Arrange
            var pages = PageFactory.Create<PagesContainer>();

            // Act
            pages.ContactUsObject.Navigate();
            pages.ContactUsObject.ClickContactUs();
            pages.ContactUsObject.FillOutContactUsForm();
            

            // Assert
        }
    }
}