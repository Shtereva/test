namespace App.Configuration.Settings
{
    public sealed class Browser
    {
        public int PageLoadTimeout { get; set; }

        public int ScriptTimeout { get; set; }

        public int ImplicitWait { get; set; }
    }
}