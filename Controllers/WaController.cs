using System;
using System.Linq;
using Desafio_MVC.Data;
using Desafio_MVC.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Desafio_MVC.Controllers
{
    public class WaController : Controller
    {
        private readonly ApplicationDbContext database;

        public WaController(ApplicationDbContext database)
        {
            this.database = database;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Gfts()
        {
            var gfts = database.Gfts.Where(g => g.Status == true).ToList();
            return View(gfts);
        }

        public IActionResult NovaGft()
        {
            return View();
        }
        public IActionResult EditarGft(Int64 id)
        {
            var gft = database.Gfts.First(g => g.Id == id);
            GftDTO gftView = new GftDTO();
            gftView.Id = gft.Id;
            gftView.Nome = gft.Nome;
            gftView.Cep = gft.Cep;
            gftView.Endereco = gft.Endereco;
            gftView.Cidade = gft.Cidade;
            gftView.Estado = gft.Estado;
            gftView.Telefone = gft.Telefone;
            return View(gftView);
        }

        public IActionResult Vagas()
        {
            var vagas = database.Vagas.Include(v => v.Vaga_Tecnologia).ThenInclude(v => v.Tecnologia).Where(v => v.Status == true).ToList();
            return View(vagas);
        }
        public IActionResult NovaVaga()
        {
            return View();
        }
        public IActionResult EditarVaga(Int64 id)
        {
            var vaga = database.Vagas.First(v => v.Id == id);
            VagaDTO vagaView = new VagaDTO();
            vagaView.Id = vaga.Id;
            vagaView.Abertura_Vaga = vaga.Abertura_Vaga;
            vagaView.Codigo_Vaga = vaga.Codigo_Vaga;
            vagaView.Descricao_Vaga = vaga.Descricao_Vaga;
            vagaView.Projeto = vaga.Projeto;
            vagaView.Qtd_Vaga = vaga.Qtd_Vaga;
            return View(vagaView);
        }

        public IActionResult Tecnologias()
        {
            var tecnologias = database.Tecnologias.Where(t => t.Status == true).ToList();
            return View(tecnologias);
        }
        public IActionResult NovaTecnologia()
        {
            return View();
        }

        public IActionResult EditarTecnologia(Int64 id)
        {
            var tecnologia = database.Tecnologias.First(t => t.Id == id);
            TecnologiaDTO tecnologiaView = new TecnologiaDTO();
            tecnologiaView.Id = tecnologia.Id;
            tecnologiaView.Nome = tecnologia.Nome;
            return View(tecnologiaView);
        }

        public IActionResult Funcionarios()
        {
            var funcionarios = database.Funcionarios.Include(f => f.Gft).Include(f => f.Funcionario_Tecnologias).ThenInclude(f => f.Tecnologia).Where(f => f.Status == true && f.Vaga == null).ToList();
            return View(funcionarios);
        }
        public IActionResult NovoFuncionario()
        {
            ViewBag.Gfts = database.Gfts.ToList();
            return View();
        }

        public IActionResult EditarFuncionario(Int64 id)
        {
            var funcionario = database.Funcionarios.Include(f => f.Gft).First(t => t.Id == id);
            FuncionarioDTO funcionarioView = new FuncionarioDTO();
            funcionarioView.Id = funcionario.Id;
            funcionarioView.Nome = funcionario.Nome;
            funcionarioView.Matricula = funcionario.Matricula;
            funcionarioView.Cargo = funcionario.Cargo;
            funcionarioView.Gft_Id = funcionario.Gft.Id;
            funcionarioView.Inicio_Wa = funcionario.Inicio_Wa;
            ViewBag.Gfts = database.Gfts.ToList();
            return View(funcionarioView);
        }

        public IActionResult Funcionario_Tecnologias(Int64 id)
        {
            var funcionario_Tecnologia = database.Funcionario_Tecnologias.Include( f => f.Funcionario).Include(f => f.Tecnologia);
            return View(funcionario_Tecnologia.ToList());
        }


        public IActionResult Historico()
        {
            var funcionarios = database.Funcionarios.Include(f => f.Gft).Where(f => f.Status == true).Where(f => f.Vaga != null).ToList();
            return View(funcionarios);
        }
    }
}