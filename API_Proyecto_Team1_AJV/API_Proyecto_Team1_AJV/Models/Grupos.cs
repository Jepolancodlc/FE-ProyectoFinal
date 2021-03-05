using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API_Proyecto_Team1_AJV.Models
{
    public partial class Grupos
    {
        public Grupos()
        {
            Trabajadores = new HashSet<Trabajadores>();
        }

        public string Grupo { get; set; }
        public int Id { get; set; }
        public DateTime Gcrowver { get; set; }
        public string GrupoPpension { get; set; }
        public string IdClasePer { get; set; }
        public string DGrupo { get; set; }

        public virtual ClasePer IdClasePerNavigation { get; set; }
        public virtual ICollection<Trabajadores> Trabajadores { get; set; }
    }
}
