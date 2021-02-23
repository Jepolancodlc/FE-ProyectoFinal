using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API_Proyecto_Team1_AJV.Models
{
    public partial class Escala
    {
        public Escala()
        {
            Categors = new HashSet<Categors>();
            Subescala = new HashSet<Subescala>();
        }

        public string IdEscala { get; set; }
        public string DEscala { get; set; }
        public string Abreviacion { get; set; }
        public int Id { get; set; }
        public DateTime Gcrowver { get; set; }

        public virtual ICollection<Categors> Categors { get; set; }
        public virtual ICollection<Subescala> Subescala { get; set; }
    }
}
