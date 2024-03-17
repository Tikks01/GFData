using GFDataApi.Data;
using GFDataApi.DataContext.Implementations.IniFile;
using GFDataApi.DataContext.Implementations.PGSQL;
using GFDataApi.DataContext.Interfaces;

namespace GFDataApi.Services
{  
    public class ItemService(IItemDataContext context)
    {
        public ItemData? Get(uint id)
        {
            return context.Get(id);
        }

        public IQueryable<ItemData> GetMany() {
            return context.Get(null).AsQueryable();
        }

        public bool Save(ItemData data)
        {
            if (context.Get(data.Id) == null) return false;

            context.Save(data);
            return true;
        }

        public void PreInitialize()
        {
            context.PreInitialize();
        }

        public async Task<bool> IniFileToPGSQL()
        {
            ItemPGSQLDataContext pgsql = new ItemPGSQLDataContext();
            ItemIniDataContext ini = new ItemIniDataContext();

            await ini.PreInitialize();
            var list = ini.Get(null).ToList();

            return await pgsql.SaveMany(list);            
        }
    }
}
