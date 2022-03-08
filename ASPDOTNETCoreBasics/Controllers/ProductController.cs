using Microsoft.AspNetCore.Mvc;

namespace ASPDOTNETCoreBasics.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int id,int catid)
        {
            return View();
        }
    }
}
