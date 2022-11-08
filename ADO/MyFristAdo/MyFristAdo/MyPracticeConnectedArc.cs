using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyFristAdo
{
    class MyPracticeConnectedArc
    {
        private static SqlConnection con;
        private static SqlCommand cmd;
        private static SqlDataReader dr;


        public static SqlConnection GetConnection()
        {
           con = new SqlConnection("data source = MEDL011027364\\SQLEXPRESS;database = MyData;" + 
               "Integrated Security =True ");


            con.Open();
            return con;

        }
        public static void SelectQuery()
        {
            con = GetConnection();
            cmd = new SqlCommand("select * from dep ",con);
            dr = cmd.ExecuteReader();



            while(dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
            }
        }

        public static void InsertEmployee()
        {
            con = GetConnection();
            //giving static hard coded values as below will result in errors on successive execution
            // cmd = new SqlCommand("insert into employee values(300,'ADO',16000,'Others',5,'999999')",con);

            Console.WriteLine("Please enter Empid,Name,Gender");
            int eid = Convert.ToInt32(Console.ReadLine());
            string ename = Console.ReadLine();
            string egender = Console.ReadLine();

            cmd = new SqlCommand("insert into dep values(@id,@name,@gender)", con);
            //command object has property known as parameters - a collection object
            //to the parameters collection, we have to add the parameters for insert
            cmd.Parameters.AddWithValue("@id", eid);
            cmd.Parameters.AddWithValue("@name", ename);
            cmd.Parameters.AddWithValue("@gender", egender);
            int records = cmd.ExecuteNonQuery();
            if (records > 0)
            {
                Console.WriteLine("Inserted successfully..");
            }
            else
                Console.WriteLine("Something went wrong..");
        }

        public static void DeleteEmployee()
        {
            con = GetConnection();
            Console.WriteLine("Enter the employee code to delete:");
            int ecode = Convert.ToInt32(Console.ReadLine());
            

            SqlCommand cmd1 = new SqlCommand("Select * from dep where id=@id", con);
            cmd1.Parameters.AddWithValue("@id", ecode);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                for (int i = 0; i < dr1.FieldCount; i++)
                {
                    Console.WriteLine(dr1[i]);
                }
            }
            con.Close();
            Console.WriteLine("Are you Sure to delete this Employee? Y/N :");
            string status = Console.ReadLine();
            if (status == "y" || status == "Y")
            {
                cmd = new SqlCommand("delete from dep where id=@id", con);
                cmd.Parameters.AddWithValue("@id", ecode);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Record Deleted Successfully...");
                }
                else
                    Console.WriteLine("Contact DBA..");
            }
            else
            {
                Console.WriteLine("You Opted not to delete the Employee");
            }
        }

        public static void UpdateEmploye()
        {
            con = GetConnection();
            Console.WriteLine("Enter the employee code to update:");

            int id1 = Convert.ToInt32(Console.ReadLine());
            string nam = Console.ReadLine();
            string gen = Console.ReadLine();
            SqlCommand cmd1 = new SqlCommand("Select * from dep where id=@id", con);
            cmd1.Parameters.AddWithValue("@id", id1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                for (int i = 0; i < dr1.FieldCount; i++)
                {
                    Console.WriteLine(dr1[i]);
                }
            }
            con.Close();

            SqlCommand cmd = new SqlCommand("update dep set name= @name, gender = @gender where id=@id");

            cmd.Parameters.Add(new SqlParameter("@name", nam));
            cmd.Parameters.Add(new SqlParameter("@gender", gen));

            cmd.Parameters.Add(new SqlParameter("@id", id1));

            //con.Open();
            int res1 = cmd.ExecuteNonQuery();

            if (res1 > 0)
            {
                Console.WriteLine("Record updated Successfully...");
            }
            else
                Console.WriteLine("Contact DBA..");



        }



        static void Main()
        {
            SelectQuery();
            //InsertEmployee();
            //DeleteEmployee();
            //SelectQuery();
            UpdateEmploye();



            Console.Read();
        }
        

    }
}
