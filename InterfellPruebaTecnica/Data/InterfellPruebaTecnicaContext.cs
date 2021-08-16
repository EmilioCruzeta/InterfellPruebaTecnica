using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InterfellPruebaTecnica.Modelos;

namespace InterfellPruebaTecnica.Data
{
    public class InterfellPruebaTecnicaContext : DbContext
    {
        public InterfellPruebaTecnicaContext (DbContextOptions<InterfellPruebaTecnicaContext> options)
            : base(options)
        {
        }

        public DbSet<InterfellPruebaTecnica.Modelos.Clientes> Clientes { get; set; }
    }
}
