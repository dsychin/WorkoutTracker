using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WorkoutTracker.Data;
using WorkoutTracker.Models;

namespace WorkoutTracker.Pages.Routines
{
    public class EditModel : PageModel
    {
        private readonly WorkoutTracker.Data.ApplicationDbContext _context;

        public EditModel(WorkoutTracker.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Routine Routine { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Routine = await _context.Routines
                .Include(r => r.CreatedBy).FirstOrDefaultAsync(m => m.ID == id);

            if (Routine == null)
            {
                return NotFound();
            }
           ViewData["CreatedByID"] = new SelectList(_context.Users, "Id", "Id");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Routine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoutineExists(Routine.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RoutineExists(int id)
        {
            return _context.Routines.Any(e => e.ID == id);
        }
    }
}
