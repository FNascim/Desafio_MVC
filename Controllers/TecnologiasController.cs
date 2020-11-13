using System;
using System.Linq;
using Desafio_MVC.Data;
using Desafio_MVC.DTO;
using Desafio_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desafio_MVC.Controllers
{
    public class TecnologiasController : Controller
    {
        private readonly ApplicationDbContext database;

        public TecnologiasController(ApplicationDbContext database)
        {
            this.database = database;
        }
        [HttpPost]
        public IActionResult Salvar(TecnologiaDTO tempTecnologia)
        {
            if(ModelState.IsValid)
            {
                Tecnologia tecnologia = new Tecnologia();
                tecnologia.Nome = tempTecnologia.Nome;
                tecnologia.Status = true;
                database.Tecnologias.Add(tecnologia);
                database.SaveChanges();
                return RedirectToAction("Tecnologias","Wa");
            }
            else
            {
                return View("../Wa/NovaTecnologia");
            }
        }

        [HttpPost]
        public IActionResult Atualizar(TecnologiaDTO tempTecnologia)
        {
            if(ModelState.IsValid)
            {
                var tecnologia = database.Tecnologias.First(t => t.Id == tempTecnologia.Id);
                tecnologia.Nome = tempTecnologia.Nome;
                database.SaveChanges();
                return RedirectToAction("Tecnologias","Wa");
            }
            else
            {
                return View("../Wa/NovaTecnologia");
            }
        }   

        [HttpPost]
        public IActionResult Deletar(Int64 id)
        {
            if(id > 0)
            {
                var tecnologia = database.Tecnologias.First(t => t.Id == id);
                tecnologia.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("Tecnologias","Wa");
        }
    }
}