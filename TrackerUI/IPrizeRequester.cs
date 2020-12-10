using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerUI
{
    // Allows other objects to call the Prize Form
    // Prize form requires this an object implementing this interface as an input to the constructor
    // Once the prize model is created in the in PrizeForm, the prize model is passed back to the calling object's PrizeComplete method 
    // https://youtu.be/rS734DJL6zM 
    public interface IPrizeRequester
    {
        void PrizeComplete(PrizeModel model);
    }
}
