using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.Models
{
    public enum Unit
    {
        kg,
        lbs,
        Others
    }

    public class RepCounter
    {
        public int ID { get; set; }
        public int SessionExerciseID { get; set; }
        public Unit Unit { get; set; }
        public int RepCount { get; set; }
    }
}
