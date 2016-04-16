namespace CustomerService
{
    using CustomerService.Data;
    using CustomerService.Visitors;

    public class Program
    {
        static void Main()
        {
            var repository = new CustomerRepository();
            var discountVisitor = new DiscountRaiseVisitor();
            var freePurchaseVisitor = new FreePurchaseVisitor();

            var premiumCustomers = repository.GetPremiumCustomers();
            foreach (var premiumCustomer in premiumCustomers)
            {
                premiumCustomer.Accept(discountVisitor);
            }

            var allCustomers = repository.GetAll();
            foreach (var customer in allCustomers)
            {
                customer.Accept(freePurchaseVisitor);
            }
        }
    }
}