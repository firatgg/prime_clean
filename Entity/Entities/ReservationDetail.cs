using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class ReservationDetail
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }

        public int CleaningTaskId { get; set; }
        public CleaningTask CleaningTask { get; set; }
    }

}
