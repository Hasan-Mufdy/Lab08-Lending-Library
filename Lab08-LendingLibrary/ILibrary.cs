using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_LendingLibrary
{
    public interface ILibrary : IReadOnlyCollection<Book>
    {
        void Add(string title, string firstName, string lastName, int numberOfPages);
        Book Borrow(string title);
        void Return(Book book);
    }
}
