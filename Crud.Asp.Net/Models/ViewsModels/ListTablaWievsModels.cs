using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud.Asp.Net.Models.ViewsModels
{
	public class ListTablaWievsModels
	{
        public int Id_person { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Correo { get; set; }
    }
}