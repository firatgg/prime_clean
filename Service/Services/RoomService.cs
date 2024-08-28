using Entity.Entities;
using Entity.Services;
using Entity.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class RoomService : IRoomService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoomService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Room>> GetAllRoomsAsync()
        {
            return await _unitOfWork.Rooms.GetAllAsync();
        }

        public async Task<Room> GetRoomByIdAsync(int id)
        {
            return await _unitOfWork.Rooms.GetByIdAsync(id);
        }

        public async Task AddRoomAsync(Room room)
        {
            await _unitOfWork.Rooms.AddAsync(room);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateRoomAsync(Room room)
        {
            _unitOfWork.Rooms.Update(room);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteRoomAsync(int id)
        {
            var room = await _unitOfWork.Rooms.GetByIdAsync(id);
            if (room != null)
            {
                _unitOfWork.Rooms.Delete(room);
                await _unitOfWork.CompleteAsync();
            }
        }
    }

}
