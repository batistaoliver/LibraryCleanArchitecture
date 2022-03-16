using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Services
{
    public class BookService : IBookService
    {
        public IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        //public BookViewModel GetBooks()
        //{
        //    return new BookViewModel()
        //    {
        //        Books = _bookRepository.GetBooks()
        //    };
        //}
        
        public BookRetorno GetBooks()
        {
            BookRetorno _bookRetorno = new BookRetorno();
            //{
            //    Status = "ok",
            //    Mensagem = "jjj",
            //    Books = null
            //};
            var bookList = new List<Book>();
            var books = _bookRepository.GetAll();
            foreach(var indice in books)
            {
                bookList.Add(indice);
            }
            _bookRetorno.Books = bookList;
            _bookRetorno.Status = "ok";
            _bookRetorno.Mensagem = "ok";
            return _bookRetorno;
        }
    }
}