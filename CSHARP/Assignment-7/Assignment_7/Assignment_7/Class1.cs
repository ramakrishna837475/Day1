using System;
using System.Collections.Generic;
using System.Linq;


/*2. Create a Generic List Collection empList and populate it with the following records.
EmployeeID 	FirstName	   LastName 		Title 		DOB 			DOJ 			City
1001		     Malcolm  	     Daruwalla 	Manager 		16/11/1984 	8/6/2011 		Mumbai
1002 		Asdin	     Dhalla 		AsstManager 	20/08/1984 	7/7/2012 		Mumbai
1003 		Madhavi 	     Oza 		     Consultant 	14/11/1987 	12/4/2015 	Pune
1004 		Saba 		Shaikh		SE 			3/6/1990	 	2/2/2016	 	Pune
1005 		Nazia 		Shaikh 		SE 			8/3/1991 		2/2/2016	 	Mumbai
1006 		Amit 		Pathak 		Consultant 	7/11/1989 	8/8/2014 		Chennai
1007 		Vijay 		Natrajan	 	Consultant 	2/12/1989	 	1/6/2015 		Mumbai
1008 		Rahul 		Dubey 		Associate	 	11/11/1993 	6/11/2014	 	Chennai
1009 		Suresh 		Mistry		Associate 	12/8/1992 	3/12/2014 	Chennai
1010 		Sumit 		Shah 		Manager 		12/4/1991 	2/1/2016 		Pune
*/

namespace Ass_7
{
    class ListOfEmp
    {
        static void Main()

