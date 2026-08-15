using GardenerAPI;
namespace WebApplication1.Interfaces;

public interface ICustomerRepo
{
    List<Customer> GetAllCustomers();
    Customer GetCustomer(int id);
    Customer UpdateCustomer(int id, Customer customer);
    void DeleteCustomer(int id);
    Customer AddCustomer(Customer customer);
}