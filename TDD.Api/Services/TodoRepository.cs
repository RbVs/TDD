using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TDD.Api.Contracts;
using TDD.Api.Models;

namespace TDD.Api.Services
{
    public class TodoRepository : ITodoRepository
    {
        private readonly AppDbContext _dbContext;

        public TodoRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<Todo>> FindAll()
        {
            var result = await _dbContext.Todo.ToListAsync();
            return result;
        }

        public async Task<Todo> FindById(int id)
        {
            var result = await _dbContext.Todo.FindAsync(id);
            return result;
        }

        public async Task<bool> Create(Todo entity)
        {
            await _dbContext.Todo.AddAsync(entity);
            return await Save();
        }

        public async Task<bool> IsExist(int id)
        {
            var result = await _dbContext.Todo.AnyAsync(c => c.Id.Equals(id));
            return result;
        }

        public async Task<bool> Update(Todo entity)
        {
            _dbContext.Update(entity);
            return await Save();
        }

        public async Task<bool> Delete(Todo entity)
        {
            _dbContext.Remove(entity);
            return await Save();
        }

        public async Task<bool> Save()
        {
            var changes = await _dbContext.SaveChangesAsync();
            return changes > 0;
        }
    }
}