using Microsoft.AspNetCore.Mvc;
using BookStoreMVC.Models;

namespace BookStoreMVC.Controllers
{
    public class BooksController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BooksController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        
        public async Task<IActionResult> Index()
        {
            List<BookDTO> response = new List<BookDTO>();

            try
            {
                var client = _httpClientFactory.CreateClient();

                var httpResponseMess = await client.GetAsync("https://localhost:7153/api/Books/get-all-books");

                httpResponseMess.EnsureSuccessStatusCode();
                response.AddRange(await httpResponseMess.Content.ReadFromJsonAsync<IEnumerable<BookDTO>>());
            }
            catch (Exception ex)
            {
               
            }

            return View(response);
        }
    }
}