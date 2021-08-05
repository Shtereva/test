namespace MentorMate.PageObjects.Careers
{
    using App.Base;
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
    }
}
