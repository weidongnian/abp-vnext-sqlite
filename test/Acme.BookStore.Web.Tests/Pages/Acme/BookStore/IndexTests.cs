
using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.BookStore.Pages.Acme.BookStore
{
    public class Index_Tests : BookStoreWebTestBase
    {
        [Fact]
        public async Task Index_Page_Test()
        {
            // Arrange

            // Act
            var response = await GetResponseAsStringAsync("/News");

            // Assert
            response.ShouldNotBeNull();
        }
    }
}
