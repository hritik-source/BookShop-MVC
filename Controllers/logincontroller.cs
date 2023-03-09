using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bookshop.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace bookshop.Controllers
{

    public class logincontroller:Controller
    {

         private readonly ISession session;
        private readonly Ace42023Context db;
        public logincontroller(Ace42023Context _db, IHttpContextAccessor httpContextAccessor)
        {
            db = _db;
            session = httpContextAccessor.HttpContext.Session;
        }

        

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Bookuserhritik u)
        {
            // LINQ - language integrated Query
            var result = (from i in db.Bookuserhritiks 
                        where i.Uname == u.Uname && i.Password == u.Password select i).SingleOrDefault();
                if(result != null )
                {
                    HttpContext.Session.SetString("username", result.Uname);
                    return RedirectToAction("GetBooks","Bookhritik");
                }
                else 
                {
                    return View();
                }
        }

        public ActionResult Register()
        {
            return View();   
        }
        [HttpPost]
        public IActionResult Register(Bookuserhritik p)
        {
            db.Bookuserhritiks.Add(p);
            db.SaveChanges();
            return RedirectToAction("Login");
        }
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}


