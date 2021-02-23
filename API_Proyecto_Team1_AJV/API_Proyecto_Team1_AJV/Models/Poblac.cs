using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API_Proyecto_Team1_AJV.Models
{
    public partial class Poblac
    {
        public Poblac()
        {
            TrabajadoresIdP = new HashSet<Trabajadores>();
            TrabajadoresIdPNavigation = new HashSet<Trabajadores>();
        }

        public string IdProvincia { get; set; }
        public string IdPoblacion { get; set; }
        public string DPoblacion { get; set; }
        public int Id { get; set; }
        public DateTime Gcrowver { get; set; }

        public virtual Provincias IdProvinciaNavigation { get; set; }
        public virtual ICollection<Trabajadores> TrabajadoresIdP { get; set; }
        public virtual ICollection<Trabajadores> TrabajadoresIdPNavigation { get; set; }
    }
}
