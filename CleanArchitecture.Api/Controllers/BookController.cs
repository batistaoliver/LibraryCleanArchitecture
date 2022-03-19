using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using CleanArchitecture.Domain;
using CleanArchitecture.Domain.Models;

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
        [HttpGet("consultar")]
        public ActionResult<BookRetorno> Get()
        {
            var models = _bookService.GetBooks();
            return Ok(models);
        }

        // POST api/values
        [HttpPost("inclusão")]
        public ActionResult Post([FromBody] Book book)
        {
            try
            {
                if (book == null)
                    return NotFound();

                _bookService.BookAdd(book);
                return Ok("Livro Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut("update")]
        public ActionResult Put([FromBody] Book book)
        {
            try
            {
                if (book == null)
                    return NotFound();

                _bookService.BookUpdate(book);
                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete("delete")]
        public ActionResult Delete([FromBody] Book book)
        {
            try
            {
                if (book == null)
                    return NotFound();

                _bookService.BookRemove(book);
                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_bookService.BookGetById(id));
        }

    }
}