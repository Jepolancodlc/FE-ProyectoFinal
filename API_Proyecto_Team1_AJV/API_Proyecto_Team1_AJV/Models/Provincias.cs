using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API_Proyecto_Team1_AJV.Models
{
    public partial class Provincias
    {
        public Provincias()
        {
            Poblac = new HashSet<Poblac>();
            TrabajadoresIdProvinciaNacNavigation = new HashSet<Trabajadores>();
            TrabajadoresIdProvinciaNavigation = new HashSet<Trabajadores>();
        }

        public string IdProvincia { get; set; }
        public string DProvincia { get; set; }
        public int Id { get; set; }
        public DateTime Gcrowver { get; set; }

        public virtual ICollection<Poblac> Poblac { get; set; }
        public virtual ICollection<Trabajadores> TrabajadoresIdProvinciaNacNavigation { get; set; }
        public virtual ICollection<Trabajadores> TrabajadoresIdProvinciaNavigation { get; set; }
    }
}
