using Microsoft.AspNetCore.Mvc;
using PasteB.Data;
using PasteB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PasteB.Controllers
{
    public class PasteBinController : Controller
    {
        private readonly PasteBinDBContext _db;
        public PasteBinController(PasteBinDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<PasteBinModel> objList = _db.PasteBins;
            return View(objList);
        }
        
        //GET Create
        public IActionResult Create()
        {
            return View();
        }
        //POST Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PasteBinModel obj)
        {
            if (ModelState.IsValid)
            {

                _db.PasteBins.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        // GET Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.PasteBins.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.PasteBins.Find(id);
            if(obj == null)
            {
                return NotFound();
            }


            _db.PasteBins.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        // GET Update
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.PasteBins.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        //POST Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(PasteBinModel obj)
        {
            if (ModelState.IsValid)
            {

                _db.PasteBins.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
        // GET Display
        public IActionResult Display(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.PasteBins.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
    }
}
