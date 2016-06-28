using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Examen.Models
{
    public class Curriculum
    {
        
        public List<Proyectos> Proyectos { get; set; }

        public List<Lenguajes> Lenguajes { get; set; }

    }
}