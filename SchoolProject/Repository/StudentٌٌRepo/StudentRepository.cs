using SchoolProject.Models;
using SchoolProject.Context;

namespace SchoolProject.Repository.StudentRepo
{


    
    public class StudentRepository : IStudentRepository
    {
        private readonly MyDbContext _myDbConnection;

        public StudentRepository(MyDbContext myDbContext)
        {
            _myDbConnection = myDbContext;
        }

        public List<Student> GetAllStudent()
        {
            try
            {

                List<Student> students = (from stdsObj in _myDbConnection.Students
                                          select stdsObj).ToList();
                return students;

            }
            catch (Exception ex)
            {
                string error = ex.Message;
                
                return null;
            }
        }

        public void Create(Student student)
        {
            _myDbConnection.Students.Add(student);
            _myDbConnection.SaveChanges();
        }

        public void Delete(int Id)
        {

            Student? student = (from stdObj in _myDbConnection.Students
                                where stdObj.StudentId == Id
                               select stdObj).FirstOrDefault();

            

            _myDbConnection.Students.Remove(student);
            _myDbConnection.SaveChanges();
        }
        
        

        

        

        public void Register(int StudentId, int CourseId)
        {
            


            StudentCourse Obj = new StudentCourse();
            Obj.StudentId = StudentId;
            Obj.CourseId = CourseId;

            _myDbConnection.StudentCourses.Add(Obj);
            _myDbConnection.SaveChanges();
        }
    }
}
