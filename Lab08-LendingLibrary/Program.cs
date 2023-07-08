using Lab08_LendingLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
public class Program
{
    public static void Main(string[] args)
    {
        ILibrary library = new Library();

        // Adding books: (to library)
        library.Add("Book 1", "firstname", "lastname", 500);
        library.Add("Book 2", "firstname", "lastname", 500);
        library.Add("Book 3", "firstname", "lastname", 500);
        library.Add("Book 4", "firstname", "lastname", 500);



        // Borrow books:

        Book borrowedBook1 = library.Borrow("Book 2");  // book 2 is now added to borrowed
        //Book borrowedBook2 = library.Borrow("Book 4");


        if (borrowedBook1 != null)
        {
            Console.WriteLine(borrowedBook1.Title + " is now added to borrowed.");
            Console.WriteLine(borrowedBook1.Title + " , name: " + borrowedBook1.Firstname + " " + borrowedBook1.Lasttname + " pages: " + borrowedBook1.NumberOfPages);
        }
        else
        {
            Console.WriteLine("Book not found...");
        }

        // new backpack:
        IBag<Book> backpack = new Backpack<Book>();

        // using the Pack method:
        backpack.Pack(borrowedBook1);

        // Unpack book
        Book unpackedBook = backpack.Unpack(0);

        if (unpackedBook != null)
        {
            Console.WriteLine("the Book: " + unpackedBook.Title + " is now unpacked"); ////
        }
        else
        {
            Console.WriteLine("book was not found...");
        }
    }
}