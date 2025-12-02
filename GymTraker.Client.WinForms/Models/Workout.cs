using System;
using System.Collections.Generic;
using System.Text;

namespace GymTraker.Client.WinForms.Models
{
    internal class Workout
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string ExerciseName { get; set; } = "";
        public double Weight { get; set; }
        public int Reps { get; set; }
    }
}
