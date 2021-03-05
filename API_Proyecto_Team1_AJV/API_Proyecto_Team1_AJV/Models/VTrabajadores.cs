using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API_Proyecto_Team1_AJV.Models
{
    public partial class VTrabajadores
    {
        public int Id { get; set; }
        public string IdEmpresa { get; set; }
        public string IdTrabajador { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string DSiglas { get; set; }
        public string Domicilio { get; set; }
        public string Num { get; set; }
        public string Piso { get; set; }
        public string Puerta { get; set; }
        public string Cpostal { get; set; }
        public string DPoblacion { get; set; }
        public string DProvincia { get; set; }
    }
}
