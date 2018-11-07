using System.Configuration;

namespace YahooTest
{
    public class Configuration
    {
        public static string GetEnviromentVar(string var, string defaultValue)
        {
            return ConfigurationSettings.AppSettings[var] ?? defaultValue;
        }

        public static string ElementTimeout => GetEnviromentVar("ElementTimeout", defaultValue: "45");

        public static string DataDrivenFileXML => GetEnviromentVar("DataDrivenFileXML", defaultValue: "D:/SeleniumTests/Source/Source/DDTestFile.xml");

        public static string Browser => GetEnviromentVar("Browser", defaultValue: "Firefox");

        public static string StartUrl => GetEnviromentVar("StartUrl", defaultValue: "https://www.yahoo.com/");
    }
}
