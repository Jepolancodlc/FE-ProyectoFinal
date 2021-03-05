using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API_Proyecto_Team1_AJV.Models
{
    public partial class Cuerpos
    {
        public Cuerpos()
        {
            Trabajadores = new HashSet<Trabajadores>();
        }

        public string Cuerpo { get; set; }
        public string Descrip { get; set; }
        public string Categor { get; set; }
        public int Id { get; set; }
        public DateTime Gcrowver { get; set; }

        public virtual ICollection<Trabajadores> Trabajadores { get; set; }
    }
}
