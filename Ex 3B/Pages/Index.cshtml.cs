using Ex_3B.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ex_3B.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
       public User User { get; set; } = new User();
        public DateTime TodayDate { get; set; }

        public int Age { get; set; }
        public void OnGet()
        {
            TodayDate = DateTime.Today;
        }
        public void OnPost()
        {
            TodayDate = DateTime.Today;

           
        }
    }
}
