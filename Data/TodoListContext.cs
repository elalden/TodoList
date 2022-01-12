#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Data
{
    public class TodoListContext : DbContext
    {
        public TodoListContext (DbContextOptions<TodoListContext> options)
            : base(options)
        {
        }

        public DbSet<TodoList.Models.TodoItem> TodoItem { get; set; }
    }
}
