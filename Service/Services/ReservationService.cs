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
    public class ReservationService : IReservationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReservationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Reservation>> GetAllReservationsAsync()
        {
            return await _unitOfWork.Reservations.GetAllAsync();
        }

        public async Task<Reservation> GetReservationByIdAsync(int id)
        {
            return await _unitOfWork.Reservations.GetByIdAsync(id);
        }

        public async Task AddReservationAsync(Reservation reservation)
        {
            await _unitOfWork.Reservations.AddAsync(reservation);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateReservationAsync(Reservation reservation)
        {
            _unitOfWork.Reservations.Update(reservation);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteReservationAsync(int id)
        {
            var reservation = await _unitOfWork.Reservations.GetByIdAsync(id);
            if (reservation != null)
            {
                _unitOfWork.Reservations.Delete(reservation);
                await _unitOfWork.CompleteAsync();
            }
        }
    }

}
