namespace App.Configuration.Settings
{
    public sealed class WebSettings
    {
        public int ElementWaitTimeout { get; set; }

        public Browser Chrome { get; set; }

        public Browser Firefox { get; set; }

        public string BrowserMode { get; set; }
    }
}