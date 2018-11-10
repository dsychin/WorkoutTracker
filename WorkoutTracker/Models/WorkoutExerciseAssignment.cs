using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.Models
{
    public class WorkoutExerciseAssignment
    {
        public int WorkoutID { get; set; }
        public int ExerciseID { get; set; }

        public Workout Workout { get; set; }
        public Exercise Exercise { get; set; }
    }
}
