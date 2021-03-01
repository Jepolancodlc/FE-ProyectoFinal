using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API_Proyecto_Team1_AJV.Models
{
    public partial class Empresas
    {
        public Empresas()
        {
            OrganigEmpresas = new HashSet<Organig>();
            OrganigIdEmpresaNavigation = new HashSet<Organig>();
        }

        public string IdEmpresa { get; set; }
        public string DEmpresa { get; set; }
        public string Siglas { get; set; }
        public string Domicilio { get; set; }
        public string Num { get; set; }
        public string Km { get; set; }
        public string Escalera { get; set; }
        public string Piso { get; set; }
        public string Puerta { get; set; }
        public string Cpostal { get; set; }
        public string IdProvincia { get; set; }
        public string IdPoblacion { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Nif { get; set; }
        public int Id { get; set; }
        public DateTime Gcrowver { get; set; }

        public virtual ICollection<Organig> OrganigEmpresas { get; set; }
        public virtual ICollection<Organig> OrganigIdEmpresaNavigation { get; set; }
    }
}
