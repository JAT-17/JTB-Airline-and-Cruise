using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace JTB_Airline_and_Cruise
{
    /// <summary>
    /// Summary description for Cruise_WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Cruise_WebService : System.Web.Services.WebService {


        [WebMethod]
        public DataSet GetCruiseDataFromDB(string CheckIn, string CheckOut)
        {
            DataSet ds = new DataSet();
            string dbconnection = ConfigurationManager.ConnectionStrings["JTBAirlineandCruiseDBConnection"].ConnectionString;
            using (SqlConnection sqlconn = new SqlConnection(dbconnection))
            {

                SqlCommand cmd = new SqlCommand("getCruise", sqlconn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter1 = new SqlParameter();
                parameter1.ParameterName = "@CheckIn";
                parameter1.Value = CheckIn;

                SqlParameter parameter2 = new SqlParameter();
                parameter2.ParameterName = "@Checkout";
                parameter2.Value = CheckOut;

                cmd.Parameters.Add(parameter1);
                cmd.Parameters.Add(parameter2);

                if (sqlconn.State != ConnectionState.Open)
                {
                    sqlconn.Open();
                }
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cmd;
                adp.Fill(ds);
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }

            }

            return ds;
        }

    }
}
