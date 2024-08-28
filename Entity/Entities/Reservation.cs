using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; } // İstenilen temizlik tarihi
        public DateTime CreatedDate { get; set; } // Rezervasyonun oluşturulma tarihi

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<ReservationDetail> ReservationDetails { get; set; }
    }

}
