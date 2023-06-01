using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentEnrollement.Data;
using StudentEnrollment.Data.Configurations;

namespace StudentEnrollment.Data
{
    public class StudentEnrolmentDbContext : IdentityDbContext
    {

        public StudentEnrolmentDbContext(DbContextOptions<StudentEnrolmentDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CourseConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
           
           
        }

        public DbSet<Course> Curses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

    }
}
