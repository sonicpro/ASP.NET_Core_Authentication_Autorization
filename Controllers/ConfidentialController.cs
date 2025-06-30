using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_Authorization.Controllers
{
    [Authorize]
    public class ConfidentialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
