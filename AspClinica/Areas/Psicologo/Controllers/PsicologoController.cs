using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspClinica.Areas.Psicologo.Controllers
{
    [Area("Psicologo")]
    [Authorize("Psicologo")]    
    public class PsicologoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
