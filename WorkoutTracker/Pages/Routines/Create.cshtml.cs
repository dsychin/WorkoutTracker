using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WorkoutTracker.Data;
using WorkoutTracker.Models;

namespace WorkoutTracker.Pages.Routines
{
    public class CreateModel : PageModel
    {
        private readonly WorkoutTracker.Data.ApplicationDbContext _context;

        public CreateModel(WorkoutTracker.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CreatedByID"] = new SelectList(_context.Users, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Routine Routine { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Routines.Add(Routine);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}