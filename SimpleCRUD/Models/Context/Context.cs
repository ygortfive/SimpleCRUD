using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCRUD.Models.Contexto
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> option) : base(option)
        {
            Database.EnsureCreated();
        }
        public DbSet<Product> Product_DB { get; set; }
    }
}
