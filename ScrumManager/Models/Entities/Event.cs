using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Models
{
    public class Event
    {
        //event componenets
        [Key]
        public int Id { get; set; }

        public string EventName { get; set;}
        public string EventType { get; set; }
        public string EventLocation { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<People> Invitees { get; set; }
        public List<People> Attendees { get; set; }
        public string Notes { get; set; }

        //default constructor
        public Event()
        {
            
            this.Invitees = new List<People>();
            this.Attendees = new List<People>();
            this.Notes = "";
        }

        
    }
}