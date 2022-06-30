using E_learning.Entity;
using Microsoft.EntityFrameworkCore;

namespace E_learning
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<LeaderShip> LeaderShips { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student_Course> Student_Courses { get; set; }
        public DbSet<TestForm> TestForms { get; set; }

        public DbSet<File_Exam> File_Exams { get; set; }

        public DbSet<Class_Test> Class_Tests { get; set; }

        public DbSet<Student_File_Exam> Student_File_Exams { get; set; }

        public DbSet<Student_Test> Student_Tests { get; set; }

        public DbSet<Result_Study> Result_Studys { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override async void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //-------------------- SET PRIMARY KEY FOR SOME ENTITY MODEL --------------------------

            builder.Entity<Student_Course>().HasKey(p => new { p.ID_Student, p.ID_Course });

            builder.Entity<Student_Test>().HasKey(p => new { p.ID_Student, p.ID_Class_Test });

            builder.Entity<Result_Study>().HasKey(p => new { p.ID_Student, p.ID_Subject });
        }
    }
}
