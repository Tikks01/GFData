using GFDataApi.Data;
using GFDataApi.DataContext.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFDataApi.DataContext.Implementations.PGSQL
{
    public class ItemPGSQLDataContext : IItemDataContext
    {
        public bool Delete(ItemData Data)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public Task PreInitialize()
        {
            throw new NotImplementedException();
        }

        public ItemData Save(ItemData Data)
        {
            throw new NotImplementedException();
        }
    }
}
