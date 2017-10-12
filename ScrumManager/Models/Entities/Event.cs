
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Models
{
    public class Event
    {
        //event componenets
        public int ID { get; set; }
        public string EventName { get; set;}
        public string EventType { get; set; }
        public string EventLocation { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<Person> Invitees { get; set; }
        public List<Person> Attendees { get; set; }
        public string Notes { get; set; }

        //constructor
        public Event()
        {
            this.Invitees = new List<Person>();
            this.Attendees = new List<Person>();
        }

    }
}
