using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.Threading.Tasks;

namespace DW.CSS.Web.Pages
{
    public class _Host: PageModel
    {
        public async Task<IActionResult> OnGet()
        {
            try
            {
                return Page();
            }
            catch
            {
                throw;
            }
        }
    }
}
