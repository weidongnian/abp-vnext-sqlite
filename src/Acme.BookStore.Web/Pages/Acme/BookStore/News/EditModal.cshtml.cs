using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Acme.BookStore;
using Acme.BookStore.Dtos;

namespace Acme.BookStore.Web.Pages.Acme.BookStore.News
{
    public class EditModalModel : BookStorePageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public UpdateNewsDto News { get; set; }

        private readonly INewsAppService _service;

        public EditModalModel(INewsAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            News = ObjectMapper.Map<NewsDto, UpdateNewsDto>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id, News);
            return NoContent();
        }
    }
}