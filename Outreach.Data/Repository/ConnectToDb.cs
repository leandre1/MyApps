using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Outreach.Data.Repository
{
    public class ConnectToDb
    {
        public IDbConnection db { get; set; }
        public ConnectToDb()
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["DBC"].ConnectionString);
        }
       
            
    }
}