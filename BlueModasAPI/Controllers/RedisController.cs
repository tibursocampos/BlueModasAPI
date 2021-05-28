using EasyCaching.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueModasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedisController : Controller
    {
        private readonly IEasyCachingProvider cachingProvider;
        private readonly IEasyCachingProviderFactory cachingProviderFactory;

        public RedisController(IEasyCachingProviderFactory CachingProviderFactory)
        {
            this.cachingProviderFactory = CachingProviderFactory;
            this.cachingProvider = this.cachingProviderFactory.GetCachingProvider("redis1");         
        }

        [HttpGet("Set")]
        public IActionResult SetItemInQueue()
        {
            cachingProvider.Set("TestKey123", "Este é meu valor", TimeSpan.FromHours(10));
            return Ok();
        }

        [HttpGet("Get")]
        public IActionResult GetItemInQueue()
        {
            var item = cachingProvider.Get<string>("TestKey123");
            return Ok(item);
        }
    }
}
