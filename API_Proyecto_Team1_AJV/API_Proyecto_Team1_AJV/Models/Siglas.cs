using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API_Proyecto_Team1_AJV.Models
{
    public partial class Siglas
    {
        public Siglas()
        {
            Trabajadores = new HashSet<Trabajadores>();
        }

        public string Siglas1 { get; set; }
        public string DSiglas { get; set; }
        public int Id { get; set; }
        public DateTime Gcrowver { get; set; }

        public virtual ICollection<Trabajadores> Trabajadores { get; set; }
    }
}
