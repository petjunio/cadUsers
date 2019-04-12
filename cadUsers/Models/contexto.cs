using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace usuarios.Models
{
    public class contexto : DbContext
    {
        public DbSet<usuario> Usuários { get; set; }
    }
}