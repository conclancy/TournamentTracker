using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// The required fee for participation.
        /// </summary>
        /// <remarks>Enter 0 if there is no Entry Fee</remarks>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// List of teams participating in this tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// List of prizes for this tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Team matchups for each round of this tournament.  
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
