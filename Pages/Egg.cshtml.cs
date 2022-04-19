using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EggMaker.Models;
using EggMaker.Services;



namespace EggMaker.Pages
{
    public class EggModel : PageModel
    {
        [BindProperty]
        public Egg NewEgg { get; set; } = new();

        public List<Egg> eggs = new();
        public void OnGet()
        {
            eggs = EggService.GetAll();
        }

        public string OrganicText(Egg egg)
        {
            if (egg.IsOrganic)
                return "Organic";
            return "Not Organic";
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            EggService.Add(NewEgg);
            return RedirectToAction("Get");
        }

    }
}
