using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository.CourseRepo;
using SchoolProject.Repository.StudentRepo;
using System.IO;



namespace SchoolProject.Controllers
{
    public class StudentController : Controller
    {
        private IStudentRepository _StudentRepository;
        private ICourseRepository _CourseRepository;
        private IWebHostEnvironment _Environment;
        public StudentController(IStudentRepository StudentRepository , ICourseRepository courseRepository , IWebHostEnvironment hostingEnvironment)
        {                                                             
           
            
            
            _StudentRepository = StudentRepository;
            _CourseRepository = courseRepository;
            _Environment = hostingEnvironment;
        }

        //List of students
        [HttpGet]
        public ActionResult Index()
        {
            List<Student> stdLst = _StudentRepository.GetAllStudent();
            return View(stdLst);
        }

        //Render the creation view
        [HttpGet]
        public ViewResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student, IFormFile StudentPhoto)
        {
            
            var wwwrootPath = _Environment.WebRootPath + "/StudentPicture/";
            Guid guid = Guid.NewGuid();
            string fullPath = System.IO.Path.Combine(wwwrootPath , guid + StudentPhoto.FileName);
            
            
            using (var FileStram = new FileStream(fullPath, FileMode.Create))
            {
                StudentPhoto.CopyTo(FileStram);
            }

            student.PhotoName = guid + StudentPhoto.FileName;

            _StudentRepository.Create(student);
            List<Student> stdLst = _StudentRepository.GetAllStudent();
            return View("Index", stdLst);
        }

        
        [HttpGet]
                 
        public ViewResult Delete(int id)
        {
            _StudentRepository.Delete(id);
            List<Student> stdLst = _StudentRepository.GetAllStudent();
            return View("Index", stdLst);
        }

        
        [HttpGet]
        public ActionResult Register()
        {
            StudentcourseVM VM = new StudentcourseVM();
            VM.StudentVM = _StudentRepository.GetAllStudent();
            VM.CourseVM = _CourseRepository.GetAllCourse();
            return View(VM);
        }

        [HttpPost]
        public ActionResult Register(int StudentId , int CourseId)//Overloading
        {
            _StudentRepository.Register(StudentId,CourseId);

            

            return RedirectToAction("Register");

        }

    }
}
