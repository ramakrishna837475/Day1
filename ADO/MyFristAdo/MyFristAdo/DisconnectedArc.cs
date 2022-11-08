using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyFristAdo
{
    class DisconnectedArc
    {
        public static SqlConnection con = null;
        public static SqlDataAdapter da;
        static void Main(string[] args)
        {
            try
            {
                //setting up the connection with the server
                con = new SqlConnection("data source=MEDL011027364\\SQLEXPRESS;initial catalog=kirsh;" + "Integrated Security=True");
                
                //execution of sql commands using dataadapter class object
                da = new SqlDataAdapter("Select * from dep where id = 1", con);

                con.Open();
                //creating a dataset object that can hold datatables, DataRelations,Data Constraints

                DataSet ds = new DataSet();
                //filling the output of the query into the dataset by identifying a datatable  with a name
                da.Fill(ds, "InfiniteEmployee");
                //associating the newly created datatable object as one of the element
                //in the dataset container
                DataTable dt = ds.Tables["InfiniteEmployee"];

                //iterate the datatble using datarows and datacolumns object
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        Console.Write(row[col]);
                        Console.Write(" ");
                    }
                    Console.WriteLine(" ");
                }

            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                con.Close();
            }
            Console.Read();
        }
    }
}