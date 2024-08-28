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
    public class ReservationDetailService : IReservationDetailService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReservationDetailService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<ReservationDetail>> GetAllReservationDetailsAsync()
        {
            return await _unitOfWork.ReservationDetails.GetAllAsync();
        }

        public async Task<ReservationDetail> GetReservationDetailByIdAsync(int id)
        {
            return await _unitOfWork.ReservationDetails.GetByIdAsync(id);
        }

        public async Task AddReservationDetailAsync(ReservationDetail reservationDetail)
        {
            await _unitOfWork.ReservationDetails.AddAsync(reservationDetail);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateReservationDetailAsync(ReservationDetail reservationDetail)
        {
            _unitOfWork.ReservationDetails.Update(reservationDetail);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteReservationDetailAsync(int id)
        {
            var reservationDetail = await _unitOfWork.ReservationDetails.GetByIdAsync(id);
            if (reservationDetail != null)
            {
                _unitOfWork.ReservationDetails.Delete(reservationDetail);
                await _unitOfWork.CompleteAsync();
            }
        }
    }

}
