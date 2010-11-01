using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudiesPlansModels.Models
{
    public partial class SPDatabase
    {
        private static SPDatabase db;
        public static SPDatabase DB
        {
            get
            {
                if (db == null)
                    db = new SPDatabase(ConnectionString);

                return db;
            }

            set
            {
                db = value;
            }
        }


        private static string ConnectionString
        {
            get
            {
                return Helpers.Connection.GetDatabaseConnectionString();
            }
        }
    }
}
