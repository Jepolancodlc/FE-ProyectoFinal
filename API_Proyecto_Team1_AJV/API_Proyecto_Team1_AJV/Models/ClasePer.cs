using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API_Proyecto_Team1_AJV.Models
{
    public partial class ClasePer
    {
        public ClasePer()
        {
            Categors = new HashSet<Categors>();
            Grupos = new HashSet<Grupos>();
        }

        public string IdClasePer { get; set; }
        public string DClasePer { get; set; }
        public int Id { get; set; }
        public DateTime Gcrowver { get; set; }
        public string Asimilado { get; set; }

        public virtual ICollection<Categors> Categors { get; set; }
        public virtual ICollection<Grupos> Grupos { get; set; }
    }
}
