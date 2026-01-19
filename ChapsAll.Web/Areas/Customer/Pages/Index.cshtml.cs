using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChapsAll.Web.Areas.Customer.Pages;

[Authorize(Roles = "Customer")]
public class IndexModel : PageModel
{
    public void OnGet()
    {
    }
}





