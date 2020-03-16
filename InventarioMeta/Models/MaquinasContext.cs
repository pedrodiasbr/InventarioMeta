using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InventarioMeta.Models
{
    public class MaquinasContext : DbContext
    {
        public DbSet<Maquinas> Maquinas { get; set; }
    }
}