using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KomodoInsurance.Repos
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

        public string TeamID { get; set; }
        public DeveloperTeam()
        {

        }
        public DeveloperTeam(string teamName, List<Developer> teamMember, string teamID)
        {
            this.TeamName = teamName;
            this.TeamMember = teamMember;
            this.TeamID = teamID;
        }

    }
}
