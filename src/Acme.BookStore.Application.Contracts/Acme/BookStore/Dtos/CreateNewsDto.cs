
using System;
using System.ComponentModel;

namespace Acme.BookStore.Dtos
{
    public class CreateNewsDto
    {
        [DisplayName("NewsName")]
        public string Name { get; set; }

        [DisplayName("NewsType")]
        public BookType Type { get; set; }

        [DisplayName("NewsPublishDate")]
        public DateTime PublishDate { get; set; }

        [DisplayName("NewsPrice")]
        public float Price { get; set; }
    }
}