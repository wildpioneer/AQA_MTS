using System.Reflection;
using DB_Npgsql.Models;
using DB_Npgsql.Models.Enums;
using Microsoft.Extensions.Configuration;

namespace DB_Npgsql.Helpers.Configuration
{
    public static class Configurator
    {
        private static readonly Lazy<IConfiguration> s_configuration;
        public static IConfiguration Configuration => s_configuration.Value;

        static Configurator()
        {
            s_configuration = new Lazy<IConfiguration>(BuildConfiguration);
        }

        private static IConfiguration BuildConfiguration()
        {
            var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var builder = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json");

            var appSettingFiles = Directory.EnumerateFiles(basePath ?? string.Empty, "appsettings.*.json");

            foreach (var appSettingFile in appSettingFiles)
            {
                builder.AddJsonFile(appSettingFile);
            }

            return builder.Build();
        }

        public static AppSettings AppSettings
        {
            get
            {
                var appSettings = new AppSettings();
                var child = Configuration.GetSection("AppSettings");

                appSettings.URL = child["URL"];
                appSettings.URI = child["URI"];

                return appSettings;
            }
        }

        public static DbSettings DbSettings
        {
            get
            {
                var dbSettings = new DbSettings();
                var child = Configuration.GetSection("DbSettings");

                dbSettings.DB_Driver = child["DB_Driver"];
                dbSettings.DB_Server = child["DB_Server"];
                dbSettings.DB_Port = child["DB_Port"];
                dbSettings.DB_Name = child["DB_Name"];
                dbSettings.DB_Username = child["DB_Username"];
                dbSettings.DB_Password = child["DB_Password"];

                return dbSettings;
            }
        }

        public static List<User?> Users
        {
            get
            {
                List<User?> users = new List<User?>();
                var child = Configuration.GetSection("Users");
                foreach (var section in child.GetChildren())
                {
                    var user = new User
                    {
                        Password = section["Password"],
                        Username = section["Username"]
                    };
                    user.UserType = section["UserType"].ToLower() switch
                    {
                        "admin" => UserType.Admin,
                        "user" => UserType.Standard,
                        _ => user.UserType
                    };

                    users.Add(user);
                }

                return users;
            }
        }

        public static User? Admin => Users.Find(x => x?.UserType == UserType.Admin);

        public static User? UserByUsername(string username) => Users.Find(x => x?.Username == username);
    }
}