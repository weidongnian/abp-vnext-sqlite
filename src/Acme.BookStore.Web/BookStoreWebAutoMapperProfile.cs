using Acme.BookStore.Dtos;
using AutoMapper;

namespace Acme.BookStore.Web
{
    public class BookStoreWebAutoMapperProfile : Profile
    {
        public BookStoreWebAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Web project.
            
            CreateMap<BookDto, CreateUpdateBookDto>();
            CreateMap<NewsDto, CreateNewsDto>();
            CreateMap<NewsDto, UpdateNewsDto>();
        }
    }
}
