using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Models.Entities
{
    public class Project
    {
        //project components
        public int ID { get; private set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
        public Project(int ID)
        {
            this.ID = ID;
        }
    }
}