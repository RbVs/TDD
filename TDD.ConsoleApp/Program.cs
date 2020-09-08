using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TDD.Api.Contracts;
using TDD.Api.Models;

namespace TDD.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // var dbContext = new AppDbContext(new DbContextOptions<AppDbContext>());
            // var repo = new Api.Services.TodoRepository(dbContext);
            // var result = await repo.FindById(1);
            
            Console.WriteLine("result.Description");
        }
    }
}