using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace StudiesPlansModels.Helpers
{
    public partial class Connection
    {
        public static string GetDatabaseConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["SPDatabase"].ConnectionString;
        }
    }
}
