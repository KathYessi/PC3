using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PC3simulacro.Models;
using Microsoft.EntityFrameworkCore;

namespace PC3simulacro.Data
{
    public class WebAppContext : DbContext
    {
       public DbSet<Producto> Productos { get; private set; }
       public WebAppContext(DbContextOptions dco) : base(dco) {

    }
  }  
}