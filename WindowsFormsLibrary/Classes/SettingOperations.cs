using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsLibrary.Classes
{
    public class SettingOperations
    {
        public static string FileName { get; set; } = "appsettings.json";
        public static void Create()
        {
            var settings = new ApplicationSettings
            {
                ShowAgain = true,
                Heading = "Are you sure you want to stop?",
                Text = "Stopping the operation might leave your database in a corrupted state.",
                Caption = "Confirmation",
                VerificationText = "Do not show again"
            };
            var json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(FileName, json);
        }
        /// <summary>
        /// Does <see cref="FileName"/> exists for settings
        /// </summary>
        /// <returns></returns>
        public static bool FileExists => File.Exists(FileName);

        /// <summary>
        /// Read settings from file
        /// </summary>
        /// <returns></returns>
        public static ApplicationSettings GetSetting => 
            JsonConvert.DeserializeObject<ApplicationSettings>(File.ReadAllText(FileName));

        /// <summary>
        /// Indicates whether to show or not show the dialog 
        /// </summary>
        /// <returns></returns>
        public static bool ShowAgain => GetSetting.ShowAgain;

        /// <summary>
        /// Save settings to file
        /// </summary>
        /// <param name="settings"></param>
        public static void SaveChanges(ApplicationSettings settings)
        {
            var json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(FileName, json);
        }
        /// <summary>
        /// Save ShowAgain property only
        /// </summary>
        /// <param name="value"></param>
        public static void SetShowAgain(bool value)
        {
            var current = GetSetting;
            current.ShowAgain = value;
            SaveChanges(current);
        }

    }
}