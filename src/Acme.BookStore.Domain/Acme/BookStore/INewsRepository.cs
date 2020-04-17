using System;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore
{
    public interface INewsRepository : IRepository<News, Guid>
    {
    }
}