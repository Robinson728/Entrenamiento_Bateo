using Entrenamiento_Bateo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entrenamiento_Bateo.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Bateadores> Bateadores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\BateadoresDatos.db");
        }
    }
}
