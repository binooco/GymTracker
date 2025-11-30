namespace GymTracker.Api
{
    public static class WorkoutValidator
    {
        public static bool IsValid(string exerciseName, double weight, int reps, out string error)
        {
            if (string.IsNullOrWhiteSpace(exerciseName))
            {
                error = "Назва вправи обовʼязкова.";
                return false;
            }

            if (weight <= 0)
            {
                error = "Вага має бути більшою за 0.";
                return false;
            }

            if (reps <= 0)
            {
                error = "Кількість повторень має бути більшою за 0.";
                return false;
            }

            error = "";
            return true;
        }
    }
}
