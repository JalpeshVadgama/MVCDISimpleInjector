using System.Collections.Generic;

namespace MVCDISimpleInjector.Models
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
    }
}