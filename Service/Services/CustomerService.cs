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
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            return await _unitOfWork.Customers.GetAllAsync();
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _unitOfWork.Customers.GetByIdAsync(id);
        }

        public async Task AddCustomerAsync(Customer customer)
        {
            await _unitOfWork.Customers.AddAsync(customer);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateCustomerAsync(Customer customer)
        {
            _unitOfWork.Customers.Update(customer);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteCustomerAsync(int id)
        {
            var customer = await _unitOfWork.Customers.GetByIdAsync(id);
            if (customer != null)
            {
                _unitOfWork.Customers.Delete(customer);
                await _unitOfWork.CompleteAsync();
            }
        }
    }

}
