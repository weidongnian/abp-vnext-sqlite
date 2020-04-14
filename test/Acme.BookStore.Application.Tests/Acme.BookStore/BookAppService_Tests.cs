using System;
using System.Linq;
using System.Threading.Tasks;
using Shouldly;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Validation;
using Xunit;

namespace Acme.BookStore
{
    public class BookAppService_Tests : BookStoreApplicationTestBase
    {
        private readonly IBookAppService _bookAppService;

        public BookAppService_Tests()
        {
            _bookAppService = GetRequiredService<IBookAppService>();
        }
        
        /// <summary>
        /// 读取列表验证
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Should_Get_List_Of_Books()
        {
            //Act
            var result = await _bookAppService.GetListAsync(
                new PagedAndSortedResultRequestDto()
            );

            //Assert
            //断言书本数量大于0
            result.TotalCount.ShouldBeGreaterThan(0);
            
            //一定有一个书叫 Test book 1
            result.Items.ShouldContain(b => b.Name == "Test book 1");
        }
        
        /// <summary>
        /// 新增成功test
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Should_Create_A_Valid_Book()
        {
            //Act
            var result = await _bookAppService.CreateAsync(
                new CreateUpdateBookDto
                {
                    Name = "New test book 42",
                    Price = 10,
                    PublishDate = DateTime.Now,
                    Type = BookType.ScienceFiction
                }
            );

            //Assert
            result.Id.ShouldNotBe(Guid.Empty);
            
            result.Name.ShouldBe("New test book 42");
        }
        
        /// <summary>
        /// 新增测试方法,用以测试创建一个非法book实体失败的场景
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Should_Not_Create_A_Book_Without_Name()
        {
            var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
            {
                await _bookAppService.CreateAsync(
                    new CreateUpdateBookDto
                    {
                        Name = "",
                        Price = 10,
                        PublishDate = DateTime.Now,
                        Type = BookType.ScienceFiction
                    }
                );
            });

            exception.ValidationErrors
                .ShouldContain(err => err.MemberNames.Any(mem => mem == "Name"));
        }

    }
}