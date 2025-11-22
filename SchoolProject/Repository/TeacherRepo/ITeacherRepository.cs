using SchoolProject.Models;

namespace SchoolProject.Repository.TeacherRepo
{
    public interface ITeacherRepository
    {
        public List<Teacher> GetAllTeacher();
        public void DeleteTeacher(int Id);
        public void CreatTeacher(Teacher teacher);
    }
}
