using Lab08_LendingLibrary;

namespace LendingLibraryTest
{
    public class UnitTest1
    {
        [Fact]
        public void Check_If_Book_IsAddedToLibrary()
        {
            ILibrary library = new Library();

            library.Add("Book 10", "Firstname", "Lastname", 500);

            Assert.Equal(1, library.Count);
        }

        [Fact]
        public void BorrowAnExistingBook_ReturnsBookAndRemovesIt()
        {
            ILibrary library = new Library();
            library.Add("Book 1", "Firstname", "Lastname", 500);
            Book expectedBook = new Book("Book 1", "Firstname", "Lastname", 500);

            Book borrowedBook = library.Borrow("Book 1");

            Assert.NotNull(borrowedBook);
            Assert.Equal(expectedBook.Title, borrowedBook.Title);

            Assert.DoesNotContain(borrowedBook, library);
            Assert.Equal(0, library.Count); // library is empty now
        }

        [Fact]
        public void Check_If_BorrowingMissingBook_ReturnsNull()
        {
            ILibrary library = new Library();

            Book borrowedBook = library.Borrow("a missing book safjldfjs");

            Assert.Null(borrowedBook);
        }
        [Fact]
        public void Check_If_ReturnedBook_ReturnedToLibrary()
        {
            ILibrary library = new Library();
            Book book = new Book("Book 1", "Firstname", "Lastname", 500);

            library.Return(book);

            Assert.Contains(book, library);
            Assert.Equal(1, library.Count); // should be 1 book in the library
        }

        [Fact]
        public void Check_PackAndUnpackBooks()
        {
            IBag<string> backpack = new Backpack<string>();

            backpack.Pack("Book 1");
            backpack.Pack("Book 2");

            Assert.Equal(2, backpack.Count());

            // Unpack book 1
            string unpackedItem1 = backpack.Unpack(0);
            Assert.Equal("Book 1", unpackedItem1);
            Assert.Equal(1, backpack.Count());

            // Unpack book 2
            string unpackedItem2 = backpack.Unpack(0);
            Assert.Equal("Book 2", unpackedItem2);
            Assert.Equal(0, backpack.Count());
        }




    }
}