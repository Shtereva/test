namespace MusalaSoft.PageObjects.ContactUs
{
    using App.Base;
    using App.Configuration;

    public class ContactUsObject : BasePage<ContactUsObjectElementMap, ContactUsObjectValidator>
    {
        public void ClickContactUs()
            => this.Map.ContactUsElement.Click();

        public void FillOutContactUsForm(int index)
        {
            this.Map.Name.Clear();
            this.Map.Name.SendKeys(ConfigurationService.Instance.GetContactUsFormData().Name);

            this.Map.Email.Clear();
            this.Map.Email.SendKeys(ConfigurationService.Instance.GetContactUsFormData().InvalidEmails[index]);

            this.Map.Subject.Clear();
            this.Map.Subject.SendKeys(ConfigurationService.Instance.GetContactUsFormData().Subject);

            this.Map.Message.Clear();
            this.Map.Message.SendKeys(ConfigurationService.Instance.GetContactUsFormData().Message);
        }

        public void ClickSend()
            => this.Map.SendButton.Click();
    }
}
