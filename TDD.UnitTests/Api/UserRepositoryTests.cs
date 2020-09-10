using Microsoft.EntityFrameworkCore;
using Moq;
using TDD.Api.Models;
using Xunit;

namespace TDD.UnitTests.Api
{
    public class UserRepositoryTests
    {
        [Fact]
        public void Find_ById_Returns_Todo()
        {
            var testObject = new Todo();
            var dbContextMock = new Mock<AppDbContext>();
            var dbSetMock = new Mock<DbSet<Todo>>();

            dbContextMock.Setup(x => x.Set<Todo>())
                .Returns(dbSetMock.Object);

            dbContextMock.Verify(x => x.Set<Todo>());
        }
    }
}