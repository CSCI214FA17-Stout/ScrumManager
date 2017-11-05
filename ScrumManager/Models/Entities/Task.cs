using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Models.Entities
{
    public class Task
    {
        //task components
        public int ID { get; private set; }
        public DateTime CompletedDate { get; set; }
        public int StoryPoints { get; set; }
        
        public Task(int ID)
        {
            this.ID = ID;
        }
    }
}