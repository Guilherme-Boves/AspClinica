using Microsoft.AspNetCore.Identity;

namespace AspClinica.Services
{
    public class SeedUserRoleInitial : ISeedUserRoleInitial
    {
        public readonly UserManager<IdentityUser> _userManager;
        public readonly RoleManager<IdentityRole> _roleManager;

        public SeedUserRoleInitial(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void SeedRoles()
        {
            if (!_roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                role.NormalizedName = "ADMIN";
                IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
            }            
            if (!_roleManager.RoleExistsAsync("Psicologo").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Psicologo";
                role.NormalizedName = "PSICOLOGO";
                IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
            }
            if (!_roleManager.RoleExistsAsync("Paciente").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Paciente";
                role.NormalizedName = "PACIENTE";
                IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
            }
        }

        public void SeedUsers()
        {
            if (_userManager.FindByEmailAsync("admin@localhost").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "admin@localhost";
                user.Email = "admin@localhost";
                user.NormalizedUserName = "ADMIN@LOCALHOST";
                user.NormalizedEmail = "ADMIN@LOCALHOST";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;
                user.SecurityStamp = Guid.NewGuid().ToString();

                IdentityResult result = _userManager.CreateAsync(user, "Teste123@").Result;

                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
            if (_userManager.FindByEmailAsync("paciente@localhost").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "paciente@localhost";
                user.Email = "paciente@localhost";
                user.NormalizedUserName = "PACIENTE@LOCALHOST";
                user.NormalizedEmail = "PACIENTE@LOCALHOST";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;
                user.SecurityStamp = Guid.NewGuid().ToString();

                IdentityResult result = _userManager.CreateAsync(user, "Teste123@").Result;

                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "Paciente").Wait();
                }
            }
            if (_userManager.FindByEmailAsync("psicologo@localhost").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "psicologo@localhost";
                user.Email = "psicologo@localhost";
                user.NormalizedUserName = "PSICOLOGO@LOCALHOST";
                user.NormalizedEmail = "PSICOLOGO@LOCALHOST";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;
                user.SecurityStamp = Guid.NewGuid().ToString();

                IdentityResult result = _userManager.CreateAsync(user, "Teste123@").Result;

                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "Psicologo").Wait();
                }
            }
            
        }
    }
}
