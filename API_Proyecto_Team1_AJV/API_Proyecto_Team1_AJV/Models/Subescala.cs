using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API_Proyecto_Team1_AJV.Models
{
    public partial class Subescala
    {
        public Subescala()
        {
            Categors = new HashSet<Categors>();
        }

        public string IdSubescala { get; set; }
        public string IdEscala { get; set; }
        public string DSubescala { get; set; }
        public int Id { get; set; }
        public DateTime Gcrowver { get; set; }

        public virtual Escala IdEscalaNavigation { get; set; }
        public virtual ICollection<Categors> Categors { get; set; }
    }
}
