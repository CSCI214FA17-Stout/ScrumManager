using ScrumManager.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScrumManager.Models;
using ScrumManager.Models.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace ScrumManager.Services
{
    public class DbEventRepository : IEventRepository
    {
        private ScrumManagerDbContext _db;                   //private database connection
        public DbEventRepository(ScrumManagerDbContext db)  //inject the database connection
        {
            _db = db;
        }//injection
        //unused class for now since we dont have a database

        public Event Create(Event ev)
        {
            _db.Events.Add(ev);                         //Add the Event to the database's set of events
            _db.SaveChanges();                              //Commit changes
            return ev;
        }

        public Event Read(int id)
        {
            return _db.Events.FirstOrDefault(p => p.Id == id);
        }

        public List<Event> ReadAll()
        {
            return _db.Events.ToList();
        }

        public void Update(int id, Event ev)
        {
            _db.Entry(ev).State = EntityState.Modified;     //Set state to modified
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var Event = _db.Events.Find(id);               //Get the person to remove
            _db.Events.Remove(Event);                      //and then remove them from the set of people
            _db.SaveChanges();                              //Commit the change
        }//delete

    }
}
