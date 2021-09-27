using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KomodoInsurance02
{
    public class DevTeamPOCO
    {

    }
    //Exudus
    //get set allow me to get info and set new values "user"
    public class DeveloperTeam
    {
        internal object TeamMembers;

        public string TeamName { get; set; }

        public List<Developer> TeamMember { get; set; }

        public int TeamID { get; set; }
        public DeveloperTeam()
        {

        }
        public DeveloperTeam(string teamName, List<Developer> teamMember, int teamID)
        {
            TeamName = teamName;
            TeamMember = teamMember;
            TeamID = teamID;
        }

    }
}
