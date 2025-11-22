using SchoolProject.Context;
using SchoolProject.Models;

namespace SchoolProject.Repository.CourseRepo
{
    public class CourseRepository : ICourseRepository
    {
        private readonly MyDbContext _myDbContext;

        public CourseRepository (MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public void Creat(Course course)
        {
            _myDbContext.Courses.Add(course);
            _myDbContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            Course? course = (from coursObj in _myDbContext.Courses
                             where coursObj.CourseId == Id
                             select coursObj).FirstOrDefault();

            _myDbContext.Courses.Remove(course);
            _myDbContext.SaveChanges();
        }

        public List<Course> GetAllCourse()
        {
            List<Course> courseList = (from courseLst in _myDbContext.Courses
                                       select courseLst).ToList();

            return courseList;

        }
    }
}
