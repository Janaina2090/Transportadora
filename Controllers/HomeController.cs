using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private DbTransportadora _dbTransportadora = new DbTransportadora();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Aereo()
        {
            return View();
        }

        public ActionResult Containers()
        {
            return View();
        }

        public ActionResult Refrigerado()
        {
            return View();
        }

        public ActionResult Dedicado()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contato(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _dbTransportadora.Contato.Add(contato);
                _dbTransportadora.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(contato);

        }

        [HttpGet]
        public ActionResult Cotacao()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cotacao(Cotacao cotacao)
        {
            if (ModelState.IsValid)
            {
                _dbTransportadora.Cotacao.Add(cotacao);
                _dbTransportadora.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(cotacao);

        }

    }
}