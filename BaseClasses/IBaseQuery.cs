using GFDataApi.Utils;

namespace GFDataApi.BaseClasses
{
    public interface IBaseQuery<IdType, Query>
        where IdType : notnull
        where Query : new()
    {
        Task<bool> Init();
        Task<bool> Save();        
        public Dictionary<IdType, Query> QueryItems { get; }        
    }
}
