﻿using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public interface IDataConnection
    {
        // Create a new PrizeModel without an ID.  When the PrizeModel is returned, it will have an ID. 
        PrizeModel CreatePrize(PrizeModel model);
    }
}
