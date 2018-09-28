using ChurrasTrinca.Models;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChurrasTrinca.Controllers
{
    public class ChurrasController : Controller
    {
        private readonly ChurrasDB churrasDB;
        private readonly ParticipanteDB partDB;

        public ChurrasController()
        {
            churrasDB = new ChurrasDB(new ChurrasEntities());
            partDB = new ParticipanteDB();
        }

        // GET: Churras
        public ActionResult Index()
        {
            var churras = new List<ChurrasListModel>();

            var dados = churrasDB.ListarChurras();

            churras.AddRange(
                from c in dados
                select new ChurrasListModel()
                    {
                        Id = c.Id,
                        Data = c.Data,
                        Descricao = c.Motivo,
                        NumeroParticipantes = churrasDB.Participantes(c.Id),
                        TotalArrecadado = churrasDB.TotalArrecadado(c.Id)
                    });
            return View(churras);
        }

        // GET: Churras/Details/5
        public ActionResult Details(int id)
        {
            var model = new ChurrasDetailsModel();

            var churras = churrasDB.BuscarChurras(id);
            var part = partDB.ListarParticipantesChurras(id);

            model.Id = churras.Id;
            model.Motivo = churras.Motivo;
            model.Observacao = churras.Observacao;
            model.Data = churras.Data;
            model.ValorBebida = churras.ValorComBebida ?? 0;
            model.ValorSemBebida = churras.ValorSemBebida ?? 0;

            model.Participantes = churrasDB.Participantes(id);         
            model.Bebem = churrasDB.Bebuns(id);
            model.NaoBebem = churrasDB.NaoBebuns(id);
            model.ValorArrecadado = churrasDB.TotalArrecadado(id);
            model.ValorPago = churrasDB.ValorPago(id);
            
            return View(model);
        }

        // GET: Churras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Churras/Create
        [HttpPost]
        public ActionResult Create(ChurrasCreateModel model)
        {
            try
            {

                churrasDB.IncluirChurras(
                    model.Data,
                    model.Motivo,
                    model.Observacao,
                    model.ValorBebida,
                    model.ValorSemBebida
                    );

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Churras/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Churras/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Add(int id)
        {
            return RedirectToAction("Edit/"+ id, "Participante");
        }

        public ActionResult ListaParticipante(int id)
        {
            return RedirectToAction("Details/"+ id, "Participante");
        }

        // GET: Churras/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Churras/Delete/5
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
    }
}
