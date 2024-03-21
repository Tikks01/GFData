using GFDataApi.DataTypes.Interfaces;

namespace GFDataApi.DataTypes.BaseClasses
{
    public interface IDataContext<IdType, DataType>
        where DataType : IDataType<IdType>
        where IdType : notnull
    {
        Task PreInitialize();
        DataType? Get(IdType Id);
        IEnumerable<DataType> Get(Func<DataType, bool>? whereClausule);
        bool Save(DataType Data);
        DataType New();
        bool Delete(DataType Data);
    }
}
