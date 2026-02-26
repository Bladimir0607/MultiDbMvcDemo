using Microsoft.EntityFrameworkCore;
using MultiDbMvcDemo.Models;

namespace MultiDbMvcDemo.Data
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options)
            : base(options)
        {
        }

        public DbSet<Pedido> Pedidos { get; set; }
    }
}