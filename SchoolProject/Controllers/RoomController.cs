using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository.RoomRepo;

namespace SchoolProject.Controllers
{
    public class RoomController : Controller
    {
        private IRoomRepository _RoomRepository;

        
        public RoomController(IRoomRepository roomRepository)
        {
            _RoomRepository = roomRepository;
        }

        //Get all room
        [HttpGet]
        public ActionResult Index()
        {
            List<Room> lst = _RoomRepository.GetAllRoom();
            return View(lst);
        }

        //Creat Room
        [HttpPost]
        public ActionResult Creat(Room room)
        {
            _RoomRepository.Creat(room);
            List<Room> lst = _RoomRepository.GetAllRoom();
            return View("Index", lst);
        }
        [HttpGet]
        public ViewResult Creat()
        {
            
            return View();
        }

        //Delete Room
        
        public ActionResult Delete(int Id)
        {
            _RoomRepository.Delet(Id);
            List<Room> lst = _RoomRepository.GetAllRoom();
            return View("Index" , lst);
        }

    }
}
