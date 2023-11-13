using GFDataApi.Utils;
using GFIniFileEditor.Utils;
using System.Numerics;
using System.Reflection;
using System.Text;

namespace GFDataApi.BaseClasses
{
    public abstract class BaseQuery<IdType, Query> : IBaseQuery<IdType, Query>
        where Query : new()
        where IdType : notnull
    {
        protected CIniFile _File { get; set; }
        protected String FileName = "";
        public Dictionary<IdType,Query> QueryItems { get; protected set; }
        public TranslationLanguages<IdType>? Translations { get; protected set; }

        public BaseQuery()
        {
            _File = new CIniFile();
            QueryItems = new Dictionary<IdType,Query>();            
        }

        protected async virtual Task Load()
        {
            string path = Config.Instance().DataFolder;
            string fullPath = Path.Combine(path, FileName);
            if (_File == null) return;

            _File.Load(fullPath);

            foreach (IniLine line in _File.Values)
            {
                Query Item = await Deserialize(line);

                var id = GetId(Item);
                
                if (id == null) continue;

                QueryItems.Add(id , Item);
            }

            //await LoadTranslations(); independente do Load(), removido daqui para chamar as duas tasks em paralelo
        }

        protected abstract IdType GetId(Query QueryItem);        

        public async virtual Task<bool> SaveToFile(string path)
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




            Encoding big5 = Encoding.GetEncoding("Big5");
            await System.IO.File.WriteAllLinesAsync(path, fileLines, big5);

            return true;
        }        
        protected async Task<bool> LoadTranslations()
        {
            return await Translations!.Load();
        }
        public abstract Task<bool> Init();
        protected abstract Task<Query> Deserialize(IniLine IniLine);
        protected abstract Task<string> Serialize(Query QueryItemObject);
    }
}
