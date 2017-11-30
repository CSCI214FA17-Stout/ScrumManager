using ScrumManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Services.DbRepository
{
    public class InMemoryEventData
    {
        private static ICollection<Event> _events = new List<Event>();

        public Event Create(Event ev)
        {
            var lastEvent = _events.LastOrDefault();
            if (lastEvent != null)
            {
                ev.Id = lastEvent.Id + 1;
            }
            else
            {
                ev.Id = 1;
            }
            _events.Add(ev);
            return ev;
        }

        public void Delete(int id)
        {
            var ev = _events.FirstOrDefault(r => r.Id == id);
            if (ev != null)
            {
                _events.Remove(ev);
            }
        }

        public Event Read(int id)
        {
            return _events.FirstOrDefault(r => r.Id == id);
        }

        public ICollection<Event> ReadAll()
        {
            return _events;
        }

        public void Update(int id, Event ev)
        {
            var oldEvent = _events.FirstOrDefault(r => r.Id == id);
            if (oldEvent != null)
            {
                
                oldEvent.EventName = ev.EventName;
                oldEvent.EventType = ev.EventType;
                oldEvent.EventLocation = ev.EventLocation;
                oldEvent.StartTime = ev.StartTime;
                oldEvent.EndTime = ev.EndTime;
                oldEvent.EventType = ev.EventType;
                oldEvent.Invitees = ev.Invitees;
                oldEvent.Attendees = ev.Attendees;
                oldEvent.Notes = ev.Notes;

            }
        }
    }
}
