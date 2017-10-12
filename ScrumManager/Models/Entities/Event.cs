
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Models
{
    public class Event
    {
        //event componenets
        public int id { get; set; }
        public string eventName { get; set;}
        public string eventType { get; set; }
        public string eventLocation { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public List<Person> invitees { get; set; }
        public List<Person> attendees { get; set; }
        public string notes { get; set; }

        //constructor
        public Event()
        {
            this.invitees = new List<Person>();
            this.attendees = new List<Person>();
        }

    }
}
