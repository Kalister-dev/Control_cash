using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Control_cash.Models
{
    public class contexto: DbContext
    {
        public DbSet<debito> Debitos { get; set; }
    }
}