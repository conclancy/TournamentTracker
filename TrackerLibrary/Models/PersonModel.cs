using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Unique identifier for a person 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// First name of participant.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of participant. 
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Participant's email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Participant's cell phone number. 
        /// </summary>
        public string CellPhoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
