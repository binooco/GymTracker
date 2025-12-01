using System.Globalization;
using GymTracker.Api;
using GymTracker.Api.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ===== Підключаємо EF Core + SQLite =====
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// ===== Створюємо БД, якщо її ще нема =====
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    db.Database.EnsureCreated();
}

// ===== GET: всі тренування (з фільтром по даті) =====
// /api/workouts
// /api/workouts?date=2025-11-27
app.MapGet("/api/workouts", async (ApplicationDbContext db, string? date) =>
{
    IQueryable<Workout> query = db.Workouts;

    if (!string.IsNullOrWhiteSpace(date))
    {
        // очікуємо формат yyyy-MM-dd, такий же як формує WinForms
        if (DateTime.TryParseExact(
                date,
                "yyyy-MM-dd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out var d))
        {
            d = d.Date;
            query = query.Where(w => w.Date.Date == d);
        }
    }

    var list = await query
        .OrderBy(w => w.Id)
        .ToListAsync();

    return Results.Ok(list);
});

// ===== GET: одне тренування по id =====
app.MapGet("/api/workouts/{id:int}", async (ApplicationDbContext db, int id) =>
{
    var workout = await db.Workouts.FindAsync(id);

    return workout is null
        ? Results.NotFound($"Тренування з Id={id} не знайдено.")
        : Results.Ok(workout);
});

// ===== POST: додати тренування =====
app.MapPost("/api/workouts", async (ApplicationDbContext db, WorkoutCreateDto dto) =>
{
    if (!WorkoutValidator.IsValid(dto.ExerciseName, dto.Weight, dto.Reps, out var error))
        return Results.BadRequest(error);

    var workout = new Workout
    {
        // Id не чіпаємо — SQLite сам поставить (AUTOINCREMENT)
        Date = dto.Date.Date,
        ExerciseName = dto.ExerciseName.Trim(),
        Weight = dto.Weight,
        Reps = dto.Reps
    };

    db.Workouts.Add(workout);
    await db.SaveChangesAsync();

    return Results.Created($"/api/workouts/{workout.Id}", workout);
});

// ===== PUT: оновити тренування =====
app.MapPut("/api/workouts/{id:int}", async (ApplicationDbContext db, int id, WorkoutCreateDto dto) =>
{
    var workout = await db.Workouts.FindAsync(id);
    if (workout is null)
        return Results.NotFound($"Тренування з Id={id} не знайдено.");

    if (!WorkoutValidator.IsValid(dto.ExerciseName, dto.Weight, dto.Reps, out var error))
        return Results.BadRequest(error);

    workout.Date = dto.Date.Date;
    workout.ExerciseName = dto.ExerciseName.Trim();
    workout.Weight = dto.Weight;
    workout.Reps = dto.Reps;

    await db.SaveChangesAsync();

    return Results.Ok(workout);
});

// ===== DELETE: видалити тренування =====
app.MapDelete("/api/workouts/{id:int}", async (ApplicationDbContext db, int id) =>
{
    var workout = await db.Workouts.FindAsync(id);
    if (workout is null)
        return Results.NotFound($"Тренування з Id={id} не знайдено.");

    db.Workouts.Remove(workout);
    await db.SaveChangesAsync();

    return Results.NoContent();
});

app.Run();