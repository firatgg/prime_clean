using Entity.Entities;
using Entity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public IRepository<Customer> Customers { get; private set; }
        public IRepository<Room> Rooms { get; private set; }
        public IRepository<CleaningTask> CleaningTasks { get; private set; }
        public IRepository<Reservation> Reservations { get; private set; }
        public IRepository<ReservationDetail> ReservationDetails { get; private set; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Customers = new GenericRepository<Customer>(_context);
            Rooms = new GenericRepository<Room>(_context);
            CleaningTasks = new GenericRepository<CleaningTask>(_context);
            Reservations = new GenericRepository<Reservation>(_context);
            ReservationDetails = new GenericRepository<ReservationDetail>(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
