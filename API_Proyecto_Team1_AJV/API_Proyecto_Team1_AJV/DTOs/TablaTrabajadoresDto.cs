using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Proyecto_Team1_AJV.DTOs
{
    public class TablaTrabajadoresDto
    {
        /*
         *  DTO Para recoger los campos de la BD que se tengan que printar en la tabla del FRONT
         */

        // ATRIBUTOS, GETTERS Y SETTERS
        public int Id_Trabajador { get; set; }
        public string FotoUrl { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Empresa { get; set; }
        public string Telefono { get; set; }
        public string Grupo { get; set; }
        public string Cuerpo { get; set; }
        public string Categoria { get; set; }
        public string TProvis { get; set; }
        public string SitAdmin { get; set; }
    }
}
