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
    public class CleaningTaskService : ICleaningTaskService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CleaningTaskService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<CleaningTask>> GetAllCleaningTasksAsync()
        {
            return await _unitOfWork.CleaningTasks.GetAllAsync();
        }

        public async Task<CleaningTask> GetCleaningTaskByIdAsync(int id)
        {
            return await _unitOfWork.CleaningTasks.GetByIdAsync(id);
        }

        public async Task AddCleaningTaskAsync(CleaningTask cleaningTask)
        {
            await _unitOfWork.CleaningTasks.AddAsync(cleaningTask);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateCleaningTaskAsync(CleaningTask cleaningTask)
        {
            _unitOfWork.CleaningTasks.Update(cleaningTask);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteCleaningTaskAsync(int id)
        {
            var cleaningTask = await _unitOfWork.CleaningTasks.GetByIdAsync(id);
            if (cleaningTask != null)
            {
                _unitOfWork.CleaningTasks.Delete(cleaningTask);
                await _unitOfWork.CompleteAsync();
            }
        }
    }

}
