using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.Models
{
    public class Session
    {
        public int ID { get; set; }
        public int WorkoutID { get; set; }

        public Workout Workout { get; set; }
        public IList<Session> Sessions { get; set; }
    }
}
