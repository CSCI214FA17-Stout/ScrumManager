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



        private IEventRepository _Events;

        public EventController(IEventRepository ev)
        {
            _Events = ev;
        }

        public IActionResult Index()
        {
            return View(_Events.ReadAll());
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
                _Events.Create(ev);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            var ev = _Events.Read(id);
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
                _Events.Update(ev.id, ev);
                return RedirectToAction("Index");
            }
            return View(ev);
        }

        public IActionResult Details(int id)
        {
            var recommendation = _Events.Read(id);
            if (recommendation == null)
            {
                return RedirectToAction("Index");
            }
            return View(recommendation);
        }

        public IActionResult Delete(int id)
        {
            var ev = _Events.Read(id);
            if (ev == null)
            {
                return RedirectToAction("Index");
            }
            return View(ev);
        }
/*
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _Events.Delete(id);
            return RedirectToAction("Index");
        }*/
    }
}
