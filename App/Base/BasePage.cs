// This is a base class for all page classes.
namespace App.Base
{
    using Configuration;

    public abstract class BasePage<TM, TV>
        where TM : BasePageElementMap, new()
        where TV : BasePageValidator<TM>, new()
    {
        protected readonly string Url = ConfigurationService
            .Instance.GetUrlSettings()
            .MentorMate;

        protected TM Map => new TM();

        public TV Validate() => new TV();

        public virtual void Navigate(string part = "")
            => Driver.Browser.Navigate().GoToUrl(string.Concat(this.Url, part));
    }
}