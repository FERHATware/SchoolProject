using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository.CourseRepo;
using SchoolProject.Repository.TeacherRepo;

namespace SchoolProject.Controllers
{
    public class CourseController : Controller
    {
        private ICourseRepository _courseRepository;
        private ITeacherRepository _teacherRepository;

        public CourseController(ICourseRepository courseRepository , ITeacherRepository teacherRepository)
        {
            _courseRepository = courseRepository;
            _teacherRepository = teacherRepository;

        }


        //get all courses
        [HttpGet]
        public ActionResult Index()
        {
            List<Course> courses = _courseRepository.GetAllCourse();
            return View(courses);
        }

        //delete course
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            _courseRepository.Delete(Id);
            List<Course> courses = _courseRepository.GetAllCourse();
            return View("Index", courses);
        }

        //creat course
        [HttpPost]
        public ActionResult Creat (Course course)
        {
            _courseRepository.Creat(course);
            List<Course> courses = _courseRepository.GetAllCourse();
            return View("Index" , courses);
        }
        [HttpGet]
        public ViewResult Creat()
        {
            List<Teacher> Lst = _teacherRepository.GetAllTeacher();
            return View(Lst);
        }


    }
}
