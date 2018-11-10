using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.Models
{
    public class Routine
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedByID { get; set; }

        public IList<Workout> Workouts { get; set; }
        public IdentityUser CreatedBy { get; set; }
    }
}
