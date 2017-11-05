using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Models
{
    public class Person
    {
        public int ID { get; private set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        public List<Task> Tasks { get; set; }

        public Person(int ID, string firstname, string lastname)
        {
            this.ID = ID;
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public void AddTask(Task t)
        {
            Tasks.Add(t);
        }

        /// <summary>
        /// Removes a task.
        /// </summary>
        /// <returns>False if the task was not found. True otherwise.</returns>
        public bool RemoveTask(Task t)
        {
            return Tasks.Remove(t);
        }
    }
}
