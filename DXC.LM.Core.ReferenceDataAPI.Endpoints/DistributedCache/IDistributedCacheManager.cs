using System.Collections.Generic;
using System.Threading.Tasks;

namespace DXC.LM.Core.ReferenceDataAPI.Endpoints.DistributedCache
{
    public interface IDistributedCacheManager
    {
        Task ClearAsync();
        Task<IEnumerable<string>> GetKeysAsync();
        Task RemoveAsync(IEnumerable<string> keys);
    }
}
