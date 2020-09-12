using Xunit;

namespace TDD.UnitTests.Customer
{
    [Collection("Customer")]
    public class CustomerDetailsTests : IClassFixture<CustomerFixture>
    {
        private readonly CustomerFixture _customerFixture;

        public CustomerDetailsTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        public void GetFullName_GivenFirstAndLastName_ReturnsFullName()
        {
            //var customer = new Customer();
            var customer = _customerFixture.Customer;
            Assert.Equal("Rus Lan", customer.GetFullName("Rus", "Lan"));
        }
    }
}