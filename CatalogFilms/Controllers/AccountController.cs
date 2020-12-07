using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CatalogFilms.Models;
using Microsoft.AspNetCore.Identity;

namespace CatalogFilms.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public IActionResult Index()
        {
            return View();
        }
    }
}
