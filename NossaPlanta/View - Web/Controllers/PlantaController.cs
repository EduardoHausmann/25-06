using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View___Web.Controllers
{
    public class PlantaController : Controller
    {
        PlantaRepositorio repository = new PlantaRepositorio();

        public ActionResult Index()
        {
            List<Planta> plantas = repository.ObterTodos(null);

            ViewBag.Plantas = plantas;

            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Store(string nome, bool carnivora, decimal altura, decimal peso)
        {
            Planta planta = new Planta();
            planta.Nome = nome;
            planta.Altura = altura;
            planta.Peso = peso;
            planta.Carnivora = carnivora;
            int id = repository.Inserir(planta);

            return RedirectToAction("Index");
        }

        public ActionResult Apagar(int id)
        {
            repository.Apagar(id);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            Planta planta = repository.ObterPeloId(id);

            ViewBag.Planta = planta;

            return View();
        }

        public ActionResult Update(int id, string nome, bool carnivora, decimal altura, decimal peso)
        {
            Planta planta = new Planta();
            planta.Id = id;
            planta.Nome = nome;
            planta.Altura = altura;
            planta.Peso = peso;
            planta.Carnivora = carnivora;
            
            bool alterou = repository.Alterar(planta);
            return RedirectToAction("Index");
        }
    }
}