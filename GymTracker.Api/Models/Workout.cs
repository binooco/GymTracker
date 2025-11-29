namespace GymTracker.Api.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string ExerciseName { get; set; } = "";
        public double Weight { get; set; }
        public int Reps { get; set; }
    }
}
