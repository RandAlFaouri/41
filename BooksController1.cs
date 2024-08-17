using ASP06.MinimalApi.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP06.ControllerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController1 : Controller
    {
        private readonly IBookService _bookService;

        public BooksController1(IBookService bookService)
        {
            _bookService = bookService;
        }
        // ../books
        [HttpGet]
        public async  Task<IActionResult> Index()
        {
            return Ok(await _bookService.GetAll());
        }
    }
}
