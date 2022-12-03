using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using tl2_tp4_2022_nico89h.Models;

namespace tl2_tp4_2022_nico89h.Controllers
{
    public class CadetesController : Controller
    {
        public static ICollection<Cadetes> _cadetes= new List<Cadetes>();
        // GET: CadetesController
        public ActionResult Index()
        {
            //en el index se mostrara la info de los 
            return View(_cadetes.ToList());
        }

        // GET: CadetesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CadetesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadetesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string Nombre)
        {
            try
            {
                Cadetes cadete = new Cadetes(Nombre);
                //Cadetes cadetes = new Cadetes(Nombre);
                if (_cadetes==null)
                {
                    _cadetes.Add(cadete);
                }
                else
                {
                    _cadetes.Add(cadete);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CadetesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
        // POST: CadetesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CadetesController/Delete/5
        public ActionResult Delete(int id)
        {
            
            foreach (var item in _cadetes)
            {
                if (item.Id1==id)
                {
                    return View(item);
                }
            }
            return RedirectToAction(nameof(Index));

        }

        // POST: CadetesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,IFormCollection collection)
        {
            
            try
            {
                foreach (var item in _cadetes)
                {
                    if (item.Id1 == id)
                    {
                        _cadetes.Remove(item);
                        return RedirectToAction(nameof(Index));
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
