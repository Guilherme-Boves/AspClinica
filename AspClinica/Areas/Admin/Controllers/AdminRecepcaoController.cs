using AspClinica.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspClinica.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize("Admin")]
    public class AdminRecepcaoController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AdminRecepcaoController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var roleName = "Recepcao";

            var usersInRoleRecepcao = new List<UserRoleViewModel>();

            var users = await _userManager.Users.ToListAsync();

            foreach (var user in users)
            {                
                if (await _userManager.IsInRoleAsync(user, roleName))
                {
                    var userRoleViewModel = new UserRoleViewModel
                    {
                        UserId = user.Id,
                        UserName = user.UserName,
                        Email = user.Email
                    };
                    usersInRoleRecepcao.Add(userRoleViewModel);
                }
            }
            return View(usersInRoleRecepcao);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
