using System;
using System.Collections.Generic;

/*Create a structure
struct Books
   private string title;
   private string author;
   private string subject;
   private int book_id;
Include 2 methods called GetValues() and ShowValues() to accept and display details.
create a Class called TestStructures that invokes the above methods of the structure to accept and
display the details of the book
*/

namespace Assign_61
{
    struct Books
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;
        public void getValues(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }
        public void ShowValues()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
            Console.WriteLine("Book_id :{0}", book_id);
        }
    };
    public class TestStructure
    {
        public static void Main(string[] args)
        {
            Books Book1 = new Books();
            Books Book2 = new Books();

            Book1.getValues("A Revenue Stamp", "Amrita Pritam", "Science", 54);
            Book2.getValues("David Copperfield", "Charles Darwin", "Chemistry", 1006);

            Book1.ShowValues();
            Book2.ShowValues();

            Console.ReadKey();
        }
    }



}