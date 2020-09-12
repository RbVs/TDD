using System;

namespace TDD.BusinessLogic
{
    public class Customer
    {
        public string Name => "Aref";
        public int Age => 35;

        public string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

        public int GetOrdersByName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Hello Exception");

            return 100;
        }
    }

    public class LoyalCustomer : Customer
    {
        public int Discount { get; set; }

        public LoyalCustomer()
        {
            Discount = 10;
        }
    }

    public static class CustomerFactory
    {
        public static Customer CreateCustomerInstance(int orderCount)
        {
            if (orderCount <= 100)
                return new Customer();
            return new LoyalCustomer();
        }
    }
}