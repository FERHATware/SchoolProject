using SchoolProject.Models;

namespace SchoolProject.Repository.CourseRepo
{
    public interface ICourseRepository
    {
        public List<Course> GetAllCourse();
        public void Creat(Course course);
        public void Delete(int Id);
    }
}
