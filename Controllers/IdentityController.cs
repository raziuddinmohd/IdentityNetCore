using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using IdentityNetCore.Models;

namespace IdentityNetCore.Controllers
{
    public class IdentityController : Controller
    {
        // GET: /Identity/Signup
        [HttpGet]
        public IActionResult Signup()
        {
            var model = new SignupViewModel();
            return View(model);
        }

        // POST: /Identity/Signup
        [HttpPost]
        public async Task<IActionResult> Signup(SignupViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Placeholder - in your app you'd use UserManager to create the user.
            // For now just redirect to Signin on success.
            return RedirectToAction("Signin");
        }

        // GET: /Identity/Signin
        [HttpGet]
        public IActionResult Signin()
        {
            return View();
        }

        // GET: /Identity/AccessDenied
        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
