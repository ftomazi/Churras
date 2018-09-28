using ChurrasTrinca.Models;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChurrasTrinca.Controllers
{
    public class HomeController : Controller
    {
        private readonly ControlDB controlDB;

        public HomeController()
        {
            controlDB = new ControlDB(new ChurrasEntities());
        }

            public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ControlList()
        {
            var controls = new List<ControleTemperaturaModel>();

            var dados = controlDB.ListarTemperaturas();

            controls.AddRange(
                from c in dados
                select new ControleTemperaturaModel()
                {
                    Id = c.Id,
                    Data = c.Data,
                    Dados = c.Dados,
                    IdSsensor = c.IdSensor,
                    Temperatura = c.Temperatura ?? 0,
                    Tensao = c.Tensao ?? 0
                });
            return View(controls);
        }

    }
}