using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DbTransportadora:DbContext
    {
        public DbTransportadora():base("TransportadoraDB")
        {
           
        }

        public DbSet<Contato> Contato { get; set; }
        public DbSet<Cotacao> Cotacao { get; set; }
    }
}