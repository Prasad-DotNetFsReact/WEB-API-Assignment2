// TaskDbContext.cs
using Microsoft.EntityFrameworkCore;
using Task_SubTask.Models;
using Task = Task_SubTask.Models.Task;

public class TaskDbContext : DbContext
{
    public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) { }

    public DbSet<Task> Tasks { get; set; }
    public DbSet<SubTask> SubTasks { get; set; }
}



