using System.Collections.Generic;
using System.Reflection.Emit;
using TodoList.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
namespace TodoList.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
        }
        public DbSet<MyTask> MyTasks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MyTask>().HasData(
                new MyTask() { Id = 1, Title = "Menage", Description = "Du balai", TaskState = State.ToStart },
                new MyTask() { Id = 2, Title = "Vaisselle", Description = "faut que ça mousse", TaskState = State.ToStart },
                new MyTask() { Id = 3, Title = "devoir", Description = "faire une ToDo List", TaskState = State.ToStart }
                );
        }
    }
}
