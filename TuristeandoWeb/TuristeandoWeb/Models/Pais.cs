namespace TuristeandoWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pais
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pais()
        {
            Ciudads = new HashSet<Ciudads>();
        }

        public int PaisID { get; set; }

        public int ContinenteID { get; set; }

        public string NombrePais { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ciudads> Ciudads { get; set; }

        public virtual Continentes Continentes { get; set; }
    }
}
