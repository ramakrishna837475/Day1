using System;
//1.Create a class called Books with BookName and AuthorName members. 
//Instantiate the class through constructor and also write a method Display() to display the details.
//Create an Indexer of Books Object to store 5 books in a class called BookShelf.
//Using the indexer method assign values to the books and display the same.
namespace Assign_6
{
        class Books
        {
            string bookname;
            string authorname;

            public Books(string bookname, string authorname)
            {
                this.bookname = bookname;
                this.authorname = authorname;
            }

            public void Display()
            {
                Console.WriteLine(bookname + " " + "is in :" + authorname + " authorname");
            }
        }
        class BookShelf
    {
            Books[] bk = new Books[5];

            public Books this[int postion]
            {
                get { return bk[postion]; }
                set { bk[postion] = value; }
            }


            static void Main()
            {
                BookShelf b = new BookShelf();
                b[0] = new Books("Sabarimala Vijnaanakosham", "KS Vijayanath");
                b[1] = new Books("Vahana Masterclass", "Alfredo Coveli");
                b[2] = new Books("Right Under Our Nose", "R. Giridharan");
                b[3] = new Books("‘Race With Me", "Robert Budd");
                b[4] = new Books("Yearbook", "Seth Rogen");
                for (int i = 0; i < 5; i++)
                {
                    b[i].Display();
                }
                
                Console.Read();
            }
        }
    }

