
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Models
{
    public class Event
    {
        //event componenets
        string eventName {get; set;}
        string eventType { get; set; }
        string eventLocation { get; set; }
        DateTime startTime { get; set; }
        DateTime endTime { get; set; }
        List<Person> invitees { get; set; }
        List<Person> attendees { get; set; }
        string Notes { get; set; }

        //constructor
        Event(string eventName, string eventType, string eventLocation, DateTime startTime, DateTime endTime)
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
