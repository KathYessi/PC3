using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PC3simulacro.Models
{
    public class ProductoContext : DbContext
    {
        public DbSet<Producto> SolicitudesAdopcion { get; set; }
        public DbSet<TipoProducto> TipoProducto { get; set; }

        public ProductoContext(DbContextOptions dco) : base(dco) {
    }
}

}