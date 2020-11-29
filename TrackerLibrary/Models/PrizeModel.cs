using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The unqiue identifier for the prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The place number for this prize.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The name of this place number.
        /// </summary>
        /// <example>1st Place</example>
        public string PlaceName { get; set; }

        /// <summary>
        /// Value of the prize for this place.
        /// </summary>
        /// <remarks>Not required if PrizePercentage is present</remarks>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Percentage of the total prize for this place.
        /// </summary>
        /// <remarks>Not required if PrizeValue is present</remarks>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
