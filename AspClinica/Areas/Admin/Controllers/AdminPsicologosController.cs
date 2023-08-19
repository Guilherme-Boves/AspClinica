using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspClinica.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize("Admin")]
    public class AdminPsicologosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
