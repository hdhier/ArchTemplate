using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> GetById(int id);
        Task<IEnumerable<Customer>> GetAll();
        Task Add(Customer entity);
        Task Update(Customer entity);
        Task Delete(int id);
    }
}
