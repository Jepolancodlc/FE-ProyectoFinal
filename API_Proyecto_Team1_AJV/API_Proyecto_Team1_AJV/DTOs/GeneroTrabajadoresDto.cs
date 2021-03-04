using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Proyecto_Team1_AJV.DTOs
{
    public class GeneroTrabajadoresDto
    {
        /*
         *  DTO Para recoger la cantidad de Hombres y Mujeres para las gráficas
         */

        // ATRIBUTOS, GETTERS Y SETTERS
        public string Sexo { get; set; }
        public int Cantidad { get; set; }

    }
}
