using Clinica.Context;
using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Clinica.Controllers
{
    public class ConsultasController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Consultas
        public ActionResult Index()
        {
            return View(context.Consultas.OrderBy(c => c.Id));
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            ViewBag.ExameId = new SelectList(context.Exames.OrderBy(b => b.Id),
            "ExameId", "Descricao");
            return View();
        }
        // POST: Produtos/Create
        [HttpPost]
        public ActionResult Create(Consulta consulta)
        {
            try
            {
                // TODO: Add insert logic here
                context.Exames.Add(consulta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(consulta);
            }
        }

        // GET: Consultas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consulta consulta = context.Consultas.Find(id);
            if (consulta == null)
            {
                return HttpNotFound();
            }
            return View(consulta);
        }
        // POST: Consultas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Consulta consulta)
        {
            if (ModelState.IsValid)
            {
                context.Entry(consulta).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(consulta);
        }

        // GET: Consultas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consulta consulta = context.Consultas.Find(id);
            if (consulta == null)
            {
                return HttpNotFound();
            }
            return View(consulta);
        }

        // GET: Consultas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consulta consulta = context.Consultas.Find(id);
            if (consulta == null)
            {
                return HttpNotFound();
            }
            return View(consulta);
        }
        // POST: Consultas/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            Consulta consulta = context.Consultas.Find(id);
            context.Consultas.Remove(consulta);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}