using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

namespace aspnet_core_dotnet_core.Controllers
{
    public class HomeController : Controller
    {

    //     private readonly IDistributedCache _distributedCache;
 
	// public HomeController(IDistributedCache distributedCache)
	// {
	// 	_distributedCache = distributedCache;
	// }
    
        public IActionResult Index()
        {
        
            // var cacheKey = "TheTime";
            // _distributedCache.SetString(cacheKey, DateTime.UtcNow.ToString());

            // var existingTime = _distributedCache.GetString(cacheKey);
            // ViewData[cacheKey] = existingTime;  
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}