using Licoreria_SLOWLIFE.BD;
using Licoreria_SLOWLIFE.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Licoreria_SLOWLIFE.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        public AppContext context = new AppContext();

        public ActionResult Index()
        {
            var admins = context.Admins;
            return View("Index", admins);
        }


        [HttpGet]
        public ActionResult Guardar()
        {
            return View("Guardar", new Admin());
        }


        [HttpPost]
        public ActionResult AdminGuardar(Admin Admin)
        {
            Admin.estado = true;
            context.Admins.Add(Admin);
            context.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }


        [HttpGet]
        public ActionResult Eliminar(int id)
        {

            Admin admin = context.Admins.Where(x => x.idAdmin == id).First();
            context.Admins.Remove(admin);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            var obj = context.Admins.Where(s => s.idAdmin == id).First();

            return View(obj);
        }

        [HttpPost]
        public ActionResult Editar(Admin a)
        {
            try
            {
                //Gets a value that indicates whether this instance received from the view is valid.
                if (ModelState.IsValid)
                {
                    // Two thing happens here:
                    // 1) db.Entry(student) -> Gets a DbEntityEntry object for the student entity providing access to information about it and the ability to perform actions on the entity.
                    // 2) Set the student state to modified, that means that the student entity is being tracked by the context and exists in the database, and some or all of its property values have been modified.
                    context.Entry(a).State = EntityState.Modified;

                    // Now just save the changes that all the changes made in the form will be persisted.
                    context.SaveChanges();

                    // Returns an HTTP 302 response to the browser, which causes the browser to make a GET request to the specified action, in this case the index action.
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                //Log the error add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }

            // return the invalid student instance to be corrected.
            return View(a);
        }

    }
}