using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API_Proyecto_Team1_AJV.Models
{
    public partial class Categors
    {
        public Categors()
        {
            Trabajadores = new HashSet<Trabajadores>();
        }

        public string Categori { get; set; }
        public string Descrip { get; set; }
        public string Cuerpo { get; set; }
        public string IdClasePer { get; set; }
        public string IdSubescala { get; set; }
        public string IdClase { get; set; }
        public string IdEscala { get; set; }
        public DateTime? FIniVigen { get; set; }
        public DateTime? FFinVigen { get; set; }
        public string DFunciones { get; set; }
        public int Id { get; set; }
        public DateTime Gcrowver { get; set; }
        public string Observac { get; set; }

        public virtual ClasePer IdClasePerNavigation { get; set; }
        public virtual Escala IdEscalaNavigation { get; set; }
        public virtual Subescala IdSubescalaNavigation { get; set; }
        public virtual ICollection<Trabajadores> Trabajadores { get; set; }
    }
}
