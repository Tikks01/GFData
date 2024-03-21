using GFDataApi.Data;
using GFDataApi.DataContext.Interfaces;
using System.Linq;

namespace GFDataApi.DataContext.Implementations.PGSQL
{
    public class ItemPGSQLDataContext : IItemDataContext
    {
        public bool Delete(ItemData Data)
        {
            if (Data == null) return false;

            using (PgSqlDbContext context = new PgSqlDbContext())
            {
                context.Remove(Data);
                return context.SaveChanges() > 0;
            }
        }

        public ItemData? Get(uint Id)
        {            
            using (PgSqlDbContext context = new())
            {
                return context.Item.Where(i => i.Id == Id).FirstOrDefault();
            }            
        }

        public IEnumerable<ItemData> Get(Func<ItemData, bool>? whereClausule)
        {            
            using (PgSqlDbContext context = new())
            {
                if (whereClausule == null)
                {
                    return context.Item.ToList();
                }                
                
                return context.Item.Where(whereClausule);                
            }            
        }

        public ItemData New()
        {
            using (PgSqlDbContext context = new())
            {
                var data = new ItemData();
                context.Item.Add(data);

                return data;                
            }
        }

        public Task PreInitialize()
        {
            throw new NotImplementedException();
        }

        public bool Save(ItemData Data)
        {
            if (Data == null) return false;

            using (PgSqlDbContext context = new())
            {
                if (!context.Item.Contains(Data)) return false;

                context.Item.Update(Data);
                return context.SaveChanges() > 0;                
            }            
        }

        public async Task<bool> SaveMany(IEnumerable<ItemData> Data)
        {
            using (PgSqlDbContext context = new())
            {
                foreach (ItemData item in Data)
                {
                    if (context.Item.Contains(item))
                    {
                        context.Item.Update(item);
                    } else
                    {
                        context.Item.Add(item);
                    }
                }

                return await context.SaveChangesAsync() == Data.Count();
            }
        }
    }
}
