using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazForm.Entities;

namespace RazForm.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Account account { get; set; }

        public void OnGet()
        {
            account = new Account();
        }

        public IActionResult OnPost(Account account)
        {
            if (account.Username != null && account.Username.Equals("abc"))
            {
                ModelState.AddModelError("account.Username", "Username Already Exists");
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                return RedirectToPage("Success");
            }
        }
    }
}