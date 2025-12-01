using GymTracker.Api;
using Xunit;

namespace GymTracker.Api.Tests
{
    public class WorkoutValidatorTests
    {
        [Fact]
        public void IsValid_ReturnsFalse_WhenExerciseNameIsEmpty()
        {
            // arrange
            string name = "   ";
            double weight = 50;
            int reps = 5;

            // act
            var result = WorkoutValidator.IsValid(name, weight, reps, out var error);

            // assert
            Assert.False(result);
            Assert.Equal("Назва вправи обовʼязкова.", error);
        }

        [Fact]
        public void IsValid_ReturnsFalse_WhenWeightIsZeroOrNegative()
        {
            // arrange
            string name = "Жим лежачи";
            double weight = 0;
            int reps = 5;

            // act
            var result = WorkoutValidator.IsValid(name, weight, reps, out var error);

            // assert
            Assert.False(result);
            Assert.Equal("Вага має бути більшою за 0.", error);
        }

        [Fact]
        public void IsValid_ReturnsFalse_WhenRepsIsZeroOrNegative()
        {
            // arrange
            string name = "Присідання";
            double weight = 80;
            int reps = 0;

            // act
            var result = WorkoutValidator.IsValid(name, weight, reps, out var error);

            // assert
            Assert.False(result);
            Assert.Equal("Кількість повторень має бути більшою за 0.", error);
        }

        [Fact]
        public void IsValid_ReturnsTrue_ForCorrectWorkout()
        {
            // arrange
            string name = "Підтягування";
            double weight = 10;
            int reps = 8;

            // act
            var result = WorkoutValidator.IsValid(name, weight, reps, out var error);

            // assert
            Assert.True(result);
            Assert.Equal(string.Empty, error);
        }
    }
}
