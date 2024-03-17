using GFDataApi.Data;
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
    }
}
