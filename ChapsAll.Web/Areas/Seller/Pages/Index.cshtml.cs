using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChapsAll.Web.Areas.Seller.Pages;

[Authorize(Roles = "Seller")]
public class IndexModel : PageModel
{
    public void OnGet()
    {
    }
}





