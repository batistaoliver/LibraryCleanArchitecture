using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain
{
    public class BookViewModel
    { 
        public IEnumerable<Book> Books { get; set; }
    }
}
