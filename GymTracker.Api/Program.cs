using GymTracker.Api.Models;

var builder = WebApplication.CreateBuilder(args);

// Swagger (документація API)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// ===== In-memory список тренувань =====
List<Workout> workouts = new();
int nextId = 1;

// GET /api/workouts – список тренувань
app.MapGet("/api/workouts", () =>
{
    return workouts;
});

// POST /api/workouts – додати тренування
app.MapPost("/api/workouts", (WorkoutCreateDto dto) =>
{
    var workout = new Workout
    {
        Id = nextId++,
        Date = dto.Date,
        ExerciseName = dto.ExerciseName,
        Weight = dto.Weight,
        Reps = dto.Reps
    };

    workouts.Add(workout);
    return Results.Created($"/api/workouts/{workout.Id}", workout);
});

// DELETE /api/workouts/{id} – видалити тренування
app.MapDelete("/api/workouts/{id}", (int id) =>
{
    var workout = workouts.FirstOrDefault(w => w.Id == id);
    if (workout is null) return Results.NotFound();

    workouts.Remove(workout);
    return Results.NoContent();
});

app.Run();