        {
            List<Employee> Emp = new List<Employee>();
            Employee E1 = new Employee
            {
                EmpployeeID = 1001,
                FirstName = "Malcolm",
                LastName = "Daruwalla",
                Title = "Manager",
                DOB = (DateTime.Parse("16/ 11/1984")),
                DOJ = (DateTime.Parse("8/6/2011")),
                City = "Mumbai"
            };

            Employee E2 = new Employee
            {
                EmpployeeID = 1002,
                FirstName = "Asdin	",
                LastName = " Dhalla",
                Title = "AsstManager ",
                DOB = (DateTime.Parse("20/08/1984")),
                DOJ = (DateTime.Parse("	7/7/2012 ")),
                City = "Mumbai"
            };

            Employee E3 = new Employee
            {
                EmpployeeID = 1003,
                FirstName = "Madhavi",
                LastName = "Oza",
                Title = "Consultant",
                DOB = (DateTime.Parse("14/11/1987")),
                DOJ = (DateTime.Parse("12/4/2015")),
                City = "Pune"
            };

            Employee E4 = new Employee
            {
                EmpployeeID = 1004,
                FirstName = "Saba ",
                LastName = "Shaikh",
                Title = "Manager",
                DOB = (DateTime.Parse("16/ 11/1984")),
                DOJ = (DateTime.Parse("8/6/2011")),
                City = "Pune"
            };

            Employee E5 = new Employee
            {
                EmpployeeID = 1005,
                FirstName = "Nazia",
                LastName = "Shaikth",
                Title = "SE",
                DOB = (DateTime.Parse("7/11/1989 ")),
                DOJ = (DateTime.Parse("2/2/2016")),
                City = "Mumbai"
            };

            Employee E6 = new Employee
            {
                EmpployeeID = 1006,
                FirstName = "Amit",
                LastName = "Pathak ",
                Title = "Consultant",
                DOB = (DateTime.Parse("16/ 11/1984")),
                DOJ = (DateTime.Parse("8/8/2014 ")),
                City = "Chennai"
            };

            Employee E7 = new Employee
            {
                EmpployeeID = 1007,
                FirstName = "Vijay ",
                LastName = "Natrajan",
                Title = "Consultant",
                DOB = (DateTime.Parse("2/12/1989")),
                DOJ = (DateTime.Parse("1/6/2015 ")),
                City = "Mumbai"
            };

            Employee E8 = new Employee
            {
                EmpployeeID = 1008,
                FirstName = "Rahul",
                LastName = "Dubey",
                Title = "Associate",
                DOB = (DateTime.Parse("11/11/1993")),
                DOJ = (DateTime.Parse("6/11/2014")),
                City = "Chennai"
            };

            Employee E9 = new Employee
            {
                EmpployeeID = 1009,
                FirstName = "Suresh",
                LastName = "Mistry",
                Title = "Associate",
                DOB = (DateTime.Parse("12/8/1992 ")),
                DOJ = (DateTime.Parse("3/12/2014")),
                City = "Chennai"
            };

            Employee E10 = new Employee
            {
                EmpployeeID = 1010,
                FirstName = "Sumit ",
                LastName = "Shah",
                Title = "Manager",
                DOB = (DateTime.Parse("12/4/1991")),
                DOJ = (DateTime.Parse("2/1/2016 ")),
                City = "Pune"
            };


            Emp.Add(E1); Emp.Add(E2);
            Emp.Add(E3); Emp.Add(E4);
            Emp.Add(E5); Emp.Add(E6);
            Emp.Add(E7); Emp.Add(E8);
            Emp.Add(E9); Emp.Add(E10);


            //a. Display detail of all the employee
            foreach (Employee ob in Emp)
            {
                Console.WriteLine(ob.EmpployeeID + " " + ob.FirstName + " " + ob.LastName + " " + ob.Title + " " +
                                    ob.DOB + " " + ob.DOJ + " " + ob.City);

            }

            //b.Display details of all the employee whose location is not Mumbai
            IEnumerable<Employee> loc = from R in Emp where R.City != "Mumbai" select R;
            foreach (Employee obj in loc)
            {
                Console.WriteLine(obj.City);

            }

            ////c. Display details of all the employee whose title is AsstManager


            var ti = Emp.Where(t => t.Title.Equals("AsstManager"));
            foreach (Employee ttl in ti)
            {
                Console.WriteLine(ttl.Title);

            }

            //d. Display details of all the employee whose Last Name start with S

            IEnumerable<Employee> lsname = Emp.Where(x => x.LastName[0] == 'S');
            foreach (Employee ls in lsname)
            {
                Console.WriteLine(ls.LastName);
            }

            // e.  Display a list of all the employee who have joined before 1 / 1 / 2015
            var joined = Emp.Where(e => e.DOJ < DateTime.Parse("1/1/2015"));

            foreach (Employee jn in joined)
            {
                Console.WriteLine(jn.DOJ);

            }

            // f. Display a list of all the employee whose date of birth is after 1 / 1 / 1990

            var birth = Emp.Where(f => f.DOB > DateTime.Parse("1/1/1990"));
            foreach (Employee brth in birth)
            {
                Console.WriteLine(brth.DOB);
            }

            //g. Display a list of all the employee whose designation is Consultant and Associate

            var des = Emp.Where(g => g.Title == "Consultant" || g.Title == "Associate");
            foreach (Employee dsn in des)
            {
                Console.WriteLine(dsn.Title);
            }

            //h.Display total number of employees
            var res = (from e in Emp
                       select e.EmpployeeID)
                     .Count();

            Console.WriteLine("Total number of Employees: {0}", res);


            //i.Display total number of employees belonging to “Chennai”
            var city = Emp.Where(t => t.City.Equals("Chennai")).Count();
            //foreach (Employee cty in city )
            //{
            //    Console.WriteLine(cty.City);

            //}


            Console.WriteLine("Total number of Employees belonging to chennai: {0}", city);


            //j.Display highest employee id from the list


            //k.Display total number of employee who have joined after 1 / 1 / 2015
            var joinee = Emp.Where(e => e.DOJ > DateTime.Parse("1/1/2015")).Count();

            //foreach (Employee jn in joinee)
            //{
            //    Console.WriteLine(jn.DOJ);

            //}
            Console.WriteLine("Total number of Employees who have joined after 1/1/2015: {0}", joinee);


            //l.Display total number of employee whose designation is not “Associate”
            IEnumerable<Employee> designation = (from R in Emp where R.Title != "Associate" select R);
            foreach (Employee obj in designation)
            {
                Console.WriteLine(obj.Title);

            }


            //m.Display total number of employee based on City
            var pl = from r in Emp
                     orderby r.City
                     group r by r.City into grp
                     select new { key = grp.Key, cnt = grp.Count() };

            //var emp = (from m in Emplist group m.Employee by new { m.City, m.Title} into grp 
            //          select new 
            //         { City = grp.Key.City,Title = grp.Key.Title Count = grp.Count() }).ToList();




            //n.Display total number of employee based on city and title


            var emp = (from m in Emp
                       group m.City by new { m.City, m.Title } into grp
                       select new
                       { City = grp.Key.City, Title = grp.Key.Title, Count = grp.Count() }).ToList();


            Console.ReadLine();


        }



    }



}