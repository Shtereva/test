namespace MentorMate.PageObjects.Careers
{
    using System;
    using System.Linq;
    using System.Text;
    using App.Base;
    using App.Configuration;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class CareersObject : BasePage<CareersObjectElementMap, CareersObjectValidator>
    {
        public void NavigateToCareersPage()
            => this.Map.CareersLink.Click();

        public void ClickOpenPositions()
            => this.Map.OpenPositionsButton.Click();

        public void SelectLocation(string location)
        {
            var selectElement = new SelectElement(this.Map.LocationsDropDown);
            selectElement.SelectByValue(location);
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

            this.Map.UploadFileElement.Clear();
            this.Map.UploadFileElement.SendKeys(@"C:\fakepath\EU_format_CV-BG.doc");
        }

        public void ClickSend()
            => this.Map.SendButton.Click();

        public void Print()
        {
            var positions = this.Map.PositionsByCity
                .Select(e => new
                {
                    City = e.FindElement(By.ClassName("card-jobsHot__location")).Text,
                    Position = e.FindElement(By.ClassName("card-jobsHot__title")).Text,
                    MoreInfo = e.FindElement(By.ClassName("card-jobsHot__link")).GetAttribute("href")
                })
                .OrderBy(e => e.City)
                .ToList();

            var sb = new StringBuilder();

            foreach (var position in positions)
            {
                sb.AppendLine(position.City);
                sb.AppendLine($"Position: {position.Position}");
                sb.AppendLine($"More info: {position.MoreInfo}");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
