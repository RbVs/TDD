using System.Collections.Generic;
using System.Threading.Tasks;
using TDD.Api.Contracts;
using TDD.Api.Models;

namespace TDD.Api.Services
{
    public class UserRepository : IUserRepository
    {
        public Task<IList<User>> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<User> FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Create(User entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> IsExist(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(User entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(User entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Save()
        {
            throw new System.NotImplementedException();
        }
    }
}