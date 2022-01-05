namespace TuristeandoWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lugares
    {
        public int LugaresID { get; set; }

        public int CiudadID { get; set; }

        public string NombreLugar { get; set; }

        public string Descripcion { get; set; }

        public string Ubicacion { get; set; }

        public string Atencion { get; set; }

        public virtual Ciudads Ciudads { get; set; }
    }
}
