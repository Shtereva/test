namespace App.Configuration
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    internal class ConfigurationNotFoundException : Exception
    {
        public ConfigurationNotFoundException()
        {
        }

        public ConfigurationNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public ConfigurationNotFoundException(string configurationType)
            : base($"Configuration section for {configurationType} was not found. Please add the section.")
        {
        }

        protected ConfigurationNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}