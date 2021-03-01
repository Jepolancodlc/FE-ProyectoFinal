using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API_Proyecto_Team1_AJV.Models
{
    public partial class Organig
    {
        public Organig()
        {
            NivOrgIdOrganigNavigation = new HashSet<NivOrg>();
            NivOrgOrganig = new HashSet<NivOrg>();
        }

        public string DOrganig { get; set; }
        public int EmpresasId { get; set; }
        public DateTime Gcrowver { get; set; }
        public int Id { get; set; }
        public string IdEmpresa { get; set; }
        public string IdOrganig { get; set; }

        public virtual Empresas Empresas { get; set; }
        public virtual Empresas IdEmpresaNavigation { get; set; }
        public virtual ICollection<NivOrg> NivOrgIdOrganigNavigation { get; set; }
        public virtual ICollection<NivOrg> NivOrgOrganig { get; set; }
    }
}
