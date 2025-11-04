using Microsoft.EntityFrameworkCore;
using Squares.Domain.Entities;

namespace Squares.Infrastructure.Contexts
{
    public class PointsDbContext : DbContext
    {
        public DbSet<PointList> PointLists { get; set; }
        public DbSet<Point> Points { get; set; }    

        public PointsDbContext(DbContextOptions<PointsDbContext> options) :
            base(options) 
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PointList>()
                .HasKey(entity => new {entity.Id});

            modelBuilder.Entity<Point>()
                .HasKey(entity => new { entity.Id });
            //modelBuilder.Entity<PointList>()
            //    .Property(entity => entity.Id)
            //    .ValueGeneratedOnAdd();

            modelBuilder.Entity<PointList>()
                .HasMany(entity => entity.Points)
                .WithOne()
                .HasForeignKey("PointListId")
                .OnDelete(DeleteBehavior.Cascade); 


        }
    }
}
