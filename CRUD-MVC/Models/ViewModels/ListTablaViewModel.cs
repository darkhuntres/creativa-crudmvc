using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_MVC.Models.ViewModels
{
    public class ListTablaViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }

    }
}