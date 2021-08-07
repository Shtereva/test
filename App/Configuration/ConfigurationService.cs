// A class that allows us to access the values in the right config file.

namespace App.Configuration
{
    using Settings;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using Microsoft.Extensions.Configuration;

    public sealed class ConfigurationService
    {
        private static ConfigurationService _instance;

        public IConfigurationRoot Root { get; }

        public ConfigurationService() => this.Root = this.InitializeConfiguration();

        public static ConfigurationService Instance
        {
            get { return _instance ??= new ConfigurationService(); }
        }

        public WebSettings GetWebSettings()
        {
            var result = Instance
                .Root.GetSection("webSettings")
                .Get<WebSettings>();

            return result ?? throw new ConfigurationNotFoundException(
                typeof(WebSettings).ToString());
        }

        public UrlSettings GetUrlSettings()
        {
            var result = Instance
                            .Root
                            .GetSection("urlSettings")
                            .Get<UrlSettings>();

            return result ?? throw new ConfigurationNotFoundException(typeof(UrlSettings).ToString());
        }

        public ContactUsFormData GetContactUsFormData()
        {
            var result = Instance
                            .Root
                            .GetSection("contactUsFormData")
                            .Get<ContactUsFormData>();

            return result ?? throw new ConfigurationNotFoundException(typeof(ContactUsFormData).ToString());
        }

        public JobApplyForm GetJobApplyForm()
        {
            var result = Instance
                .Root
                .GetSection("jobApplyForm")
                .Get<JobApplyForm>();

            return result ?? throw new ConfigurationNotFoundException(typeof(JobApplyForm).ToString());
        }

        private IConfigurationRoot InitializeConfiguration()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            var filesInExecutionDir = Directory.GetFiles(path + @"\Configuration");

            var settingsFile = filesInExecutionDir
                                    .FirstOrDefault(x => x.Contains("testSettings") && x.EndsWith(".json"));

            var builder = new ConfigurationBuilder();

            if (settingsFile != null)
            {
                builder.AddJsonFile(settingsFile, optional: true, reloadOnChange: true);
            }

            return builder.Build();
        }
    }
}