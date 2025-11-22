using SchoolProject.Context;
using SchoolProject.Models;

namespace SchoolProject.Repository.TeacherRepo
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly MyDbContext _myDbContext;

        public TeacherRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
            
        }

        public void CreatTeacher(Teacher teacher)
        {
            _myDbContext.Teachers.Add(teacher);
            _myDbContext.SaveChanges();
        }

        public void DeleteTeacher(int Id)
        {
            Teacher? teacher = (from teacherObj in _myDbContext.Teachers
                               where teacherObj.TeacherId == Id
                               select teacherObj).FirstOrDefault();

            _myDbContext.Remove(teacher);
            _myDbContext.SaveChanges();
        }

        public List<Teacher> GetAllTeacher()
        {



            List<Teacher>? Lst = (from teacherObj in _myDbContext.Teachers
                                 select teacherObj).ToList();
            return Lst;
        }
    }
}
