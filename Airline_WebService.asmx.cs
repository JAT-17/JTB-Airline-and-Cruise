using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace JTB_Airline_and_Cruise
{
    /// <summary>
    /// Summary description for Airline_WebService
    /// </summary>
    [WebService(Namespace = "http://JTBAirLineandCruise.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Airline_WebService : System.Web.Services.WebService
    {


         

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        [WebMethod]
        public int Add(int a , int b)
        {                   
            return a+b;
        }
    }
}
