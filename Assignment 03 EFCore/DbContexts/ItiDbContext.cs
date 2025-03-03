using Assignment_03_EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_EFCore.DbContexts
{
    public class ItiDbContext : DbContext 
    {
        public ItiDbContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= .; Database = Iti; Trusted_Connection = True; TrustServerCertificate = True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


        public DbSet<Student>? Students { get; set; }
        public DbSet<Department>? Departments { get; set; }
        public DbSet<Instructor>? Instructors { get; set; }

        public DbSet<Course>? Courses { get; set; }

        public DbSet<Topic> Topic { get; set; }
        public DbSet<StudentCourse> StudentCourses { get;  set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }




    }
}
