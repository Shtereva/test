namespace MentorMate
{
    using PageObjects.ContactUs;
    using PageObjects.Company;
    using PageObjects.Careers;

    public class PagesContainer
    {
        public ContactUsObject ContactUs => new ContactUsObject();

        public CompanyObject Company => new CompanyObject();

        public CareersObject Careers => new CareersObject();
    }
}
