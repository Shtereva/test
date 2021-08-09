namespace MusalaSoft
{
    using PageObjects.Careers;
    using PageObjects.Company;
    using PageObjects.ContactUs;

    public class PagesContainer
    {
        public ContactUsObject ContactUs => new ContactUsObject();

        public CompanyObject Company => new CompanyObject();

        public CareersObject Careers => new CareersObject();
    }
}
