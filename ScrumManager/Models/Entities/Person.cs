using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Models
{
    public class Person
    {
        private string FirstName;
        private string LastName;

        public Person(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        public string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
