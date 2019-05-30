using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

using MVC.Models;

namespace MVC.Controllers
{
    public class FacturasExController : Controller
    {
        //
        const int paginado = 5;
        int? page = 1;

        clientesDB clientesB = new clientesDB();

        // GET: /FacturasEx/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult crearF()
        {
            return View();
        }


        public JsonResult ListarClientes() 
        {
            return Json(clientesB.listadoClientes(),JsonRequestBehavior.AllowGet);
        }

        public JsonResult LisatarClientesXBusqueda(string idC) 
        {
            return Json(clientesB.ClientesXBusqueda(idC), JsonRequestBehavior.AllowGet);
        }

        public ActionResult listaC() 
        {
            var l = from oc in clientesB.listadoClientes() select oc;


            //int numpags = (page ?? 1);
            //return View(l.ToPagedList(numpags, paginado));
            return View(l);
        }

	}
}   