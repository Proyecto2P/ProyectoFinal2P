namespace TuristeandoWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ciudads
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ciudads()
        {
            Lugares = new HashSet<Lugares>();
        }

        [Key]
        public int CiudadID { get; set; }

        public int PaisID { get; set; }

        public string NombreCiudad { get; set; }

        public string Region { get; set; }

        public virtual Pais Pais { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lugares> Lugares { get; set; }
    }
}
