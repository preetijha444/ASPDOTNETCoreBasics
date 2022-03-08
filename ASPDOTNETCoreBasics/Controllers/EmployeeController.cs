using Microsoft.AspNetCore.Mvc;

namespace ASPDOTNETCoreBasics.Controllers
{
    public class EmployeeController : Controller
    {
        [Route("Employee/Index/{id}/{deptid}")]
        [Route("employee-details/{id}/{deptid}")]
        public IActionResult Index(int id,int deptid)
        {
            return View();
        }
    }
}
