using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyFristAdo
{
    class ConnPractice
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader dr;

        static SqlConnection UseConnection()
        {
            con = new SqlConnection("data source= MEDL011027364\\SQLEXPRESS ;database = MyData;" + "integrated security = True;");
            con.Open();
            return con;
        }
        static void SelectCommand()
        {
            con = UseConnection();
            cmd = new SqlCommand("select * from dep ", con);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine("id is :" + dr[0] +" "+ "name is :" + dr[1] + " " + "gender is :" + dr[2]);
            }
        }
        static void Main()
        {
            SelectCommand();
            Console.Read();

        }
    }
}
