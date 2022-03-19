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
       
        public BookRetorno GetBooks()
        {
            BookRetorno _bookRetorno = new BookRetorno();

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
        public void BookAdd(Book book)
        {
            _bookRepository.Add(book);
        }

        public void BookUpdate(Book book)
        {
            _bookRepository.Update(book);
        }
        public Book BookGetById(int id)
        {
            return _bookRepository.GetById(id);
        }

        public void BookRemove(Book book)
        {
            _bookRepository.Remove(book);
        }
    }
}