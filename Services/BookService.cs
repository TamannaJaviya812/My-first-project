using BookApi.Models;

namespace BookApi.Services
{
    public class BookService
    {
        private List<Book> _books;

        public BookService()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public List<Book> GetAll()
        {
            return _books;
        }
        // to get single book

        public Book? GetBookById(int id)
        {
            return _books.Find(x => x.Id ==  id);
        }


    }
}
