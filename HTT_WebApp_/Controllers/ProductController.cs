﻿using HTT_WebApp_.Models;
using HTT_WebApp_.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTT_WebApp_.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHTTAppService<ProductDto> _service;

        public ProductController(IHTTAppService<ProductDto> service)
        {
            _service = service;
        }
         
        /// <summary>
        /// GET request all products without categories.
        /// </summary>
        /// <returns>List of Product</returns>
        public async Task<IActionResult> Products()
        {
            var products = await _service.GetAllAsync();
            return View(products);
        }
        /// <summary>
        /// GET request all products with categories.
        /// </summary>
        /// <returns>List of Product</returns>
        public async Task<IActionResult> ProductsWithCategories()
        {
            var products = await _service.GetAllAsync();
            return View(products);
        }

    }
}
