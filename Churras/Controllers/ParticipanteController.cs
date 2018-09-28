using ChurrasTrinca.Models;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace ChurrasTrinca.Controllers
{
    public class ParticipanteController : Controller
    {
        private readonly ChurrasDB churrasDB;
        private readonly ParticipanteDB partDB;

        public ParticipanteController()
        {
            churrasDB = new ChurrasDB(new ChurrasEntities());
            partDB = new ParticipanteDB();
        }

        // GET: Participante
        public ActionResult Index()
        {
            return View();
        }

        // GET: Participante/Details/5
        public ActionResult Details(int id)
        {
            var model = new List<ParticipanteListModel>();

            var churras = churrasDB.BuscarChurras(id);
            var participantes = partDB.ListarParticipantesChurras(id);

            model.AddRange(
                from item in participantes
                select new ParticipanteListModel()
                    {
                        ComBebida = (item.ComBebida == true) ? "Sim" : "Não",
                        Data = churras.Data,
                        Nome = item.Nome,
                        Motivo = churras.Motivo,
                        Pago = item.Pago ?? false,
                        Valor = item.Valor ?? 0
                    }
                );

            return View(model);
        }

        // GET: Participante/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(int idChurras)
        {
            return View();
        }


        // POST: Participante/Create
        [HttpPost]
        public ActionResult Create(ParticipanteCreateModel model)
        {
            try
            {

                return RedirectToAction("Index", "Churras");
            }
            catch
            {
                return View();
            }
        }

        // GET: Participante/Edit/5
        public ActionResult Edit(int id)
        {
            var p = new ParticipanteCreateModel();

            var churras = churrasDB.BuscarChurras(id);

            p.Valor = churras.ValorComBebida ?? 0;
            p.IdChurras = id;
            p.ComBebida = true;

            return View(p);
        }

        // POST: Participante/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ParticipanteCreateModel model)
        {
            try
            {
                partDB.IncluirParticipante(
                  model.IdChurras,
                  model.Nome,
                  model.Valor,
                  model.Pago,
                  model.ComBebida);

                return RedirectToAction("Index", "Churras");
            }
            catch
            {
                return View();
            }
        }

        // GET: Participante/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Participante/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [WebMethod]
        public string GetValue(bool bebis, int idChurras)
        {
            var churras = churrasDB.BuscarChurras(idChurras);

            if (bebis)
                return Math.Round((decimal)churras.ValorComBebida, 2).ToString();
            else
                return Math.Round((decimal)churras.ValorSemBebida, 2).ToString();
        }

    }
}
