using System;
using Acme.BookStore.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore
{
    public class NewsAppService : CrudAppService<News, NewsDto, Guid, PagedAndSortedResultRequestDto, CreateNewsDto, UpdateNewsDto>,
        INewsAppService
    {
        private readonly INewsRepository _repository;

        public NewsAppService(INewsRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}