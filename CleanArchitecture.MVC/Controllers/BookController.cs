using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace CleanArchitecture.MVC.Controllers
{
    public class BookController : Controller
    {
        private IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        //[Authorize]
        //public IActionResult Index()
        //{
        //    var model = _bookService.GetBooks();
        //    foreach (var indice in model)
        //    {

        //    }
        //    return View(model);
        //}
    }
}