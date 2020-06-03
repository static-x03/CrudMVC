using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Crud.Asp.Net.Models.ViewsModels
{
	public class TablaViewsModels
	{
        public int Id_person { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }
        [Required]
        [Display(Name = "Edad")]
        public int Edad { get; set; }
        [Required]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Correo Electronico")]
        public string Correo { get; set; }
    }
}