using ScrumManager.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScrumManager.Models;

namespace ScrumManager.Services
{
    public class DbEventRepository : IEventRepository
    {
        
        //unused class for now since we dont have a database

        public Event Create(Event ev)
        {
            throw new NotImplementedException();
        }

        public Event Read(int id)
        {
            throw new NotImplementedException();
        }

        public List<Event> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Event ev)
        {
            throw new NotImplementedException();
        }
    }
}
