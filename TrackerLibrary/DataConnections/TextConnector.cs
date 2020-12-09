using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.DataConnections.TextHelpers;
using System.Linq;

namespace TrackerLibrary.DataConnections
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PersonFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> players = PersonFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentId = 1;

            if (players.Count > 0)
            {
                currentId = players.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;
            players.Add(model);

            players.SaveToPersonFile(PersonFile);

            return model;
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            // load the txt file and convert text file to a list<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // find the id
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            // add the new record with the new PrizeID (max + 1)
            model.Id = currentId;
            prizes.Add(model);

            // convert the prizes to a list<string> and save the list<string> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            // Into ConvertToTeamsModel, pass TeamFile and PersonFile to return a List of TeamModels.  
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PersonFile);

            // find the id
            int currentId = 1;

            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }

            // add the new record with the new Id (max + 1)
            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamsFile(TeamFile);

            return model;
        }

        public List<PersonModel> GetPerson_All()
        {
            return PersonFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public List<TeamModel> GetTeam_All()
        {
            throw new NotImplementedException();
        }
    }
}
