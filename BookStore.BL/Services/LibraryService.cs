using BookStore.BL.Interfaces;
using BookStore.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IBookRepository _bookRepository;

        public LibraryService(
            IAuthorRepository authorRepository,
            IBookRepository bookRepository)
        {
            _authorRepository = authorRepository;
            _bookRepository = bookRepository;
        }

        public GetAllBooksByAuthorResponse
            GetAllBooksByAuthor(int authorId)
        {
            var response = new GetAllBooksByAuthorResponse();

            response.Author = _authorRepository.GetById(authorId);
            response.Books = _bookRepository.GetAllByAuthorId(authorId);

            return response;
        }
    }
}
