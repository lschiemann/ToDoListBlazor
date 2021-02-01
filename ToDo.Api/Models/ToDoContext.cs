using Microsoft.EntityFrameworkCore;
using ToDo.Shared;

namespace ToDo.Api.Models
{
  public class ToDoContext : DbContext
  {
    public ToDoContext(DbContextOptions<ToDoContext> options)
          : base(options)
    {
    }

    public DbSet<ToDoList> ToDoLists { get; set; }
    public DbSet<ToDoItem> ToDoItems { get; set; }
  }
}