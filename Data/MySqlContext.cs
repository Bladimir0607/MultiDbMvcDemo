using Microsoft.EntityFrameworkCore;
using MultiDbMvcDemo.Models;

namespace MultiDbMvcDemo.Data
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options)
            : base(options)
        {
        }

        public DbSet<DetallePedido> DetallesPedido { get; set; }
    }
}