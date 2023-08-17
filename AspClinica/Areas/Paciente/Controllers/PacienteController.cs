using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspClinica.Areas.Paciente.Controllers
{
    [Area("Paciente")]
    [Authorize("Paciente")]
    public class PacienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
