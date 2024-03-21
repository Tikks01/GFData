using GFDataApi.Data;
using GFDataApi.DataTypes.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFDataApi.DataContext.Interfaces
{
    public interface IItemDataContext : IDataContext<uint, ItemData>
    {
    }
}
