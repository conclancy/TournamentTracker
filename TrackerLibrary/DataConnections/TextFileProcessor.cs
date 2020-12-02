using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using System.Linq;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataConnections.TextHelpers
{
    public static class TextFileProcessor
    {
        /// <summary>
        /// Generates the full file path given a file name.
        /// </summary>
        /// <param name="fileName">The name of the file</param>
        /// <example>PrizeModel.csv</example>
        public static string FullFilePath(this string fileName)
        {
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<String>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string l in lines)
            {
                string[] cols = l.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);

                output.Add(p);
            }

            return output;
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string l in lines)
            {
                string[] cols = l.Split(',');

                PersonModel p = new PersonModel
                {
                    Id = int.Parse(cols[0]),
                    FirstName = cols[1],
                    LastName = cols[2],
                    EmailAddress = cols[3],
                    CellPhoneNumber = cols[4]
                };

                output.Add(p);
            }

            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string PersonFile)
        {
            // initialize output variable
            List<TeamModel> output = new List<TeamModel>();

            // Create a list of PersonModels containing all person models.  
            List<PersonModel> players = PersonFile.FullFilePath().LoadFile().ConvertToPersonModels();

            // For each line in the csv, create a new team model.
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel t = new TeamModel
                {
                    Id = int.Parse(cols[0]),
                    TeamName = cols[1]
                };

                // split the third column by "pipe" 
                string[] personIds = cols[2].Split('|');

                // For each Id from the line above, parse the list of all players to find the correct player. 
                // Add the player to the team. 
                foreach (string id in personIds)
                {
                    t.TeamMembers.Add(players.Where(x => x.Id == int.Parse(id)).First());
                }

                output.Add(t);
            }

            return output;
        }

        public static void SaveToPrizeFile (this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach(PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToPersonFile (this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellPhoneNumber}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToTeamsFile (this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{ t.Id },{ t.TeamName },{ ConvertPeopleListToString(t.TeamMembers)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        /// <summary>
        /// Converts a list of people into a "pipe" seperated list of their IDs.
        /// </summary>
        /// <param name="people">PersonModel</param>
        /// <returns>String of pipe-seperated people IDs</returns>
        /// <example>Person.ID = 4, Person.ID = 6, person.ID = 10 --> "4|6|10"</example>
        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            // Initialize output string
            string output = "";

            // Fallback incase no data is passed to method.
            if (people.Count == 0)
            {
                return "";
            }

            // For each person append the Id and a pipe character
            foreach (PersonModel p in people)
            {
                output += $"{p.Id}|";
            }

            //trim the trailing "pipe" character
            output = output.Substring(0, output.Length - 1);

            return output;
        }
    }
}
