using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.Models
{
    public class SessionExercise
    {
        public int ID { get; set; }
        public int SessionID { get; set; }
        public int ExerciseID { get; set; }

        public Exercise Exercise { get; set; }
        public IList<RepCounter> RepCounters { get; set; }
        public Session Session { get; set; }
    }
}
