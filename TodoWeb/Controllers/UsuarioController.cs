using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoWeb.Models;

namespace TodoWeb.Controllers
{
    public class UsuarioController : Controller
    {
        static List<Usuario> lista = new List<Usuario>();
        // GET: Usuario
        public ActionResult Index()
        {
            //lista.Add(new Usuario { UsuarioId = 1, Nome = "Fulano" });
            //lista.Add(new Usuario { UsuarioId = 2, Nome = "Ciclano" });
            //uma das formas de passar os dados
            //ViewBag.Usuarios = lista;

            //passar o modelo da interface
            return View(lista);
        }
        // GET: /usuario/create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            int id = int.Parse(form["UsuarioId"]);
            string nome = form["Nome"];

            lista.Add(new Usuario { UsuarioId = id, Nome = nome });

            return RedirectToAction("Index");
           // return View();
        }
    }
}