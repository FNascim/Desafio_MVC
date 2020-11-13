using System;
using System.Linq;
using Desafio_MVC.Data;
using Desafio_MVC.DTO;
using Desafio_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desafio_MVC.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly ApplicationDbContext database;

        public FuncionariosController(ApplicationDbContext database)
        {
            this.database = database;
        }
        [HttpPost]
        public IActionResult Salvar(FuncionarioDTO tempFuncionario)
        {
            if(ModelState.IsValid)
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Nome = tempFuncionario.Nome;
                funcionario.Cargo = tempFuncionario.Cargo;
                funcionario.Matricula = tempFuncionario.Matricula;
                funcionario.Inicio_Wa = tempFuncionario.Inicio_Wa;
                funcionario.Termino_Wa = tempFuncionario.Termino_Wa;
                funcionario.Gft = database.Gfts.First(gft => gft.Id == tempFuncionario.Gft_Id);
                funcionario.Status = true;
                database.Funcionarios.Add(funcionario);
                database.SaveChanges();
                return RedirectToAction("Funcionarios","Wa");
            }
            else
            {
                ViewBag.Gfts = database.Gfts.ToList();
                ViewBag.Vagas = database.Vagas.ToList();
                return View("../Wa/NovoFuncionario");
            }
        }

        [HttpPost]
        public IActionResult Atualizar(FuncionarioDTO tempFuncionario)
        {
            if(ModelState.IsValid)
            {
                var funcionario = database.Funcionarios.First(f => f.Id == tempFuncionario.Id);
                funcionario.Nome = tempFuncionario.Nome;
                funcionario.Cargo = tempFuncionario.Cargo;
                funcionario.Matricula = tempFuncionario.Matricula;
                funcionario.Inicio_Wa = tempFuncionario.Inicio_Wa;
                funcionario.Gft = database.Gfts.First(gft => gft.Id == tempFuncionario.Gft_Id);
                funcionario.Vaga = database.Vagas.First(v => v.Id == tempFuncionario.Vaga_Id);
                database.SaveChanges();
                return RedirectToAction("Funcionarios","Wa");
            }
            else
            {
                ViewBag.Gfts = database.Gfts.ToList();
                ViewBag.Vagas = database.Vagas.ToList();
                return View("../Wa/NovoFuncionario");
            }
        }

        [HttpPost]
        public IActionResult Deletar(Int64 id)
        {
            if(id > 0)
            {
                var funcionario = database.Funcionarios.First(f => f.Id == id);
                funcionario.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("Funcionarios","Wa");
        }
    }
}