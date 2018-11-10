using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.Models
{
    public enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public class Workout
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public int RoutineID { get; set; }

        public IList<WorkoutExerciseAssignment> WorkoutExercises { get; set; }
        public Routine Routine { get; set; }
    }
}
