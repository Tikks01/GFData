using GFDataApi.Utils;
using System.Text;

namespace GFIniFileEditor.Utils
{
    public class CIniFile
    {        
        public string? Version { get; private set; }
        public int Columns { get; private set; }        
        private string? FilePath;
        private Encoding _Encoding;
        private string? FileName;        

        private const string CARIAGERETURN_NEWLINE_REPLACE = "{U+000D}{U+000A}";
        public List<IniLine> Values { get; private set; }

        public CIniFile()
        {
            _Encoding = Encoding.GetEncoding("big5");
            Values = new List<IniLine>();
        }       

        public bool Load(string filePath)
        {
            if (!File.Exists(filePath)) return false;

            FilePath = filePath;
            Values.Clear();

            if (!LoadHeader()) return false;            

            LoadContent();

            return true;
        }                   
        
        public bool LoadTranslation(string filePath, int Columns, Encoding encoding)
        {
            if (!File.Exists(filePath)) return false;
            
            if (encoding != null)
            {
                _Encoding = encoding;
            }

            FilePath = filePath;

            this.Columns = Columns;

            LoadContent(true);

            return true;
        }

        private bool LoadHeader()
        {
            if (FilePath == null) return false;
            FileName = Path.GetFileNameWithoutExtension(FilePath);

            string firstLine = File.ReadLines(FilePath).First();
            if (string.IsNullOrEmpty(firstLine)) return false;

            var values = firstLine.Split('|');
            if (values.Length != 4) return false;

            Version = values[1];
            Columns = int.Parse(values[2]);
            return true;
        }

        private void LoadContent(bool isTranslate = false)
        {
            if (FilePath == null) return;            

            StringBuilder sb = new();

            using (StreamReader sr = new StreamReader(FilePath, _Encoding))
            {
                string? currentLine;
                int currentReadedColumns = 0;

                if (!isTranslate)
                    currentLine = sr.ReadLine(); // Skip First Line, Version Number

                while ((currentLine = sr.ReadLine()) != null)
                {
                    currentReadedColumns += currentLine.Count(c => c == '|');
                    sb.Append(currentLine);

                    if (currentReadedColumns >= Columns)
                    {
                        currentReadedColumns = 0;
                        Values.Add(new IniLine( sb.ToString() ));
                        sb.Clear();
                    }
                    else if (currentReadedColumns > 0 && currentReadedColumns < Columns)
                    {
                        sb.Append(CARIAGERETURN_NEWLINE_REPLACE);
                    }

                }
            }            
        }
        
        public string? NameWithouPrefix()
        {
            return FileName?[2..];
        }
    }
}
