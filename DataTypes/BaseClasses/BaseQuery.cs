using GFDataApi.DataTypes.Interfaces;

namespace GFDataApi.DataTypes.BaseClasses
{
    public class BaseQuery<IdType, DataType> : IBaseQuery<IdType, DataType>
    where DataType : IDataType<IdType>
    where IdType : notnull
    {
        private readonly IDataContextt<IdType, DataType> DbContext;
        public BaseQuery(IDataContextt<IdType, DataType> DataContext)
        {
            DbContext = DataContext;
        }

        #region "Apagar"
        //protected async virtual Task Load()
        //{
        //    string path = GFConfiguration.Instance.Data.PathToDatabase;
        //    await Load(path);
        /*string CompleteFileName = GFConfiguration.Instance.Data.DefaultLoadPrefix + FileName + ".ini";
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

        }      */


        //        public async virtual Task<bool> Load(string path)
        //        {
        //            string CompleteFileName = GFConfiguration.Instance.Data.DefaultLoadPrefix + FileName + ".ini";
        //            string fullPath = Path.Combine(path, CompleteFileName);
        //            if (_File == null) return false;

        //            _File.Load(fullPath);

        //            foreach (IniLine line in _File.Values)
        //            {
        //                Query Item = await Deserialize(line);

        //                var id = GetId(Item);

        //                if (id == null) continue;

        //                try
        //                {
        //                    QueryItems.Add(id, Item);
        //                }
        //                catch (Exception)
        //                {
        //                    throw;
        //                }
        //            }

        //            return true;
        //        }
        //        protected abstract IdType GetId(Query QueryItem);
        //        protected async virtual Task<bool> SaveToFile(string path, IniFileType type = IniFileType.Client)
        //        {
        //            List<string> fileLines = new() {
        //                $"|{_File.Version}|{_File.Columns}|"
        //            };

        //            var itens = new SortedDictionary<IdType, Query>(QueryItems);

        //            //Horrivel de debugar no modo async
        //#if DEBUG
        //            foreach (var item in itens)
        //            {
        //                fileLines.Add(await Serialize(item.Value));
        //            }
        //#else
        //                var iniStrings = await Task.WhenAll(itens.Select(item => Serialize(item)));
        //                fileLines.AddRange(iniStrings);
        //#endif

        //            string Prefix = type switch
        //            {
        //                IniFileType.Client => "C_",
        //                IniFileType.Server => "S_",
        //                _ => "C_",
        //            };

        //            string CompleteFileName = Prefix + FileName + ".ini";

        //            Encoding big5 = Encoding.GetEncoding("Big5");
        //            await File.WriteAllLinesAsync(Path.Combine(path, FileName), fileLines, big5);
        //            return true;
        //        }
        //        protected async Task<bool> LoadTranslations(string path)
        //        {
        //            return await Translations!.Load(path);
        //        }
        //        public abstract Task<bool> Init();
        //        protected abstract Task<Query> Deserialize(IniLine IniLine);
        //        protected abstract Task<string> Serialize(Query QueryItemObject);
        //        public virtual async Task<bool> Save()
        //        {
        //            var config = GFConfiguration.Instance.Data;

        //            string Path = config.PathToDatabase;

        //            await SaveToFile(Path, IniFileType.Client);

        //            if (config.OutPutClientFiles.Count > 0)
        //            {
        //                foreach (string s in config.OutPutClientFiles)
        //                {
        //                    await SaveToFile(s, IniFileType.Client);
        //                }
        //            }

        //            if (config.OutPutServerFiles.Count > 0)
        //            {
        //                foreach (string s in config.OutPutServerFiles)
        //                {
        //                    await SaveToFile(s, IniFileType.Server);
        //                }
        //            }

        //            return true;
        //        }
        #endregion

        public DataType Get(IdType Id)
        {
            return DbContext.Get(Id);
        }

        public IEnumerable<DataType> Get(Func<DataType, bool> whereClausule)
        {
            return DbContext.Get(whereClausule);
        }

        public DataType Save(DataType Data)
        {
            return DbContext.Save(Data);
        }

        public DataType New()
        {
            return DbContext.New();
        }

        public bool Delete(DataType Data)
        {
            return DbContext.Delete(Data);
        }

        public async Task PreInit()
        {
            await DbContext.PreInitialize();
        }
    }
}
