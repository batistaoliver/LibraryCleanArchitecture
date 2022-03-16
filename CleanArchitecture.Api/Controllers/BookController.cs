using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using CleanArchitecture.Domain;

namespace CleanArchitecture.MVC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        //[Authorize]
        [HttpGet]
        public ActionResult<BookRetorno> Get()
        {
            var models = _bookService.GetBooks();
           
            var x = 0;
            //return model;
            return Ok(models);
        }

        //public IActionResult Index()
        //{
        //    BookViewModel model = _bookService.GetBooks();
        //    return View(model);
        //}
    }
}