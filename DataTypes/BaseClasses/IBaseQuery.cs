using GFDataApi.DataTypes.Interfaces;
using GFDataApi.Utils;

namespace GFDataApi.DataTypes.BaseClasses
{
    public interface IBaseQuery<IdType, DataType>
        where IdType : notnull
        where DataType : IDataType<IdType>
    {
        public DataType Get(IdType Id);
        public IEnumerable<DataType> Get(Func<DataType, bool> whereClausule);
        public DataType Save(DataType Data);
        public DataType New();
        public bool Delete(DataType Data);
        public Task PreInit();
    }
}
