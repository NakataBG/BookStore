using BookStore.BL.Interfaces;
using BookStore.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpGet("GetAllBooksByAuthor")]
        public GetAllBooksByAuthorResponse
            GetAllBooksByAuthor(int authorId)
        {
            return _libraryService.GetAllBooksByAuthor(authorId);
        }
    }
}