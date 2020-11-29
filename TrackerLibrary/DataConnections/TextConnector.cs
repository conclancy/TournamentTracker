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
    }
}
