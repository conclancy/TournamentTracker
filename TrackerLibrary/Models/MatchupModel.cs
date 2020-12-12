using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        public int Id { get; set; }

        /// <summary>
        /// List of MatchupEntryModels (i.e. teams) competing in this matchup.
        /// </summary>
        public List<MatchupEntryModel> matchupEntries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Team competing in this matchup.  
        /// </summary>
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}
