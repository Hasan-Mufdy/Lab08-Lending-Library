using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_LendingLibrary
{
    public class Library : ILibrary
    {
        private Dictionary<string, Book> books;

        public Library()
        {
            books = new Dictionary<string, Book>();
        }

        public int Count => books.Count;

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            var book = new Book(title, firstName, lastName, numberOfPages);
            //for(int i = 0; i < books.Count; i++)
            //{
                if (books.ContainsKey(title))
                {
                    throw new Exception("the book already exists...");
                }
            //}
            books.Add(title, book);
        }

        public Book Borrow(string title)
        {
            // TryGetValue method is used to check if the value exi
            if (books.TryGetValue(title, out var book))
            {
                books.Remove(title);
                return book;
            }
            return null;
        }

        public void Return(Book book)
        {
            if (book != null)
            {
                books.Add(book.Title, book);
            }
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return books.Values.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
