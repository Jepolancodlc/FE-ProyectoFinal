using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FRONT_Proyecto_Team1_AJV.Controllers
{
    public class ContainerController : Controller
    {
        public IActionResult Graph()
        {
            return View();
        } 
        public IActionResult Tabla()
        {
            return View();
        }
    }
}
