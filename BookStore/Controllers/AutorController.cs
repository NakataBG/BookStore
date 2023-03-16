using BookStore.BL.Interfaces;
using BookStore.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutorController : ControllerBase
    {
        private readonly IAutorServices _autorService;


        public AutorController(IAutorServices autorService)
        {
            _autorService = autorService;
        }
        [HttpGet("GetAll")]
        public IEnumerable<Autor>GetAll()
        {
            return _autorService.GetAll();
        }

        [HttpGet("GetById")]
        public Autor GetById(int id)
        {
            return _autorService.GetById(id);
        }
        [HttpPost("Add")]
        public void Add([FromBody] Autor author)
        {
            _autorService.AddAutor(author);
        }
    [HttpDelete("Delete")]
    public void Delete(int autorId) 
        {
            _autorService.DeleteAutor(autorId);
        }
    }
}