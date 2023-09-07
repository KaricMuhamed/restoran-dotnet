using ProjekatRestoran.Models;
using ProjekatRestoran.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Collections;
using ProjekatRestoran.Models;
using System.Collections.Generic;
using ProjekatRestoran.Data;

namespace prviProjekat_2_.Controllers
{
    public class JelaController : Controller
    {

        private readonly ApplicationDbContext _db;

        public JelaController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Meni> objList = _db.Jela;

            return View(objList);
        }
        public IActionResult Brisanje()
        {
            IEnumerable<Meni> objList = _db.Jela;

            return View(objList);
        }


        //GET-Create
        public IActionResult Create()
        {
            return View();
        }
        

        //POST-Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Meni obj)
        {
            _db.Jela.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET Delete
        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Jela.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        // POST Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? Id)
        {
            var obj = _db.Jela.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Jela.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        // GET Updat
        public IActionResult Update(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Jela.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        //POST-Update

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Meni obj)
        {
            if (ModelState.IsValid)
            {
                _db.Jela.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
    }
}
