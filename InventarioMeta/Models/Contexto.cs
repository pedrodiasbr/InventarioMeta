using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace InventarioMeta.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Maquinas>Maquinas { get; set; }
    }
}