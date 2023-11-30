using System.Text.Json;

namespace GFDataApi.Config
{
    public class GFConfiguration
    {
        public ConfigData Data { get; set; }

        private static GFConfiguration _config;
        public static GFConfiguration Instance { get { return CheckGetInstance(); } }

        public GFConfiguration()
        {
            Data = new ConfigData();
            Load();
        }
        private static GFConfiguration CheckGetInstance()
        {
            _config ??= new GFConfiguration();
            return _config;
        }
        
        private void Load()
        {
            var path = Environment.CurrentDirectory;

            path = Path.Combine(path, "Config.json");

            if (File.Exists(path))
            {
                var config = File.ReadAllText(path);

                ConfigData? d = new ConfigData();

                d = JsonSerializer.Deserialize<ConfigData>(config);

                if (d != null)
                {
                    Data = d;
                }
            }            
        }
    }
}
