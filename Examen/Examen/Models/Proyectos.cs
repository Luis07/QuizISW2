namespace Examen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Proyectos
    {
        public int id { get; set; }

        public string Nombre_Proyecto { get; set; }

        public string Descripcion_Proyecto { get; set; }
    }
}
