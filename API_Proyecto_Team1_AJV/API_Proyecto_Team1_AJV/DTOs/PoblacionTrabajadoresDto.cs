using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Proyecto_Team1_AJV.DTOs
{
    public class PoblacionTrabajadoresDto
    {
        /*
         *  DTO para recoger en el front el nombre de las poblaciones y provincias de cada trabajador para los gráficos.
         */

        // ATRIBUTOS, GETTERS Y SETTERS
        public string D_Poblacion { get; set; }
        public int Coincidencias { get; set; }

    }
}
