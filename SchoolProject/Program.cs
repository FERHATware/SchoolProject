using Microsoft.EntityFrameworkCore;
using SchoolProject.Context;
using SchoolProject.Repository.CourseRepo;
using SchoolProject.Repository.RoomRepo;
using SchoolProject.Repository.StudentRepo;
using SchoolProject.Repository.TeacherRepo;

namespace SchoolProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            
            builder.Services.AddDbContext<MyDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")));


            builder.Services.AddTransient<IStudentRepository, StudentRepository>();





            builder.Services.AddTransient<IRoomRepository, RoomRepository>();
            builder.Services.AddTransient<ICourseRepository, CourseRepository>();
            builder.Services.AddTransient<ITeacherRepository, TeacherRepository>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
