using Desafio_MVC.Data;
using Desafio_MVC.DTO;
using Desafio_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Desafio_MVC.Controllers
{
    public class VagasController : Controller
    {
        private readonly ApplicationDbContext database;

        public VagasController(ApplicationDbContext database)
        {
            this.database = database;
        }
        [HttpPost]
        public IActionResult Salvar(VagaDTO tempVaga)
        {
            if(ModelState.IsValid)
            {
                Vaga vaga = new Vaga();
                vaga.Abertura_Vaga = tempVaga.Abertura_Vaga;
                vaga.Descricao_Vaga = tempVaga.Descricao_Vaga;
                vaga.Projeto = tempVaga.Projeto;
                vaga.Qtd_Vaga = tempVaga.Qtd_Vaga;
                Random random = new Random();
                vaga.Codigo_Vaga = "#"+tempVaga.Projeto+random.Next(9999);
                vaga.Status = true;
                database.Vagas.Add(vaga);
                database.SaveChanges();
                return RedirectToAction("Vagas","Wa");
            }
            else
            {
                return View("../Wa/NovaVaga");
            }
        }

        [HttpPost]
        public IActionResult Atualizar(VagaDTO tempVaga)
        {
            if(ModelState.IsValid)
            {
                var vaga = database.Vagas.First(v => v.Id == tempVaga.Id);
                vaga.Abertura_Vaga = tempVaga.Abertura_Vaga;
                vaga.Codigo_Vaga = tempVaga.Codigo_Vaga;
                vaga.Descricao_Vaga = tempVaga.Descricao_Vaga;
                vaga.Projeto = tempVaga.Projeto;
                vaga.Qtd_Vaga = tempVaga.Qtd_Vaga;
                database.SaveChanges();
                return RedirectToAction("Vagas","Wa");
            }
            else
            {
                return View("../Wa/NovaVaga");
            }
        }

        [HttpPost]
        public IActionResult Deletar(Int64 id)
        {
            if(id > 0)
            {
                var vaga = database.Vagas.First(v => v.Id == id);
                vaga.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("Vagas","Wa");
        }    
    }
}