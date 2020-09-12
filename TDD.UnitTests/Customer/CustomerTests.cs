using System;
using TDD.BusinessLogic;
using Xunit;

namespace TDD.UnitTests.Customer
{
    [Collection("Customer")]
    public class CustomerTests : IClassFixture<CustomerFixture>
    {
        private readonly CustomerFixture _customerFixture;

        public CustomerTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        public void CheckNameNotEmpty()
        {
            //var customer = new Customer();
            var customer = _customerFixture.Customer;
            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrEmpty(customer.Name));
        }

        [Fact]
        public void CheckLegiForDiscount()
        {
            //var customer = new Customer();
            var customer = _customerFixture.Customer;
            Assert.InRange(customer.Age, 25, 40);
        }

        [Fact]
        public void GetOrdersByNameNotNull()
        {
            //var customer = new Customer();
            var customer = _customerFixture.Customer;

            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(null));
            Assert.Equal(exceptionDetails.Message, "Hello Exception");
        }

        [Fact]
        public void LoyalCustomerOrdersGreaterThan100()
        {
            var customer = CustomerFactory.CreateCustomerInstance(102);
            Assert.IsType(typeof(LoyalCustomer), customer);
            Assert.IsNotType(typeof(TDD.BusinessLogic.Customer), customer);
            var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
            Assert.Equal(10, loyalCustomer.Discount);
        }
    }
}