using System.Threading.Tasks;

namespace Acme.BookStore.Web.Pages.Acme.BookStore.News
{
    public class IndexModel : BookStorePageModel
    {
        public async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
