using System;
using Acme.BookStore.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore
{
    public interface INewsAppService :
        ICrudAppService< 
            NewsDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateNewsDto,
            UpdateNewsDto>
    {

    }
}