using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TextConnection : IDataConnection
    {
        // TODO - Wire up the CreatePrize for text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
