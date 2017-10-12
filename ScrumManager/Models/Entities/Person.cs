using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace ScrumManager
{
    public class Person
    {
        private int personID;       //indicates the person via unique number
        private string fName;          //person's first name
        private string lName;          //person's last name
        private string strengths;      //string containing a person's coding strengths
        private string description;    //string containing a description
        private string title;          //string indicating if person is scrum master or scrum member
        private string team;           //string indicating the team the person is in

        #region constructors
        /// <summary>
        /// default constructor that sets all fields to invalid or empty
        /// </summary>
        Person()
        {
            SetID(-1);
            SetfName("");
            SetlName("");
            SetStrengths("");
            SetDescription("");
            SetTitle("");
            SetTeam("");
        }

        /// <summary>
        /// partially parametrized constructor in case team or strengths or description have yet to be determined
        /// </summary>
        Person(int ID, string fName, string lName, string title)
        {
            SetID(ID);
            SetfName(fName);
            SetlName(lName);
            SetStrengths("");
            SetDescription("");
            SetTitle(title);
            SetTeam("");
        }

        /// <summary>
        /// fully parametrized constructor
        /// </summary>
        Person(int ID, string fName, string lName, string strengths, string description, string title, string team)
        {
            SetID(ID);
            SetfName(fName);
            SetlName(lName);
            SetStrengths(strengths);
            SetDescription(description);
            SetTitle(title);
            SetTeam(team);
        }
        #endregion //end constructor region

        #region Setters
        /// <summary>
        /// sets the person's id to specified id so long as it is greater than or equal to 0; sets to -1 if invalid
        /// </summary>
        /// <param name="ID"></param>
        private void SetID(int ID)
        {
            if (ID >= 0)
                personID = ID;
            else
                personID = -1;
        }
        private void SetfName(string name)
        {
            fName = name;
        }
        private void SetlName(string name)
        {
            lName = name;
        }
        private void SetStrengths(string personsStrengths)
        {
            strengths = personsStrengths;
        }
        private void SetDescription(string personDescription)
        {
            description = personDescription;
        }
        private void SetTitle(string title)
        {
            string upperTitle = title.ToUpper();
            title = "";
            if (upperTitle.Equals("SCRUM MASTER") || upperTitle.Equals("MASTER"))
                title = "Master";
            if (upperTitle.Equals("SCRUM MEMBER") || upperTitle.Equals("MEMBER"))
                title = "Member";
        }
        private void SetTeam(string teamid)
        {
            team = teamid;
        }
        #endregion //end setter region

        #region Getters
        public int GetPersonID()
        {
            int ID = personID;
            return ID;
        }
        public string GetFName()
        {
            string firstName = fName;
            return firstName;
        }
        public string GetLName()
        {
            string lastName = lName;
            return lastName;
        }
        public string GetStrengths()
        {
            string personStrengths = strengths;
            return personStrengths;
        }
        public string GetDescription()
        {
            string personDescription = description;
            return personDescription;
        }
        public string GetTitle()
        {
            string personTitle = title;
            return personTitle;
        }
        public string GetTeam()
        {
            string personTeam = team;
            return personTeam;
        }
        #endregion //end getter region
    }//end Person
}//end namespace