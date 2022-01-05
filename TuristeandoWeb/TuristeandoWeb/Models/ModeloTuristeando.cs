using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TuristeandoWeb.Models
{
    public partial class ModeloTuristeando : DbContext
    {
        public ModeloTuristeando()
            : base("name=ModeloTuristeando")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Ciudads> Ciudads { get; set; }
        public virtual DbSet<Continentes> Continentes { get; set; }
        public virtual DbSet<Lugares> Lugares { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
