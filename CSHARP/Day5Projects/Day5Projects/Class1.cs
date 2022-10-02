using System;

namespace Day5Projects
{
    class Accounts
    {
        public int Accno, amt, bal, Deposit, Withdrawal;
        public string Name, Acctype;
        public void Credit()
        {

            Console.WriteLine("Enter the amount to deposit : ");
            int creditamt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your available balance is :{0} ", +(bal + creditamt));
            Console.Read();

        }

        public void Debit() 
        {
            Console.WriteLine("Enter the amount to withdrawal : ");
            int debitamt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your available balance is :{0} ", +(bal - debitamt));
            Console.Read();
        }


        public void Displaydetails()
        {
            Console.WriteLine("Account holder name is {0}", Name);
            Console.WriteLine("Account number {0}", Accno);
            Console.WriteLine("account type {0}", Acctype);

        }
    }

    class DriveClass
    {
        static void Main(string[] args)
        {
            Accounts program = new Accounts();

            Console.WriteLine("Enter your name: ");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter your account number : ");
            int Accno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your account type saving or current account : ");
            string Acctype = Console.ReadLine();
            Console.WriteLine("Select the type of transaction type 1)Deposit 2)Withdrawal :");
            string st = (Console.ReadLine());

            if (st == "Deposit")
            {
                program.Credit();
            }
            else if (st == "Withdrawal")
            {
                program.Debit();
            }
            else
            {
                Console.WriteLine("Invalid option");
            }

            program.Displaydetails();
            Console.ReadKey();

        }
    }
}
