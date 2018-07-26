using LTM.School.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace LTM.School.EntityFramework
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Course>().ToTable("Course").Property(a=>a.CourseId).ValueGeneratedNever();
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment").HasOne(a=>a.Course).WithMany(a=>a.Enrollments);
            modelBuilder.Entity<Enrollment>().HasOne(a=>a.Student).WithMany(a=>a.Enrollments);
        }

    }
}