using Acme.BookStore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.BookStore.EntityFrameworkCore {
    public static class BookStoreDbContextModelCreatingExtensions {
        public static void ConfigureBookStore (this ModelBuilder builder) {
            Check.NotNull (builder, nameof (builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(BookStoreConsts.DbTablePrefix + "YourEntities", BookStoreConsts.DbSchema);       //    //...
            //});

            builder.Entity<Book> (b => {
                b.ToTable (BookStoreConsts.DbTablePrefix + "Books", BookStoreConsts.DbSchema);
                b.ConfigureByConvention (); //auto configure for the base class props
                b.Property (x => x.Name).IsRequired ().HasMaxLength (128);
            });

            builder.Entity<News>(b =>
            {
                b.ToTable(BookStoreConsts.DbTablePrefix + "News", BookStoreConsts.DbSchema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
            });
        }
    }
}
