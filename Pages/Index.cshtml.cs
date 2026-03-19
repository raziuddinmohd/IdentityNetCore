using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Identity;

namespace IdentityNetCore.Pages
{
    public class IndexModel : PageModel
    {
        public int PasswordRequiredLength { get; }

        public IndexModel(IOptions<IdentityOptions> identityOptions)
        {
            PasswordRequiredLength = identityOptions?.Value?.Password.RequiredLength ?? 0;
        }
        public void OnGet()
        {

        }
    }
}
