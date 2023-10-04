using HTT_WebApp_.Models;
using HTT_WebApp_.Services;
using Microsoft.AspNetCore.Mvc;

namespace HTT_WebApp_.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IHTTAppService<CategoryDto> _service;

        public CategoryController(IHTTAppService<CategoryDto> service)
        {
            _service = service;
        }
        /// <summary>
        /// Returns all categories in database.
        /// </summary>
        /// <returns>List of Category</returns>
        public async Task<IActionResult> Categories()
        {
            var categories = await _service.GetAllAsync();
            return View(categories);
        }
    }
}
