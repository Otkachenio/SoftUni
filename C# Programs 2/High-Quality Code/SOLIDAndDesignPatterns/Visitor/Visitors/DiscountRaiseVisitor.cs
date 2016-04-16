namespace CustomerService.Visitors
{
    using CustomerService.Models;

    public class DiscountRaiseVisitor : ICustomerVisitor
    {
        public void Visit(Customer customer)
        {
            customer.Discount += 5.0;
        }
    }
}