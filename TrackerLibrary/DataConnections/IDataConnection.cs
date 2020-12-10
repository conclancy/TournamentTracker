using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataConnections
{
    public interface IDataConnection
    {
        // Create a new PrizeModel without an ID.  When the PrizeModel is returned, it will have an ID. 
        PrizeModel CreatePrize(PrizeModel model);
        PersonModel CreatePerson(PersonModel model);
        TeamModel CreateTeam(TeamModel model);
        TournamentModel CreateTourmanet(TournamentModel model);
        List<TeamModel> GetTeam_All();
        List<PersonModel> GetPerson_All();
    }
}
