using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API_Proyecto_Team1_AJV.Models
{
    public partial class VNivOrg
    {
        public int Id { get; set; }
        public string IdOrganig { get; set; }
        public string IdEmpresa { get; set; }
        public string IdNivel { get; set; }
        public string Camino { get; set; }
        public string DNivel { get; set; }
        public string IdNivelPadre { get; set; }
        public string DNivelPadre { get; set; }
    }
}
