using System;
using Microsoft.AspNetCore.Mvc;
using Desafio_MVC.DTO;
using Desafio_MVC.Models;
using Desafio_MVC.Data;
using System.Linq;

namespace Desafio_MVC.Controllers
{
    public class GftsController : Controller
    {
        private readonly ApplicationDbContext database;

        public GftsController(ApplicationDbContext database)
        {
            this.database = database;
        }
        [HttpPost]
        public IActionResult Salvar(GftDTO tempGft)
        {
            if(ModelState.IsValid)
            {
                Gft gft = new Gft();
                gft.Nome = tempGft.Nome;
                gft.Cep = tempGft.Cep;
                gft.Endereco = tempGft.Endereco;
                gft.Cidade = tempGft.Cidade;
                gft.Estado = tempGft.Estado;
                gft.Telefone = tempGft.Telefone;
                gft.Status = true;
                database.Gfts.Add(gft);
                database.SaveChanges();
                return RedirectToAction("Gfts","Wa");
            }
            else
            {
                return View("../Wa/NovaGft");
            }
        }

        [HttpPost]
        public IActionResult Atualizar(GftDTO tempGft)
        {
            if(ModelState.IsValid)
            {
                var gft = database.Gfts.First(g => g.Id == tempGft.Id);
                gft.Nome = tempGft.Nome;
                gft.Cep = tempGft.Cep;
                gft.Endereco = tempGft.Endereco;
                gft.Cidade = tempGft.Cidade;
                gft.Estado = tempGft.Estado;
                gft.Telefone = tempGft.Telefone;
                database.SaveChanges();
                return RedirectToAction("Gfts","Wa");
            }
            else
            {
                return View("../Wa/EditarGft");
            }
        }

        [HttpPost]
        public IActionResult Deletar(Int64 id)
        {
            if(id > 0)
            {
                var gft = database.Gfts.First(g => g.Id == id);
                gft.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("Gfts", "Wa");
        }
    }
}