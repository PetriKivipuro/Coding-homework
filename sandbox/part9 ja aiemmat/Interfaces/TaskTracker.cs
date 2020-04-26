using System;
using System.Collections.Generic;

namespace sandbox
{
    public class TaskTracker
    {
        private Dictionary<string, List<int>> completedExercises;

        public TaskTracker()
        {
            this.completedExercises = new Dictionary<string, List<int>>();
        }

        public void Add(string user, int exercise)
        {
            if (!this.completedExercises.ContainsKey(user))
            {
                this.completedExercises.Add(user, new List<int>());
            }
            List<int> completed = this.completedExercises[user];
            completed.Add(exercise);

        }

        public void Print()
        {
            Dictionary<string, List<int>>.KeyCollection keys = this.completedExercises.Keys;

            foreach (string name in keys)
            {
                foreach (int completed in this.completedExercises[name])
                {
                    Console.WriteLine(name + ": " + completed);
                }
            }
        }
    }
}