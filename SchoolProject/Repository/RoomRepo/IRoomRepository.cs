using SchoolProject.Models;

namespace SchoolProject.Repository.RoomRepo
{
    public interface IRoomRepository
    {
        public List<Room> GetAllRoom();
        public void Delet(int Id);
        public void Creat(Room room);
    }
}
