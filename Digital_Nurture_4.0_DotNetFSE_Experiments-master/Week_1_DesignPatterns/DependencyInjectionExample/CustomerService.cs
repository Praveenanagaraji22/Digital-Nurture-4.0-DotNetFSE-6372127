using System;

public class CustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public void DisplayCustomer(int id)
    {
        Customer customer = _customerRepository.FindCustomerById(id);
        Console.WriteLine("Customer Details:");
        Console.WriteLine("ID   : " + customer.Id);
        Console.WriteLine("Name : " + customer.Name);
    }
}
