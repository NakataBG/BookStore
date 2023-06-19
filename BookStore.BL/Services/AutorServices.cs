using BookStore.BL.Interfaces;
using BookStore.DL.Interfaces;
using BookStore.DL.Repositori;
using BookStore.Models.Data;
using BookStore.Models.Request;

namespace BookStore.BL.Services
{
    public class AutorServices : IAutorServices
    {
        private readonly IAutorRepo _autorRepo;
        private readonly IMapper _mapper;

        public AutorService(
            IAutorRepo authorRepository,
            IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public IEnumerable<Author> GetAll()
        {
            return _authorRepository.GetAll();
        }

        public Author GetById(int id)
        {
            return _authorRepository.GetById(id);
        }

        public void AddAuthor(AddAuthorRequest authorRequest)
        {
            var author = _mapper.Map<Author>(authorRequest);

            author.Id = _authorRepository.GetAll()
                .OrderByDescending(x => x.Id).First().Id + 1;

            _authorRepository.AddAuthor(author);
        }

        public void DeleteAuthor(int id)
        {
            _authorRepository.DeleteAuthor(id);
        }
    }
}
