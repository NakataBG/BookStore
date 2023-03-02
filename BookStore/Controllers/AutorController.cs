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
    }
}