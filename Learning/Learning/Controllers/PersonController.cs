using Learning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learning.Controllers
{
    public class PersonController : Controller
    {
        static List<Person> People = new List<Person>
        {
            new Person { Id=1, FirstName="Rick" , LastName="Hodder"}
        };

        // GET: Person
        public ActionResult Index()
        {
            return View(People);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            var p = People.First(person => person.Id== id);
            return View(p);
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            var p = People.First(person => person.Id == id);
            return View(p);
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Person model)
        {
            try
            {
                // TODO: Add update logic here
                var p = People.First(person => person.Id == id);
                People.Remove(p);
                People.Add(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
