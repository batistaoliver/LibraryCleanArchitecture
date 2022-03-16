using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanArchitecture.Infra.Data.Repositories
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public LibraryDbContext _context;

        public BookRepository(LibraryDbContext sqlContext)
            : base(sqlContext)
        {
            this._context = sqlContext;
        }
    }
}

