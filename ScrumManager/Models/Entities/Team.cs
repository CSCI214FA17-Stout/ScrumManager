using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Models.Entities
{
    public class Team
    {
        //team components
        public int ID { get; private set; }
        public string Name { get; set; }
        public Person ScrumMaster { get; set; }
        public List<Person> Members { get; set; }

        public Team(int ID, Person ScrumMaster)
        {
            this.ID = ID;
            this.ScrumMaster = ScrumMaster;
        }

        public Team(int ID, Person ScrumMaster, string Name)
        {
            this.ID = ID;
            this.ScrumMaster = ScrumMaster;
            this.Name = Name;
        }

        public void AddMember(Person p)
        {
            Members.Add(p);
        }

        /// <summary>
        /// Removes a member.
        /// </summary>
        /// <returns>False if the member was not found. True otherwise.</returns>
        public bool RemoveMember(Person p)
        {
            return Members.Remove(p);
        }
    }
}