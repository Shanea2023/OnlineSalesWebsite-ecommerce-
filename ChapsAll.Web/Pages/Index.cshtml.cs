using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace ChapsAll.Web.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public IActionResult OnGet()
    {
        if (User.Identity?.IsAuthenticated == true)
        {
            if (User.IsInRole("Admin"))
            {
                return RedirectToPage("/Index", new { area = "Admin" });
            }
            if (User.IsInRole("Seller"))
            {
                return RedirectToPage("/Index", new { area = "Seller" });
            }
            if (User.IsInRole("Customer"))
            {
                return RedirectToPage("/Index", new { area = "Customer" });
            }
        }
        return Page();
    }
}
