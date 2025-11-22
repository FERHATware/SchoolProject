using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository.TeacherRepo;

namespace SchoolProject.Controllers
{
    public class TeacherController : Controller
    {
        private ITeacherRepository _TeacherRepository;
        public TeacherController(ITeacherRepository teacherRepository)
        {
            _TeacherRepository = teacherRepository;
        }

        //get all teacher
        [HttpGet]
        public ActionResult Index()
        {
            
            List<Teacher> teachers = _TeacherRepository.GetAllTeacher();
            return View(teachers);
        }

        //creat new teacher
        //[HttpPost]
        public ActionResult Creat(Teacher teacher)
        {
            _TeacherRepository.CreatTeacher(teacher);
            List<Teacher> teachers = _TeacherRepository.GetAllTeacher();
            return View("Index" , teachers);
        }
        [HttpGet]
        public ActionResult Creat()
        {

            return View();
        }


        //delete teacher
        public ActionResult Delete(int Id)
        {
            _TeacherRepository.DeleteTeacher(Id);
            List<Teacher> teachers = _TeacherRepository.GetAllTeacher();

            return View("Index", teachers);
        }

        
        
        


    }
}
