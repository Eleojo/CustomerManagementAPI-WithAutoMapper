using Data.Dto;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface ICustomerService
    {
        Task SignUpCustomerAsync(CustomerDto customerDto);
        Task<bool> EmailExists(string email);
        Task<List<CustomerDto>> GetAllCustomersAsync();
        Task<CustomerDto> CustomerDetails(Guid customerId);
        Task<bool> HardDeleteCustomerAsync(Guid customerId);
        Task<CustomerDto> SoftDeleteCustomerAsync(Guid customerId);
        Task<CustomerDto> UpdateCustomerAsync(Guid customerId, string name, string email, string password);
    }
}
