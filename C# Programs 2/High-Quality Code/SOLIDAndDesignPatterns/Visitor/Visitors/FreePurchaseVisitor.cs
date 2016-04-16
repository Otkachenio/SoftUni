namespace CustomerService.Visitors
{
    using CustomerService.Models;

    public class FreePurchaseVisitor : ICustomerVisitor
    {
        public void Visit(Customer customer)
        {
            customer.Purchases.Add(new Purchase("SteamOp", 0.0));
        }
    }
}