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
            SqlCommand cmd = new SqlCommand("select emp_id , e_password ,mng_id ,Designation from employee where emp_id = @emp_id and e_password=@e_password ", con);
            cmd.Parameters.AddWithValue("@emp_id", e.empid);
          
            cmd.Parameters.AddWithValue("@e_password", e.Password);
            SqlDataReader sdr = cmd.ExecuteReader();
            //SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
           // sdr.Fill(dt);


            if (sdr.Read())
            {
                Session["username"] = e.empid.ToString();
              
                if(sdr["Designation"].Equals("se"))
                {
                    return RedirectToAction("welcome");
                }
                else if (sdr["Designation"].Equals("manager"))
                {
                    return RedirectToAction("manager");
                }

                
                

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
        [HttpGet]
        public ActionResult Admin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Admin(Login l)
        {

            SqlConnection con1 = new SqlConnection("Data Source=MEDL011027364\\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True");
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("select username , passwaord from AdminLogin where username = @username and passwaord=@passwaord ", con1);
            cmd1.Parameters.AddWithValue("@username", l.username);

            cmd1.Parameters.AddWithValue("@passwaord", l.Password);
            SqlDataReader sdr1 = cmd1.ExecuteReader();


            if (sdr1.Read())
            {
                Session["username"] = l.username.ToString();

                return RedirectToAction("page");

            }

            else
            {
                ViewData["message"] = "user login details failed";
            }


            con1.Close();

            return View();
        }

        public ActionResult page()
        {
            return View();
        }
        public ActionResult manager()
        {
            return View();
        }
        public ActionResult LeaveRequest()
        {
            return View();
        }
        public ActionResult AttendenceView()
        {
            return View();
        }
        public ActionResult AddEmployee()
        {
            return View();
        }
        public ActionResult UpdateEmployee()
        {
            return View();
        }
        public ActionResult DeleteEmployee()
        {
            return View();
        }

        public ActionResult AddProject()
        {
            return View();
        }
        public ActionResult UpdateProject()
        {
            return View();
        }
        public ActionResult DeleteProject()
        {
            return View();
        }
        public ActionResult Attendence()
        {
            return View();
        }
        public ActionResult ManagerLeave()
        {
            return View();
        }
        public ActionResult ManagerAttendence()
        {
            return View();
        }
        public ActionResult ManagarLeave()
        {
            return View();
        }
        public ActionResult ManagerSummary()
        {
            return View();
        }


    }
}