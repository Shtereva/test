namespace MentorMate.PageObjects.Careers
{
    using App.Base;
    using App.Configuration;
    using OpenQA.Selenium.Support.UI;

    public class CareersObject : BasePage<CareersObjectElementMap, CareersObjectValidator>
    {
        public void NavigateToCareersPage()
            => this.Map.CareersLink.Click();

        public void ClickOpenPositions()
            => this.Map.OpenPositionsButton.Click();

        public void SelectLocation()
        {
            var selectElement = new SelectElement(this.Map.LocationsDropDown);
            selectElement.SelectByValue("Anywhere");
        }

        public void ChoosePosition()
            => this.Map.OpenPositionElement.Click();

        public void ClickApply()
            => this.Map.ApplyButton.Click();

        public void FillOutApplyForm()
        {
            this.Map.NameField.Clear();
            this.Map.NameField.SendKeys(ConfigurationService.Instance.GetJobApplyForm().Name);

            this.Map.EmailField.Clear();
            this.Map.EmailField.SendKeys(ConfigurationService.Instance.GetContactUsFormData().InvalidEmails[0]);

            this.Map.MobileField.Clear();
            this.Map.MobileField.SendKeys(ConfigurationService.Instance.GetJobApplyForm().Mobile);
        }

        public void ClickSend()
            => this.Map.SendButton.Click();
    }
}
