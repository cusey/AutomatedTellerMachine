using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        //GET: /Home/Index
        public ActionResult Index()
        {
            return View();
        }


        //GET: /Home/About
        public ActionResult About()
        {
            ViewBag.Message = "The Countries which Summer Time Bank operates in.";

            ViewBag.Countries = new List<String>()
            {
                "India",
                "United States",
                "Canada",
                "Kenya"

            };

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.CustomerMessage = "Having trouble? Send us a message.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(string customerMessage)
        {

            SqlCommand cmd = new SqlCommand();

            ViewBag.CustomerMessage = "Thanks, we got your message !";

            string connectionString =
            "Data Source=DESKTOP-CV57V7N\\SQLEXPRESS;Initial Catalog=SummerTimeBank;"
            +"Integrated Security=True";

            cmd.CommandText = "INSERT INTO  dbo.comments (message) VALUES ('"+ customerMessage + "')";

            using (SqlConnection conn =
            new SqlConnection(connectionString))
            {
                conn.Open();
                cmd.Connection = conn;

                try
                {
                    
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        
          return View();
        }

        //GET: /Home/Serial/lower
        public ActionResult Serial(string letterCase)
        {
            var serial = "STB 18.01.30.05";

            if( letterCase == "lower")
            {
                return Content(serial.ToLower());
            }

            return Content(serial);
        }
    }
}