using ScrumManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Services.Interfaces
{
    interface IEventRepository
    {
        Event Create(Event event);

        Event Read(int id);

        ICollection<Event> ReadAll();

        void Update(int id, Event person);

        void Delete(int id);
    }
}
