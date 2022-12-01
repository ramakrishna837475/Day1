using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using AMS_PRJ.Models;

namespace AMS_PRJ.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
       

        public ActionResult About()
        {
            

            return View();
        }

        public ActionResult Contact()
        {
           
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(employe e)
        {

            SqlConnection con = new SqlConnection("Data Source=MEDL011027364\\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select emp_id , e_password ,designation from employee where emp_id = @emp_id and e_password=@e_password", con);
            cmd.Parameters.AddWithValue("@emp_id", e.empid);
            cmd.Parameters.AddWithValue("@e_password", e.Password);
            SqlDataReader sdr = cmd.ExecuteReader();


            if (sdr.Read())
            {
                Session["username"] = e.empid.ToString();
                return RedirectToAction("welcome");

            }
            else
            {
                ViewData["message"] = "user login details failed";
            }


            con.Close();

            return View();
        }
        public ActionResult welcome()
        {
            return View();
        }
        public ActionResult CheckIn()
        {
            return View();
        }
        public ActionResult Leave()
        {
            return View();
        }
        public ActionResult summary()
        {
            return View();
        }


    }
}