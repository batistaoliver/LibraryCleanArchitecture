using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IBookService
    {
        BookRetorno GetBooks();
    }
}