
using ASP06.ControllerApi.Models;

namespace ASP06.MinimalApi.Models.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetAll();
    }
}