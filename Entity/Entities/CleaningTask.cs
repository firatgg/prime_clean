using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class CleaningTask
    {
        public int Id { get; set; }
        public string Name { get; set; } // e.g., "Çöpü boşalt", "Ocak ve fırını sil", etc.
        public decimal Price { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }
    }

}
