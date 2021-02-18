using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.Repositiories
{
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TaskModel> Tasks { get; set; }
    }
}
