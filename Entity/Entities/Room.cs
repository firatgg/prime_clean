using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; } // e.g., "Mutfak", "Banyo", etc.

        public ICollection<CleaningTask> CleaningTasks { get; set; }
    }

}
