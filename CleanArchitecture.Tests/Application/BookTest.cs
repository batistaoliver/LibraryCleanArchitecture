using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Interfaces;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CleanArchitecture.Tests
{
    public class BookTest
    {
        //private IBookRepository _bookRepository;
        //public BookTest(IBookRepository bookRepository)
        //{
        //    _bookRepository = bookRepository;
        //}

        [Fact]
        public async Task x()
        {
            Mock<IBookService> mock = new Mock<IBookService>();
            Mock<IBookRepository> mockRepo = new Mock<IBookRepository>();
            //mock.Setup(m => m.GetBooks()).Returns();

            // Act
            var resultadoEsperado = mock.Object.GetBooks();
           // BookService resultado = new BookService(_bookRepository);
            var x = 0;
            // Assert
            //Assert.Equal(resultadoEsperado, resultado);

        }
    }
}
