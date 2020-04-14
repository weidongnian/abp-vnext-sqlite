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