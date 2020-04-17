using System;
using System.Threading.Tasks;
using Acme.BookStore;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Acme.BookStore.EntityFrameworkCore.Acme.BookStore
{
    public class NewsRepositoryTests : BookStoreEntityFrameworkCoreTestBase
    {
        private readonly IRepository<News, Guid> _newsRepository;

        public NewsRepositoryTests()
        {
            _newsRepository = GetRequiredService<IRepository<News, Guid>>();
        }

        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
    }
}
