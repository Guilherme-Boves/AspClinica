﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspClinica.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize("Admin")]
    public class AdminRecepcionistasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
