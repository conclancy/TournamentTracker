using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataConnections
{
    public class TextConnector : IDataConnection
    {
        // TODO - Wire up the CreatePrize for text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
