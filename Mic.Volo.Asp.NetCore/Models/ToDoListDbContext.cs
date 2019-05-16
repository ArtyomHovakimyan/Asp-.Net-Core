using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mic.Volo.Asp.NetCore.Models
{
    public class ToDoListDbContext:DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }
        public ToDoListDbContext(DbContextOptions<ToDoListDbContext> options)
            :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoItem>(e =>
            {
                e.HasKey(b => b.Id);
                e.Property(b => b.Id).HasDefaultValueSql("(newid())");
                e.Property(b => b.Title).IsRequired();
                e.Property(b => b.Completed).IsRequired().HasDefaultValue(false);
                e.Property(b => b.Color).IsRequired().HasDefaultValue("#fff");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
