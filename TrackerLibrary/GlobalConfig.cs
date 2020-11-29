using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.DataConnections;
using System.Configuration;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; } 

        public static void InitializeConnections (DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                // TODO - Set up the SqlConnector after the object is finalized. 
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                // TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string ConnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
