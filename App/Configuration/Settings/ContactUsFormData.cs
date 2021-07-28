namespace App.Configuration.Settings
{
    using System.Collections.Generic;

    public sealed class ContactUsFormData
    {
        public string Name { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public List<string> InvalidEmails { get; set; }
    }
}
