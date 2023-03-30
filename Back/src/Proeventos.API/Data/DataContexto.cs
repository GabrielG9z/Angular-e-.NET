using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proeventos.API.Models;

namespace Proeventos.API.Data
{
    public class DataContexto : DbContext
    {
        public DataContexto(DbContextOptions<DataContexto> options) : base(options) { }
        public DbSet<Evento> Eventos { get; set; }
    }
}