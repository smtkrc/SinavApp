using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SinavProje.Models;
using System.Web;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace SinavProje.Controllers
{
    public class Admin : Controller
    {
        Context c = new Context();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(User u)
        {
            var deger = c.Users.FirstOrDefault(x => x.UserName == u.UserName && x.Password == u.Password);
            if (deger!=null)
            {
                var talep = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,u.UserName)
                };
                var useridentity = new ClaimsIdentity(talep, "Login");ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Sinav");
            }
            return View();
        }
 
    }
}
