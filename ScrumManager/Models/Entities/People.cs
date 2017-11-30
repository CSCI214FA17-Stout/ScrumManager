using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Models
{
    public class People
    {
        [Key]
        public int ID { get; private set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        

        public People(int ID, string firstname, string lastname)
        {
            this.ID = ID;
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

     
    }
}
