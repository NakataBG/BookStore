using BookStore.BL.Interfaces;
using BookStore.DL.Interfaces;
using BookStore.Models.Data;

namespace BookStore.BL.Services
{
    public class AutorServices : IAutorServices
    {
        private readonly IAutorRepo _autorRepo;

        public AutorServices(IAutorRepo autorRepo)
        {
            _autorRepo = autorRepo;
        }

        public void AddAutor(Autor autor)
        {
            _autorRepo.AddAutor(autor);
        }

        public IEnumerable<Autor> GetAll()
        {
            return _autorRepo.GetAll();
        }

        public Autor GetById(int id)
        {
            return _autorRepo.GetByld(id);
        }
    }
}
