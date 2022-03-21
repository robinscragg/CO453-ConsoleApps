using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ConsoleAppProject.App03;

namespace WebApps.Pages
{
    public class StudentMarksModel : PageModel
    {
        [BindProperty]
        public StudentGrades StudentGrades { get; set; }
        public void OnGet()
        {
        }
    }
}
