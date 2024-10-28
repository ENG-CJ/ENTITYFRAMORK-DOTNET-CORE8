using Libraries.Models;
using Libraries.Responses;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Libraries.Controllers
{
    public class BookController : Controller
    {
        public readonly BookContext bookContext;
        public BookController(BookContext bookContext) {
            this.bookContext = bookContext;

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ApiResponse> CreateBook([FromBody] Book book) {
            await bookContext.AddAsync(book);
            await bookContext.SaveChangesAsync();
            return new ApiResponse(true, "Book has been created", book);
        }


        [HttpGet]
        public async Task<ApiResponse> GetBooks()
        {
            var books = await bookContext.Books.ToListAsync<Book>();
            return new ApiResponse(true, "Loaded success", books);
        }


        [HttpDelete]
        public async Task<ApiResponse> DeleteBook(int id)
        {
            var books = await bookContext.Books.FindAsync(id);
            if(books!=null) 
                 bookContext.Books.Remove(books);
            return new ApiResponse(true, "removed", books);
        }
    }
}
