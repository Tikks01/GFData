using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFDataApi.Utils
{
    public class Config
    {
        public string DataFolder { get; set; }
        public string TranslationsFolder { get; set; }

        private static readonly string PATH_TRANSLATE = "C:\\Users\\zoapb\\OneDrive\\Área de Trabalho\\751 agr vai\\translate";
        private static readonly string PATH_DB = "C:\\Users\\zoapb\\OneDrive\\Área de Trabalho\\751 agr vai";

        public static Config _instance;

        public string PathTranslate { get { return GetPathTranslate(); } }
        public string PathDb { get { return GetPathDb(); } }

        public string GetPathTranslate()
        {
            return PATH_TRANSLATE;
        }

        public string GetPathDb()
        {
            return PATH_DB;
        }

        public static Config Instance()
        {
            _instance ??= new Config();
            return _instance;
        }

        public Config()
        {
            DataFolder = "C:\\Users\\zoapb\\OneDrive\\Área de Trabalho\\751 agr vai";
            TranslationsFolder = "C:\\Users\\zoapb\\OneDrive\\Área de Trabalho\\751 agr vai\\translate";
        }
    }
}
