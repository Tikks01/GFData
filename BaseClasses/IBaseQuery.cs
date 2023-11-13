using GFDataApi.Utils;

namespace GFDataApi.BaseClasses
{
    public interface IBaseQuery<IdType, Query>
        where IdType : notnull
        where Query : new()
    {
        Task<bool> Init();
        Task<bool> SaveToFile(string path);
        public Dictionary<IdType, Query> QueryItems { get; }
    }
}
