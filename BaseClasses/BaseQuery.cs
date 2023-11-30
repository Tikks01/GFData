using GFDataApi.Config;
using GFDataApi.Enums;
using GFDataApi.Utils;
using GFIniFileEditor.Utils;
using System.Text;

namespace GFDataApi.BaseClasses
{
    public abstract class BaseQuery<IdType, Query> : IBaseQuery<IdType, Query>
        where Query : new()
        where IdType : notnull
    {
        protected CIniFile _File { get; set; }
        protected string FileName { get; set; } = "";
        public Dictionary<IdType,Query> QueryItems { get; protected set; }
        public TranslationLanguages<IdType>? Translations { get; protected set; }

        public BaseQuery()
        {
            _File = new CIniFile();
            QueryItems = new Dictionary<IdType,Query>();            
        }

        protected async virtual Task Load()
        {
            string path = GFConfiguration.Instance.Data.PathToDatabase;
            string CompleteFileName = GFConfiguration.Instance.Data.DefaultLoadPrefix + FileName + ".ini";
            string fullPath = Path.Combine(path, CompleteFileName);            
            if (_File == null) return;

            _File.Load(fullPath);

            foreach (IniLine line in _File.Values)
            {
                Query Item = await Deserialize(line);

                var id = GetId(Item);
                
                if (id == null) continue;

                try
                {
                    QueryItems.Add(id, Item);
                }
                catch (Exception)
                {

                    throw;
                }
                
            }            
        }

        protected abstract IdType GetId(Query QueryItem);        

        protected async virtual Task<bool> SaveToFile(string path, IniFileType type = IniFileType.Client)
        {
            List<string> fileLines = new List<string> {
                $"|{_File.Version}|{_File.Columns}|"
            };

            var itens = new SortedDictionary<IdType, Query>(QueryItems);

            //Horrivel de debugar no modo async
            #if DEBUG
                foreach (var item in itens)
                {
                    fileLines.Add(await Serialize(item.Value));
                }
            #else
                var iniStrings = await Task.WhenAll(itens.Select(item => Serialize(item)));
                fileLines.AddRange(iniStrings);
            #endif

            string Prefix = type switch
            {
                IniFileType.Client => "C_",
                IniFileType.Server => "S_",
                _ => "C_",
            };

            string CompleteFileName = Prefix + FileName + ".ini";

            Encoding big5 = Encoding.GetEncoding("Big5");
            await File.WriteAllLinesAsync(Path.Combine( path, FileName), fileLines, big5);
            return true;
        }        
        protected async Task<bool> LoadTranslations()
        {
            return await Translations!.Load();
        }
        public abstract Task<bool> Init();
        protected abstract Task<Query> Deserialize(IniLine IniLine);
        protected abstract Task<string> Serialize(Query QueryItemObject);        
        public virtual async Task<bool> Save()
        {
            var config = GFConfiguration.Instance.Data;

            string Path = config.PathToDatabase;

            await SaveToFile(Path, IniFileType.Client);            

            if (config.OutPutClientFiles.Count > 0)
            {
                foreach (string s in  config.OutPutClientFiles)
                {
                    await SaveToFile(s, IniFileType.Client);
                }
            }            

            if (config.OutPutServerFiles.Count > 0)
            {
                foreach (string s in config.OutPutServerFiles)
                {
                    await SaveToFile(s, IniFileType.Server);
                }
            }

            return true;
        }           
    }
}
