using Entity.Entities;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // Entities için DbSet tanımlamaları
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<CleaningTask> CleaningTasks { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<ReservationDetail> ReservationDetails { get; set; }

    // Eğer bir iletişim formu kullanacaksanız, aşağıdaki satırı da ekleyin
    public DbSet<Contact> Contacts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Özel konfigürasyonlar burada yapılabilir
    }
}
