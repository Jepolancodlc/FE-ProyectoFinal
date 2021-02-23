using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API_Proyecto_Team1_AJV.Models
{
    public partial class Trabajadores
    {
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Cpostal { get; set; }
        public string Cuerpo { get; set; }
        public string Domicilio { get; set; }
        public string ECivil { get; set; }
        public string Email { get; set; }
        public string EsFamiliaNumerosa { get; set; }
        public string Escalera { get; set; }
        public DateTime? FAlta { get; set; }
        public DateTime? FBaja { get; set; }
        public DateTime? FNac { get; set; }
        public DateTime Gcrowver { get; set; }
        public string Grupo { get; set; }
        public int? HorasAnual { get; set; }
        public string HstSitAdmv { get; set; }
        public int Id { get; set; }
        public string IdCategoria { get; set; }
        public string IdEmpresa { get; set; }
        public int? IdHstSitAdmv { get; set; }
        public string IdNivel { get; set; }
        public string IdOrganig { get; set; }
        public string IdPais { get; set; }
        public string IdPaisNac { get; set; }
        public string IdPoblacion { get; set; }
        public string IdPoblacionNac { get; set; }
        public string IdProvincia { get; set; }
        public string IdProvinciaNac { get; set; }
        public string IdPuesto { get; set; }
        public string IdTSitAdmv { get; set; }
        public string IdTrabajador { get; set; }
        public string Minusv { get; set; }
        public string Nif { get; set; }
        public int NivOrgId { get; set; }
        public string Nombre { get; set; }
        public string Num { get; set; }
        public decimal? PJornadaCto { get; set; }
        public decimal? PJornadaTrab { get; set; }
        public decimal? POcupacion { get; set; }
        public decimal? PReducJornada { get; set; }
        public string Piso { get; set; }
        public string Puerta { get; set; }
        public string Residente { get; set; }
        public string Sexo { get; set; }
        public string Siglas { get; set; }
        public string SitAdmv { get; set; }
        public string TProvis { get; set; }
        public string TelefEmerg { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }

        public virtual Cuerpos CuerpoNavigation { get; set; }
        public virtual Grupos GrupoNavigation { get; set; }
        public virtual Categors IdCategoriaNavigation { get; set; }
        public virtual NivOrg IdNavigation { get; set; }
        public virtual Poblac IdP { get; set; }
        public virtual Poblac IdPNavigation { get; set; }
        public virtual Provincias IdProvinciaNacNavigation { get; set; }
        public virtual Provincias IdProvinciaNavigation { get; set; }
        public virtual NivOrg NivOrg { get; set; }
        public virtual Siglas SiglasNavigation { get; set; }
        public virtual SitAdmv SitAdmvNavigation { get; set; }
        public virtual TProvis TProvisNavigation { get; set; }
    }
}
