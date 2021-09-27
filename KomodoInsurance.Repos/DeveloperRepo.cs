using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.Repos
//library crud
//
//TOPICKS TO GET HELP ON
// the developer keeps turnign blue ans should be black

//ADD A DEVELOPER
{
    public class DeveloperRepo
    {
        private List<Developer> _listOfDevelopers = new List<Developer>();
        private List<Developer> _listOfDevelopers;

        public void AddDeveloper(Developer developer)
        {
            _listOfDevelopers.Add(developer);
        }
        public List<Developer> GetDeveloperList()
        {
            //had to press period to correct do not know whats goin on here 
            return listOfDevelopers;
        }

        //U
        //Update the dev team 
        public bool UpdateDeveloper(string originalDeveloper, Developer newDeveloper)
        {
            Developer oldDeveloper = GetDevloperByName(originalDeveloper);
            //!=null 
            if (originalDeveloper != null)
            {
                oldDeveloper.DevName = newDeveloper.DevName;
                oldDeveloper.DevID = newDeveloper.DevID;
                oldDeveloper.Exudus = newDeveloper.Exudus;

                return true;
            }
            else
            {
                return false;
            }
        }
        //delete

        public bool DeleteDeveloperByName(string devName)
        {
            Developer developer = GetDeveloperByName(devName);
            if (developer == null)
            {
                return false;

            }
            //looked up wwhat . count does 
            int initialDeveloper = _listOfDevelopers.Count;

            _listOfDevelopers.Remove(developer);

            if (_listOfDevelopers.Count < initialDeveloper)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteDeveloperByID(string devID)
        {
            Developer developer = GetDeveloperByID(devID);
            if (developer == null)

            {
                return false;
            }
            else
            {

            }
            int initialDeveloperID = _listOfDdevelopers.Count;
            _listOfDevelopers.Remove(developer);

            if (_listOfDevelopers.Count < initialDeveloperID)
            {
                return true;
            }
            else
            {
                return false;

            }

        }
        //This is going to be my helper method 
        public Developer GetDeveloperByName(string devName)
        {
            foreach (Developer developer in _listOfDevelopers)
            {
                if (developer.DevName.ToLower() == devName.ToLower())
                {
                    return developer;
                }
            }

            return null;
        }
        //Helper method number 2 !!woot
        public Developer GetDeveloperByID(string devID)
        {
            foreach (Developer.DevID.ToLower() == devID.ToLower())
            {
                return developer;
            }
        }
         return null;

    }
}


