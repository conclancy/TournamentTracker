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
        List<PersonModel> GetPerson_All();
    }
}
