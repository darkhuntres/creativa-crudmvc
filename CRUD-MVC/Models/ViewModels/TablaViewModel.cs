using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_MVC.Models.ViewModels
{
    public class TablaViewModel
    {
        //Id
        public int Id { get; set; }
        //Nombre
        [Required]
        [StringLength(40)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        //Apellido
        [Required]
        [StringLength(40)]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }
        //Dirección
        [Required]
        [StringLength(40)]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        //Fecha de Nacimiento
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha_Nacimiento { get; set; }

    }
}