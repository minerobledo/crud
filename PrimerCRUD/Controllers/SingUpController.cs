using Microsoft.AspNetCore.Mvc;
using PrimerCRUD.Identity;


namespace PrimerCRUD.Controllers
{
    public class SingUpController : Controller
    {
        // GET: RegisterControler
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult SingUp(MyUsruario myUsruario)
        {

            return RedirectToPage("Home/index");
        }


        // GET: RegisterControler/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegisterControler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegisterControler/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: RegisterControler/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegisterControler/Edit/5
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

        // GET: RegisterControler/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegisterControler/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
