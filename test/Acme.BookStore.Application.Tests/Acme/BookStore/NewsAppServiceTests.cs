using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Acme.BookStore
{
    public class NewsAppServiceTests : BookStoreApplicationTestBase
    {
        private readonly INewsAppService _newsAppService;

        public NewsAppServiceTests()
        {
            _newsAppService = GetRequiredService<INewsAppService>();
        }

        [Fact]
        public async Task Test1()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
