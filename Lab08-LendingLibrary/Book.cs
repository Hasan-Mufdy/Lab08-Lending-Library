using System;

namespace Lab08_LendingLibrary
{
    public class Book
    {
        public string Title { get; }
        public string Firstname { get; }
        public string Lasttname { get; }
        public int NumberOfPages { get; }


        public Book(string title, string firstName, string lastName, int numberOfPages)
        {
            Title = title;
            Firstname = firstName;
            Lasttname = lastName;
            NumberOfPages = numberOfPages;
        }
    }
}