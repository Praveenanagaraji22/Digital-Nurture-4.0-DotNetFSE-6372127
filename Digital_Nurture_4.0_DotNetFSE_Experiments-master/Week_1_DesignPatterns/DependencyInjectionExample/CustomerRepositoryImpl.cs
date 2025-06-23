public class CustomerRepositoryImpl : ICustomerRepository
{
    public Customer FindCustomerById(int id)
    {
        return new Customer(id, "Jeevapriya");
    }
}
