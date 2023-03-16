using BookStore.DL.InMemoryDb;
using BookStore.Models.Data;

namespace BookStore.DL.Repositori
{
    public class BookRepo
    {
        public void AddBook(Autor book)
        {
            DataStore.Books.Add(book);
        }

        public void DeleteBook(int id)
        {
            var Book = GetByld(id);
            if (Book != null)
            {
                DataStore.Books.Remove(Book);
            }

        }

        public IEnumerable<Autor> GetAll()
        {
            return DataStore.Books;
        }

        public Autor? GetByld(int id)
        {
            return DataStore.Books//List<Book>
                .FirstOrDefault(autor => autor.Id == id);

        }
    }
}
