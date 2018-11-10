using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WorkoutTracker.Data;
using WorkoutTracker.Models;

namespace WorkoutTracker.Pages.Routines
{
    public class DetailsModel : PageModel
    {
        private readonly WorkoutTracker.Data.ApplicationDbContext _context;

        public DetailsModel(WorkoutTracker.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
