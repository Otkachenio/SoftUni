namespace CustomerService.Visitors
{
    using CustomerService.Models;

    public interface ICustomerVisitor
    {
        void Visit(Customer customer);
    }
}