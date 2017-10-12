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
                ev.id = lastEvent.id + 1;
            }
            else
            {
                ev.id = 1;
            }
            _events.Add(ev);
            return ev;
        }

        public void Delete(int id)
        {
            var ev = _events.FirstOrDefault(r => r.id == id);
            if (ev != null)
            {
                _events.Remove(ev);
            }
        }

        public Event Read(int id)
        {
            return _events.FirstOrDefault(r => r.id == id);
        }

        public ICollection<Event> ReadAll()
        {
            return _events;
        }

        public void Update(int id, Event ev)
        {
            var oldEvent = _events.FirstOrDefault(r => r.id == id);
            if (oldEvent != null)
            {
                
                oldEvent.eventName = ev.eventName;
                oldEvent.eventType = ev.eventType;
                oldEvent.eventLocation = ev.eventLocation;
                oldEvent.startTime = ev.startTime;
                oldEvent.endTime = ev.endTime;
                oldEvent.eventType = ev.eventType;
                oldEvent.invitees = ev.invitees;
                oldEvent.attendees = ev.attendees;
                oldEvent.notes = ev.notes;

            }
        }
    }
}
