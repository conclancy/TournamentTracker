using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents this team's score.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup that this team came
        /// from as the winner.  
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
