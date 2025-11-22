using Microsoft.EntityFrameworkCore;
using SchoolProject.Models;
using System.Collections.Generic;

namespace SchoolProject.Context
{
    public class MyDbContext:DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            base.OnConfiguring(dbContextOptionsBuilder);
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json" , optional:true , reloadOnChange:true);
            IConfigurationRoot config = builder.Build();
            var conString = config.GetConnectionString("MyConnection");
            dbContextOptionsBuilder.UseSqlServer(conString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
