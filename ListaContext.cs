using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace lista
{
    public class ListaContext : DbContext
    {
        public DbSet<Elemento> Elementos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=lista.db");
        }
    }

}