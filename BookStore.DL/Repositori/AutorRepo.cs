using BookStore.DL.InMemoryDb;
using BookStore.DL.Interfaces;
using BookStore.Models.Data;

namespace BookStore.DL.Repositori
{
    public class AutorRepo : IAutorRepo
    {
        public void AddAutor(Autor autor)
        {
            DataStore.Books.Add(autor);
        }

        public void DeleteAutor(int id)
        {
            var autor = GetByld(id);
            if (autor != null)
            {
                DataStore.Books.Remove(autor);
            }

        }

        public IEnumerable<Autor> GetAll()
        {
            return DataStore.Books;
        }

        public Autor? GetByld(int id)
        {
            return DataStore.Books//List<Autor>
                .FirstOrDefault(autor => autor.Id == id);

        }
    }
}
