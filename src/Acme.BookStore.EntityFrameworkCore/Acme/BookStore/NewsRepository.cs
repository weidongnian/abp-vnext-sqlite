using System;
using Acme.BookStore.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.BookStore
{
    public class NewsRepository : EfCoreRepository<BookStoreDbContext, News, Guid>, INewsRepository
    {
        public NewsRepository(IDbContextProvider<BookStoreDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}