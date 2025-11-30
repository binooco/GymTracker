using GymTracker.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace GymTracker.Api
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Workout> Workouts => Set<Workout>();
    }
}