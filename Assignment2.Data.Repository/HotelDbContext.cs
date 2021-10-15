using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Assignment2.Data.Repository
{
    class HotelDbContext
    {
        public IDbConnection GetConnection()
        {
            string con = new ConfigurationBuilder().AddJsonFile("appSettings.json").Build().GetConnectionString("HotelDb");
            return new SqlConnection(con); //Change if you are using another RDBMS
        }
    }
}
