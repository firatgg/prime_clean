using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Services
{
    public interface IReservationDetailService
    {
        Task<IEnumerable<ReservationDetail>> GetAllReservationDetailsAsync();
        Task<ReservationDetail> GetReservationDetailByIdAsync(int id);
        Task AddReservationDetailAsync(ReservationDetail reservationDetail);
        Task UpdateReservationDetailAsync(ReservationDetail reservationDetail);
        Task DeleteReservationDetailAsync(int id);
    }

}
