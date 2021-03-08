using Microsoft.EntityFrameworkCore;
using Parcial2_ap1_20180240.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_ap1_20180240.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Proyectos> Proyectos { get; set; }
        public DbSet<Tarea> Tarea { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\GestionDeDatos.DB");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Tarea>().HasData(
                new Tarea() { TareaId = 1, TipoTarea = "Analisis" },
                new Tarea() { TareaId = 2, TipoTarea = "Diseño" },
                new Tarea() { TareaId = 3, TipoTarea = "Programacion" },
                new Tarea() { TareaId = 4, TipoTarea = "Prueba" }
            );
        }

    }
}
