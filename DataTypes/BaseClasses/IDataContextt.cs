using GFDataApi.DataTypes.Interfaces;

namespace GFDataApi.DataTypes.BaseClasses
{
    public interface IDataContextt<IdType, DataType>
        where DataType : IDataType<IdType>
        where IdType : notnull
    {
        Task PreInitialize();
        DataType? Get(IdType Id);
        IEnumerable<DataType> Get(Func<DataType, bool>? whereClausule);
        DataType Save(DataType Data);
        DataType New();
        bool Delete(DataType Data);
    }
}
