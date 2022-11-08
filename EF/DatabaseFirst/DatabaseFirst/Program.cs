using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        
            static MyDataEntities db = new MyDataEntities();
            static dep prod = new dep();
           
            
            static void Main(string[] args)
            {
                Console.WriteLine("1. Insert into dep :");
                Console.WriteLine("2. Display dep:");
                Console.WriteLine("3. Exit :");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Enter Id :");
                    prod.id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Name :");
                    prod.name = Console.ReadLine();
                    Console.WriteLine("Enter Gender :");
                    prod.gender = Console.ReadLine();


                db.deps.Add(prod);
                    db.SaveChanges();
                    Console.WriteLine("Succesfully added ..");
                }
                else if (choice == "2")
                {
                    var prd = from p in db.deps
                              select p;

                    foreach (var item in prd)
                    {
                        Console.WriteLine(item.id + " " + item.name+ " " + item.gender);
                    }
                }
                else
                    Console.WriteLine("thanks..");
                Console.Read();
            }
        }
    }

