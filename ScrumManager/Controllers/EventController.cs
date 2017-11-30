using Microsoft.AspNetCore.Mvc;
using ScrumManager.Models;
using ScrumManager.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Controllers
{
    public class EventController : Controller
    {



        //Not yet implemented



        private IEventRepository _events;

        public EventController(IEventRepository ev)
        {
            _events = ev;
        }

        public IActionResult Index()
        {
            return View(_events.ReadAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Event ev)
        {
            if (ModelState.IsValid)
            {
                _events.Create(ev);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            var ev = _events.Read(id);
            if (ev == null)
            {
                return RedirectToAction("Index");
            }
            return View(ev);
        }

        [HttpPost]
        public IActionResult Edit(Event ev)
        {
            if (ModelState.IsValid)
            {
                _events.Update(ev.Id, ev);
                return RedirectToAction("Index");
            }
            return View(ev);
        }

        public IActionResult Details(int id)
        {
            var recommendation = _events.Read(id);
            if (recommendation == null)
            {
                return RedirectToAction("Index");
            }
            return View(recommendation);
        }

        public IActionResult Delete(int id)
        {
            var Person = _events.Read(id);                  //get person to remove corresponding to given id
            if (Person == null)                              //if person isn't found
            {
                return RedirectToAction("Index");           //return to Index view
            }//if
            return View(Person);                            //else go to Post view
        }//get delete

        [HttpPost, ValidateAntiForgeryToken, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _events.Delete(id);                             //delete the person corresponding to the given ID
            return RedirectToAction("Index");


        }
    }
}