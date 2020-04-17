using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore
{
    public class News : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }

        protected News()
        {
        }

        public News(
            Guid id,
            string name,
            BookType type,
            DateTime publishDate,
            float price
        ) :base(id)
        {
            Name = name;
            Type = type;
            PublishDate = publishDate;
            Price = price;
        }
    }
}
