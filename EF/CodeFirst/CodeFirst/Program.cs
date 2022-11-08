using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program

    {
        static BookContext bc = new BookContext();

        static void ShowBooks()
        {
            var book = from b in bc.Books
                       select b;
            foreach (var item  in book)
            {
                Console.WriteLine(item.BookId + " " + item.BookName);
            }
        }
        static void UpdateBooks()
        {
            var bk = bc.Books.FirstOrDefault(b => b.BookId == 2);
            bk.BookName = "Welocme to India";
            bc.SaveChanges();
        }

        //static void DeleteBooks()
        //{
        //    var bk = bc.Books.FirstOrDefault(b => b.BookId == 3);
        //    if (bk.BookId == 1)
        //    {
        //        Console.WriteLine(bc.Books.Remove(bk));
        //    }
        //    else
        //        Console.WriteLine("sorry");
        //        //bc.Books.Remove(bk);
        //    bc.SaveChanges();

        //}
        static void Main(string[] args)
        {
            // DeleteBooks();
            ShowBooks();
            UpdateBooks();

            //ShowBooks();
            using (var db = new BookContext())
            {
                db.Books.Add(new Book { BookName = "Introduction to EF" });
                db.SaveChanges();

                foreach (var bk in db.Books)
                {
                    Console.WriteLine(bk.BookId + " " + bk.BookName);
                }

            }
            ShowBooks();
            Console.Read();
               
        }
    }
}
