using System.Threading.Tasks;
using DXC.LM.Core.ReferenceDataAPI.Endpoints.DistributedCache;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DXC.LM.Core.ReferenceDataAPI.Endpoints.Controllers
{
    [ApiController][Authorize]
    [Route("/CacheManagement")]
    [ResponseCache(NoStore = true)]
    public class CacheManagementController : Controller
    {
        private readonly IDistributedCacheManager _cacheManager;

        public CacheManagementController(IDistributedCacheManager cacheManager)
        {
            _cacheManager = cacheManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var keys = await _cacheManager.GetKeysAsync();
            return Ok(keys);
        }

        [HttpDelete("{key}")]
        public async Task<IActionResult> DeleteSpecific(string key)
        {
            await _cacheManager.RemoveAsync(new []{ key });
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAll()
        {
            await _cacheManager.ClearAsync();
            return Ok();
        }
    }
}
