using System;
using System.Data;
using System.Data.SqlClient;
namespace Day1_ADO_Basic
{
    class ConnectedArch
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        //function that establishes connection with the database server and returns
        // an object of SqlConnection type
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=MEDL011027364\\SQLEXPRESS;initial catalog=MyData;" +"Integrated Security=True");
            con.Open();
            return con;
        }

        public static void SelectEmployees()
        {
            con = getConnection();
           
                //cmd = new SqlCommand("select * from dep", con); 
                //or as below
                cmd = new SqlCommand("select * from dep",con);
             
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] );
                    
                }
         
        }
            

        public static void InsertEmployee()
        {
            con = getConnection();
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
        //execute scalar eg
        public static void ScalarEg()
        {
            con = getConnection();
            // cmd = new SqlCommand("select deptid from Employee where empid=4");
            cmd = new SqlCommand("Select count(empid) from employee");
            cmd.Connection = con;
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine("There are {0}, no.of employees", count);
        }

        public static void DeleteEmployee()
        {
            con = getConnection();
            Console.WriteLine("Enter the employee code to delete:");
            int ecode = Convert.ToInt32(Console.ReadLine());
            //int res1 = Convert.ToInt32(Console.ReadLine());

            //if (res1 != ecode)
            //{
            //    Console.WriteLine("your entered wrong input");
            //}
            //else
            //{
            //    Console.WriteLine("success");
            //}

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
            con = getConnection();
            Console.WriteLine("Enter the employee code to update:");
           
            
            
            
        }


        static void Main(string[] args)
        {
            //InsertEmployee();
            //SelectEmployees();
            //ScalarEg();
            
            DeleteEmployee();
            //InsertEmployee();
            //SelectEmployees();
            //UpdateEmploye();
            Console.Read();
        }
    }
}


