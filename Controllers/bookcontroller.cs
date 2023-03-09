using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bookshop.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace bookshop.Controllers
{
      
    public class bookhritikController:Controller
    {

        private readonly Ace42023Context db;
        public bookhritikController(Ace42023Context _db)
        {
            db = _db;
        }

        
        public ActionResult GetBooks()
        {
            ViewBag.Username = HttpContext.Session.GetString("username");
            if(ViewBag.Username!=null)
            {
                return View(db.Bookhritiks);
            }
            else
            {
                return RedirectToAction("Login","Login"); // will not show page if not logged in
            }
        }
        public IActionResult Create()
        {
            var result  = db.Authorhritiks.ToList();
            ViewBag.Authorhritiks = new SelectList(result,"Aid","Aname");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Bookhritik p)
        {
            db.Bookhritiks.Add(p);
            db.SaveChanges();
            return RedirectToAction("GetBooks");
        }


        public ActionResult SearchBooks(IFormCollection f)
        {
            string keyword = f["keyword"].ToString();
            var result = db.Bookhritiks.Where(x=>x.Title.Contains(keyword)).Select(x=>x).ToList();
            return View(result);
        }
        
        public IActionResult Details(int id)
        {
            Bookhritik? p = db.Bookhritiks.Find(id);
            return View(p);
        }

        [Route("Update")]
        public ActionResult Edit(int id)
        {
            Bookhritik? p = db.Bookhritiks.Find(id);
            return View(p);
        }
        [HttpPost]
        [Route("Update")]
        public ActionResult Edit(Bookhritik p)
        {
            db.Bookhritiks.Update(p);
            db.SaveChanges();
            return RedirectToAction("GetBooks");
        }
        public ActionResult Delete(int id)
        {
            Bookhritik? p = db.Bookhritiks.Find(id);
            return View(p);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Bookhritik? p=db.Bookhritiks.Find(id);
            db.Bookhritiks.Remove(p);
            db.SaveChanges();
            return RedirectToAction("GetBooks");
        }
        public ActionResult GetAuthor()
        {
            var result = (from i in db.Bookhritiks.Include(x=>x.Author)select i).ToHashSet();
            return View(result);
        }
    }
    
}
