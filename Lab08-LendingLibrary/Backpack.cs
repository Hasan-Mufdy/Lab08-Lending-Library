using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_LendingLibrary
{
    public class Backpack<T> : IBag<T>
    {
        private List<T> books;

        public Backpack()
        {
            books = new List<T>();
        }
        public void Pack(T book)
        {
            if (book != null)
            {
                books.Add(book);
            }
        }

        public T Unpack(int i)
        {
            if (i >= 0 && i < books.Count)
            {
                var book = books[i];
                books.RemoveAt(i);
                return book;
            }

            throw new IndexOutOfRangeException();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return books.GetEnumerator();
        }


        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
