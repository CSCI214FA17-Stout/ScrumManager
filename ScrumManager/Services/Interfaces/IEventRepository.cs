using ScrumManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Services.Interfaces
{
    public interface IEventRepository
    {
        List<Event> ReadAll();

        Event Create(Event event);

    }
}
