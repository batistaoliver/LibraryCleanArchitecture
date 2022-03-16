using CleanArchitecture.Domain.Models;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IBookRepository : IRepositoryBase<Book>
    {
    }
}
