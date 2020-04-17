dotnet tool install EasyAbp.AbpHelper -g

dotnet tool update EasyAbp.AbpHelper -g

create Model

abphelper generate crud News -d Acme.BookStore --separate-dto --custom-repository --skip-db-migrations


操作步骤如下

1，Add Model To DbContext

2，Configure Engity 为实体创建构造方法

3，Create a Custom Repository  创建仓储

    public interface INewsRepository : IRepository<News, Guid>
    {
    }

    options.AddRepository<News, NewsRepository>();

4，Create Dto

5，Create CRUD Application Service

6，Add Dtos To Automapper Profile

7，Add to Localization Resource

8，Generate UI Pages 

    Generate Page

    Add to MenuContributor

    Add Dtos to Automapper Profile

9，Create Test