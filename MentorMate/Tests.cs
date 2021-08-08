namespace MentorMate
{
    using App;
    using App.Base;
    using NUnit.Framework;

    public class Tests : BaseTest
    {
        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void SubmittingContactUsFormWithInvalidEmailShouldReturnErrorMessage(int index)
        {
            // Arrange
            var pages = PageFactory.Create<PagesContainer>();
            
            // Act
            pages.ContactUs.Navigate();
            pages.ContactUs.ClickContactUs();
            pages.ContactUs.FillOutContactUsForm(index);
            pages.ContactUs.ClickSend();

            // Assert
            pages.ContactUs.Validate().ErrorMessageIsDisplayed();
        }

        [Test]
        public void CompanyPageUrlShouldBeCorrect()
        {
            // Arrange
            var pages = PageFactory.Create<PagesContainer>();

            // Act
            pages.Company.Navigate();
            pages.Company.NavigateToCompanyPage();

            // Assert
            pages.Company.Validate().CorrectUrlIsLoaded();
        }

        [Test]
        public void LeadershipSectionShouldBeVisible()
        {
            // Arrange
            var pages = PageFactory.Create<PagesContainer>();

            // Act
            pages.Company.Navigate();
            pages.Company.NavigateToCompanyPage();

            // Assert
            pages.Company.Validate().CorrectUrlIsLoaded();
        }

        [Test]
        public void FaceBookUrlAndProfilePictureShouldBeCorrect()
        {
            // Arrange
            var pages = PageFactory.Create<PagesContainer>();

            // Act
            pages.Company.Navigate();
            pages.Company.NavigateToCompanyPage();
            pages.Company.ClickFacebookLink();
            pages.Company.AcceptCookies();

            // Assert
            pages.Company.Validate().CorrectFacebookUrlAndProfilePictureAreLoaded();
        }

        [Test]
        public void JoinUsPageUrlShouldBeCorrect()
        {
            // Arrange
            var pages = PageFactory.Create<PagesContainer>();

            // Act
            pages.Careers.Navigate();
            pages.Careers.NavigateToCareersPage();
            pages.Careers.ClickOpenPositions();

            // Assert
            pages.Careers.Validate().JoinUsPageUrlIsCorrect();
        }

        [Test]
        public void FourMainSectionOfThePositionAndApplyButtonShouldBeDisplayed()
        {
            // Arrange
            var pages = PageFactory.Create<PagesContainer>();

            // Act
            pages.Careers.Navigate();
            pages.Careers.NavigateToCareersPage();
            pages.Careers.ClickOpenPositions();
            pages.Careers.SelectLocation(("Anywhere"));
            pages.Careers.ChoosePosition();

            // Assert
            pages.Careers.Validate().SectionsAreDisplayed();
            pages.Careers.Validate().ApplyButtonIsDisplayed();
        }

        [Test]
        public void ApplyFormWithNegativeDataShouldReturnErrorMessage()
        {
            // Arrange
            var pages = PageFactory.Create<PagesContainer>();

            // Act
            pages.Careers.Navigate();
            pages.Careers.NavigateToCareersPage();
            pages.Careers.ClickOpenPositions();
            pages.Careers.SelectLocation("Anywhere");
            pages.Careers.ChoosePosition();
            pages.Careers.ClickApply();
            pages.Careers.FillOutApplyForm();
            pages.Careers.ClickSend();

            // Assert
            pages.Careers.Validate().ErrorMessagesAreShown();
        }

        [Test]
        public void PrintAvailablePositionsByCity()
        {
            // Arrange
            var pages = PageFactory.Create<PagesContainer>();

            // Act
            pages.Careers.Navigate();
            pages.Careers.NavigateToCareersPage();
            pages.Careers.ClickOpenPositions();
            pages.Careers.SelectLocation("Sofia");
            pages.Careers.Print();

            // Assert
            
        }
    }
}