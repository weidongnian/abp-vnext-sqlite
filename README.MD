基于sqlite的abp vnext的dotnet core 3.1 程序，不用安装数据库，就可以运行

macbook 下

1，进入DbMigrations项目目录里，迁移数据，数据名叫abp.db

    cd src/Acme.BookStore.EntityFrameworkCore.DbMigrations/

    dotnet ef database update

2，进入Acme.BookStore.DbMigrator目录初始化数据

    cd src/Acme.BookStore.DbMigrator/

    dotnet run

3，进入web目录，运行，访问，登录 admin/1q2w3E*

    cd src/Acme.BookStore.Web

    dotnet run

    open 'https://localhost:44387/'

4，期间可以生成报错，请在项目外，dotnet restore 和dotnet build,文章https报错等，请信任证书

    dotnet dev-certs --trust

5，自动化工具 EasyApp.AbpHelper

dotnet tool install EasyAbp.AbpHelper -g

dotnet tool update EasyAbp.AbpHelper -g

create Model

abphelper generate crud News -d Acme.BookStore --separate-dto --custom-repository --skip-db-migrations


操作步骤如下

1，Add Model To DbContext --2

2，Configure Entity 为实体创建构造方法

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