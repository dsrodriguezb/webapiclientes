using Microsoft.EntityFrameworkCore;
using WebApiClientes.Models;

namespace WebApiClientes.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<Cliente> Clientes { get; set; }

    }
}
