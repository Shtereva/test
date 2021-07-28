namespace App.Base
{
    public class BasePageValidator<TM>
        where TM : BasePageElementMap, new()
    {
        protected TM Map
            => new TM();
    }
}