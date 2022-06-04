using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstApplication_Version1.Pages
{
    public class IndexModel : PageModel
    {
        //It tells us when any Get request comes then trigget below function
        public void OnGet()
        {
        }

        //Above function is looks like below MVC function but it gets simpilfied 
        //public IActionResult OnGet()
        //{
        //    return Page();
        //}

    }
}
