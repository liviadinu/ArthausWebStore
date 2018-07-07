using System.Threading.Tasks;
using ArthausWebStore.Models.PageHelpers;
using Microsoft.AspNetCore.Mvc;

namespace ArthausWebStore.ViewModels
{
    public class PagerViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            result.LinkTemplate = Url.Action(RouteData.Values["action"].ToString(), new { page = "{0}" });

            return View("Default", result);
        }
    }
}

