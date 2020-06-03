using Crud.Asp.Net.Models;
using Crud.Asp.Net.Models.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Jitbit.Utils;


namespace Crud.Asp.Net.Controllers
{
    public class PeoplesController : Controller
    {
       /// <summary>
       /// Metodo para cargar los listados de la base de datos
       /// </summary>
       /// <returns></returns>
        public ActionResult Index()
        {
            List<ListTablaWievsModels> lst;
            using(ConectionsDataBase dataBase = new ConectionsDataBase())
            {
                lst = (from d in dataBase.Peoples
                       select new ListTablaWievsModels
                       {
                           Id_person = d.Id_person,
                           Nombre = d.Nombre,
                           Apellido = d.Apellido,
                           Edad = d.Edad,
                           Sexo = d.Sexo,
                           Correo = d.Correo
                       }).ToList();
            }

            return View(lst);
        }
        /// <summary>
        /// Retorno de la vista
        /// </summary>
        /// <returns></returns>
        public ActionResult NuevoRegistro()
        {
            return View();
        }
        /// <summary>
        /// Metodo para Crear un nuevo registro e ingresar datos en la tabla
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult NuevoRegistro(TablaViewsModels Model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using(ConectionsDataBase dataBase = new ConectionsDataBase())
                    {
                        var persona = new Peoples();
                        persona.Nombre = Model.Nombre;
                        persona.Apellido = Model.Apellido;
                        persona.Edad = Model.Edad;
                        persona.Sexo = Model.Sexo;
                        persona.Correo = Model.Correo;

                        dataBase.Peoples.Add(persona);
                        dataBase.SaveChanges();

                    }
                    return Redirect("/");
                }
                return View(Model);



            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Retorno de por parametro de un registro
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ActionResult ActualizarPersona(int Id)
        {
            TablaViewsModels model = new TablaViewsModels();
            using(ConectionsDataBase dataBase = new ConectionsDataBase())
            {
                var tabla = dataBase.Peoples.Find(Id);
                model.Id_person = tabla.Id_person;
                model.Nombre = tabla.Nombre;
                model.Apellido = tabla.Apellido;
                model.Edad = tabla.Edad;
                model.Sexo = tabla.Sexo;
                model.Correo = tabla.Correo;

            }
            return View(model);
        }
        /// <summary>
        /// Metodo para Actualizar un registro
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ActualizarPersona(TablaViewsModels Model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (ConectionsDataBase dataBase = new ConectionsDataBase())
                    {
                        var tabla = dataBase.Peoples.Find(Model.Id_person);
                        tabla.Nombre = Model.Nombre;
                        tabla.Apellido = Model.Apellido;
                        tabla.Edad = Model.Edad;
                        tabla.Sexo = Model.Sexo;
                        tabla.Correo = Model.Correo;

                        dataBase.Entry(tabla).State = EntityState.Modified;
                        dataBase.SaveChanges();

                    }
                    return Redirect("/");
                }
                return View(Model);



            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Metodo para Remover un registro por parametro 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult BorrarPersona(int Id)
        {
          
            using (ConectionsDataBase dataBase = new ConectionsDataBase())
            {
                var tabla = dataBase.Peoples.Find(Id);
                dataBase.Peoples.Remove(tabla);
                dataBase.SaveChanges();

            }
            return Redirect("/");
        }
        /// <summary>
        /// Metodo para Cargar el detalle de una persona
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult DetallePersona(int Id)
        {
            TablaViewsModels model = new TablaViewsModels();
            using (ConectionsDataBase dataBase = new ConectionsDataBase())
            {
                var tabla = dataBase.Peoples.Find(Id);
                model.Id_person = tabla.Id_person;
                model.Nombre = tabla.Nombre;
                model.Apellido = tabla.Apellido;
                model.Edad = tabla.Edad;
                model.Sexo = tabla.Sexo;
                model.Correo = tabla.Correo;

            }
            return View(model);
        }
        /// <summary>
        /// Metodo para Exportar a Excel
        /// </summary>
        /// <returns></returns>
        public FileResult DescargarCsv()
        {
            ConectionsDataBase dataBase = new ConectionsDataBase();
            var fileName = "Listado_personas.csv";
            var personas = dataBase.Peoples.ToList();
            CsvExport Csv = new CsvExport();

            foreach (var persona in personas)
            {
                Csv.AddRow();
                Csv["ID"] = persona.Id_person;
                Csv["Nombre"] = persona.Nombre;
                Csv["Apellido"] = persona.Apellido;
                Csv["Edad"] = persona.Edad;
                Csv["Sexo"] = persona.Sexo;
                Csv["Correo"] = persona.Correo;

            }

            return File(Csv.ExportToBytes(), "application/csv;charset=utf-8", fileName);
        }
    }
}