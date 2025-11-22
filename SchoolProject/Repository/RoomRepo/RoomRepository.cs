using SchoolProject.Context;
using SchoolProject.Models;

namespace SchoolProject.Repository.RoomRepo
{
    public class RoomRepository : IRoomRepository
    {
        private readonly MyDbContext _myDbContext;

        public RoomRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public void Creat(Room room)
        {
            _myDbContext.Rooms.Add(room);
            _myDbContext.SaveChanges();
        }

        public void Delet(int Id)
        {
            Room? room = (from roomObj in _myDbContext.Rooms
                         where roomObj.RoomId == Id
                         select roomObj).FirstOrDefault();

            _myDbContext.Rooms.Remove(room);
            _myDbContext.SaveChanges();
        }


        public List<Room> GetAllRoom()
        {
            List<Room>? roomLst = (from roomObj in _myDbContext.Rooms
                                  select roomObj).ToList();

            return roomLst;
        }
    }
}
