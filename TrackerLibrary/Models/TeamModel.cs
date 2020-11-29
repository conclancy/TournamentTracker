using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// List of Persons on the team.  
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// The name of the team. 
        /// </summary>
        public string TeamName { get; set; }
    }
}
