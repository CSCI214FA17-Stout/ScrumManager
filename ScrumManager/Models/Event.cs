
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Models
{
    public class Event
    {
        //event componenets
        string eventName;
        string eventType;
        string eventLocation;
        DateTime startTime;
        DateTime endTime;
        list<Person> invitees;
        list<Person> attendees;
        string Notes;

        //constructor
        Event(string eventName, string eventType, string eventLocation, DateTime startTime, DateTime endTime)
        {
            this.eventName = eventName;
            this.eventType = eventType;
            this.eventLocation = eventLocation;
            this.startTime = startTime;
            this.endTime = endTime;
            this.invitees = new list<Person>();
            this.attendees = new list<Person>();
            this.Notes = "";
        }

    }
}
