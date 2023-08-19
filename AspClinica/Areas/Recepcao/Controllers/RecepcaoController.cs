using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspClinica.Areas.Recepcao.Controllers
{
    [Area("Recepcao")]
    [Authorize("Recepcao")]
    public class RecepcaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
