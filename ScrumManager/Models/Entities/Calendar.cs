using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Models
{
    public class Calendar
    {
        private List<Event> Events { get; set; }

        public Calendar()
        {
            Events = new List<Event>();
        }

        public void AddEvent(Event itemToAdd)
        {
            Events.Add(itemToAdd);
        }

        public void RemoveEvent(int eventID)
        {
            for (int i = 0; i < Events.Count; i++)
                if (Events[i].Id == eventID)
                    Events.RemoveAt(i);
        }

        public void SortEvents()
        {
            Events.Sort((x, y) => DateTime.Compare(x.StartTime, y.StartTime));
        }

        public string DisplayEvents(People user)
        {
            string display = "";
            display += user.ToString() + "'s Calendar\n\n";
            display += "Start Time\t\tEnd Time\t\tEvent Name\t\tEvent Location\t\tEvent Type\tInvitees\n";
            for (int i=0; i < Events.Count; i++)
            {
                display += Events[i].StartTime + "\t";
                display += Events[i].EndTime + "\t";
                display += Events[i].EventName + "\t\t";
                display += Events[i].EventLocation + "\t";
                display += Events[i].EventType + "\t";
               // display += Events[i].Invitees[0].ToString() + "\t";
               // for(int j = 1; j < Events[i].Invitees.Count; j++)
               // {
               //     display += "\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + Events[i].Invitees[j].ToString();
               // }
               // display += "\n\n";
            }

            return display;
        }
    }
}