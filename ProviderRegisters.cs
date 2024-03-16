using GFDataApi.DataContext.Implementations.PGSQL;
using GFDataApi.DataContext.Interfaces;
using GFDataApi.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFDataApi
{
    public static class ProviderRegisters
    {
        public static void RegisterPgSql(IServiceCollection service)
        {
            service.AddSingleton<IItemDataContext, ItemPGSQLDataContext>();
        }

        public static void RegisterServices(IServiceCollection service)
        {
            service.AddSingleton<ItemService>();
        }        
    }
}
