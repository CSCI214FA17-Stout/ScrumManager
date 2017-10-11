
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Models
{
    public class Event
    {
        //event componenets
        public string eventName {get; set;}
        public string eventType { get; set; }
        public string eventLocation { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public List<Person> invitees { get; set; }
        public List<Person> attendees { get; set; }
        public string Notes { get; set; }

        //constructor
        public Event(string eventName, string eventType, string eventLocation, DateTime startTime, DateTime endTime)
        {
            this.eventName = eventName;
            this.eventType = eventType;
            this.eventLocation = eventLocation;
            this.startTime = startTime;
            this.endTime = endTime;
            this.invitees = new List<Person>();
            this.attendees = new List<Person>();
            this.Notes = "";
        }

    }
}
