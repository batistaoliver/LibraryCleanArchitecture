using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IBookService
    {
        BookRetorno GetBooks();
        void BookAdd(Book book);

        void BookUpdate(Book book);

        void BookRemove(Book book);

        Book BookGetById(int id);
    }
}