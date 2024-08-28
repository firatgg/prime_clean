using Entity.Entities;
using Entity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Customer> Customers { get; }
        IRepository<Room> Rooms { get; }
        IRepository<CleaningTask> CleaningTasks { get; }
        IRepository<Reservation> Reservations { get; }
        IRepository<ReservationDetail> ReservationDetails { get; }

        Task<int> CompleteAsync();
    }

}
