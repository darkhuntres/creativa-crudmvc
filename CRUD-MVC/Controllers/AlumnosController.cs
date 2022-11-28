using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_MVC.Models;
using CRUD_MVC.Models.ViewModels;

namespace CRUD_MVC.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {
            List<ListTablaViewModel> lst;
            using(pruebaEntities db=new pruebaEntities())
            {
                 lst = (from d in db.Alumnos
                          select new ListTablaViewModel
                          {
                              Id = d.Id,
                              Nombre = d.Nombre,
                              Apellido = d.Apellido,
                              Direccion = d.Direccion,
                              Fecha_Nacimiento = (DateTime)d.Fecha_Nacimiento
                          }).ToList();
            }
            return View(lst);
        }

        //INSERT
        public ActionResult Nuevo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(TablaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (pruebaEntities db = new pruebaEntities())
                    {
                        var oTabla = new Alumnos();
                        oTabla.Id = model.Id;
                        oTabla.Nombre = model.Nombre;
                        oTabla.Apellido= model.Apellido;
                        oTabla.Direccion= model.Direccion;
                        oTabla.Fecha_Nacimiento=model.Fecha_Nacimiento;

                        db.Alumnos.Add(oTabla);
                        db.SaveChanges();
                    }
                    return Redirect("~/Alumnos/");
                }
                 return View(model);
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //UPDATE
        public ActionResult Editar( int Id)
        {
            TablaViewModel model= new TablaViewModel();
            using (pruebaEntities db = new pruebaEntities())
            {
                var oTabla = db.Alumnos.Find(Id);
                model.Nombre=oTabla.Nombre;
                model.Apellido= oTabla.Apellido;
                model.Direccion= oTabla.Direccion;
                model.Fecha_Nacimiento = (DateTime)oTabla.Fecha_Nacimiento;
                model.Id=model.Id;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Editar(TablaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (pruebaEntities db = new pruebaEntities())
                    {
                        var oTabla = db.Alumnos.Find(model.Id);
                        oTabla.Nombre = model.Nombre;
                        oTabla.Apellido = model.Apellido;
                        oTabla.Direccion = model.Direccion;
                        oTabla.Fecha_Nacimiento = model.Fecha_Nacimiento;

                        db.Entry(oTabla).State=System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    return Redirect("~/Alumnos/");
                }
                return View(model);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //DELETE
        [HttpGet]
        public ActionResult Eliminar(int Id)
        {
            using (pruebaEntities db = new pruebaEntities())
            {
                var oTabla = db.Alumnos.Find(Id);
                db.Alumnos.Remove(oTabla);
                db.SaveChanges();
            }
            return Redirect("~/Alumnos/");
        }
    }
    
}