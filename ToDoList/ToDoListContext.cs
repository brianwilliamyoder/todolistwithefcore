using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
  public class ToDoListContext : DbContext
  {
    public DbSet<Item> Item { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }
  
  }
}