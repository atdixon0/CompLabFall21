using System;

namespace CompLabFall21
{
    class Program
    {
        static void Main(string[] args)
        {
          //task 3 create an author
            Author myAuthor= new Author("Jeff Lucas", 'm', "jslucas@cba.ua.edu");
            
            //Write Author to screen
            Console.WriteLine(myAuthor.ToString());

            //task 4 create a book
            Book myBook = new Book("12243", "My Book, Your Book", myAuthor);

            //Write Book to screen
            Console.WriteLine(myBook.ToString());

            //Task 5 acess the Author
            Console.WriteLine(myBook.GetAuthor().ToString());

            //Task 6 Anonymous Object
            Book yourBook = new Book("4321", "The Phantom Book", new Author("Jamie", 'f', "jamie@mail.com"));

            //Task 7 update Email
            myAuthor.SetEmail("jamie@crimson.edu");

            //Write to screen
            Console.WriteLine(myAuthor.ToString());

        }
    }
}
