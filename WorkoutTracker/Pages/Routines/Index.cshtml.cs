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
    public class IndexModel : PageModel
    {
        private readonly WorkoutTracker.Data.ApplicationDbContext _context;

        public IndexModel(WorkoutTracker.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Routine> Routine { get;set; }

        public async Task OnGetAsync()
        {
            Routine = await _context.Routines
                .Include(r => r.CreatedBy).ToListAsync();
        }
    }
}
