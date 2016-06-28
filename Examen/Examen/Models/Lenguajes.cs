namespace Examen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lenguajes
    {
        public int id { get; set; }

        public string Lenguaje { get; set; }
    }
}
