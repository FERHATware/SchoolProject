using SchoolProject.Models;

namespace SchoolProject.Repository.StudentRepo
{
    public interface IStudentRepository
    {
        public List<Student> GetAllStudent();
        public void Create(Student student);
        public void Delete(int Id);
        public void Register(int StudentId , int CourseId);
    }
}
