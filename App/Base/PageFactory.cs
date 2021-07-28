namespace App.Base
{
    using System;

    public class PageFactory
    {
        public static TPage Create<TPage>()
        {
            var page = (TPage)Activator.CreateInstance(typeof(TPage));
            
            return page;
        }
    }
}