using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Services
{
    public interface ICleaningTaskService
    {
        Task<IEnumerable<CleaningTask>> GetAllCleaningTasksAsync();
        Task<CleaningTask> GetCleaningTaskByIdAsync(int id);
        Task AddCleaningTaskAsync(CleaningTask cleaningTask);
        Task UpdateCleaningTaskAsync(CleaningTask cleaningTask);
        Task DeleteCleaningTaskAsync(int id);
    }


}
