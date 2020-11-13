using System.Linq;
using Desafio_MVC.Data;
using Desafio_MVC.DTO;
using Desafio_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desafio_MVC.Controllers
{
    public class Funcionario_TecnologiasController : Controller
    {
        private readonly ApplicationDbContext database;

        public Funcionario_TecnologiasController(ApplicationDbContext database)
        {
            this.database = database;
        }
        [HttpPost]
        public IActionResult Salvar(Funcionario_TecnologiaDTO tempFuncionario)
        {
            if(ModelState.IsValid)
            {
                Funcionario_Tecnologia funcionario_tecnologia = new Funcionario_Tecnologia();
                funcionario_tecnologia.Funcionario.Id = tempFuncionario.Funcionario_Id;
                funcionario_tecnologia.Tecnologia = database.Tecnologias.First(f => f.Id == tempFuncionario.Tecnologia_Id);
                database.Funcionario_Tecnologias.Add(funcionario_tecnologia);
                database.SaveChanges();
                return RedirectToAction("Funcionarios","Wa");
            }
            else
            {
                ViewBag.Funcionarios = database.Funcionarios.ToList();
                ViewBag.Tecnologias = database.Tecnologias.ToList();
                return View("../Wa/Funcionario_Tecnologias");
            }
        }
    }
}