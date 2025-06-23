using System;

class Program
{
    static void Main(string[] args)
    {
        ICustomerRepository repository = new CustomerRepositoryImpl();
        CustomerService service = new CustomerService(repository);
        service.DisplayCustomer(1001);
    }
}
