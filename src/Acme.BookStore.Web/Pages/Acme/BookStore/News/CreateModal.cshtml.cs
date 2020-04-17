using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Acme.BookStore;
using Acme.BookStore.Dtos;

namespace Acme.BookStore.Web.Pages.Acme.BookStore.News
{
    public class CreateModalModel : BookStorePageModel
    {
        [BindProperty]
        public CreateNewsDto News { get; set; }

        private readonly INewsAppService _service;

        public CreateModalModel(INewsAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.CreateAsync(News);
            return NoContent();
        }
    }
}