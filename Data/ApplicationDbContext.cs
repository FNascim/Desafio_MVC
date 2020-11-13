using System;
using System.Collections.Generic;
using System.Text;
using Desafio_MVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Desafio_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Gft> Gfts {get; set; }
        public DbSet<Vaga> Vagas {get; set; }
        public DbSet<Funcionario> Funcionarios {get; set; }
        public DbSet<Tecnologia> Tecnologias {get; set; }
        public DbSet<Vaga_Tecnologia> Vaga_Tecnologias {get; set; }
        public DbSet<Funcionario_Tecnologia> Funcionario_Tecnologias {get; set; }

        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Funcionario_Tecnologia>().HasKey(f => new{f.Funcionario_Id, f.Tecnologia_Id});
            builder.Entity<Vaga_Tecnologia>().HasKey( v => new{v.Vaga_Id, v.Tecnologia_Id});

            builder.Entity<Gft>().HasData(

              new Gft
              {
                Id = 1,
                Cep = "99999999",
                Endereco = "Avenida Rio negro",
                Cidade = "Barueri",
                Estado = "SP",
                Nome = "gft-barueri",
                Telefone = "1199999999",
                Status = true
              }

              
          );

          
          builder.Entity<Gft>().HasData(

              new Gft
              {
                Id = 2,
                Cep = "888888888",
                Endereco = "Avenida 1",
                Cidade = "Curitiba",
                Estado = "PR",
                Nome = "gft-curitiba",
                Telefone = "4188888888",
                Status = true
              }

              
          );

          builder.Entity<Gft>().HasData(
              new Gft
              {
                Id = 3,
                Cep = "888888811",
                Endereco = "Avenida 2",
                Cidade = "Sorocaba",
                Estado = "SP",
                Nome = "gft-Sorocaba",
                Telefone = "1188887777",
                Status = true
              }

              
          );

          builder.Entity<Gft>().HasData(
              new Gft
              {
                Id = 4,
                Cep = "77777777",
                Endereco = "Avenida 3",
                Cidade = "São Paulo",
                Estado = "PR",
                Nome = "gft-são paulo",
                Telefone = "1177777777",
                Status = true
              }

              
          );

          builder.Entity<Gft>().HasData(
              new Gft
              {
                Id = 5,
                Cep = "66666666",
                Endereco = "Avenida 4",
                Cidade = "Manaus",
                Estado = "AM",
                Nome = "gft-manaus",
                Telefone = "9188775566",
                Status = true
              }

              
          );

          builder.Entity<Tecnologia>().HasData(
              new Tecnologia
              {
                  Id = 1,
                  Nome = "Asp.Net",
                  Status = true
              }
          );

          builder.Entity<Tecnologia>().HasData(
              new Tecnologia
              {
                  Id = 2,
                  Nome = "Java",
                  Status = true
              }
          );

          builder.Entity<Tecnologia>().HasData(
              new Tecnologia
              {
                  Id = 3,
                  Nome = "Angular",
                  Status = true
              }
          );

          builder.Entity<Tecnologia>().HasData(
              new Tecnologia
              {
                  Id = 4,
                  Nome = "Python",
                  Status = true
              }
          );

          builder.Entity<Tecnologia>().HasData(
              new Tecnologia
              {
                  Id = 5,
                  Nome = "JavaScript",
                  Status = true
              }
          );

          builder.Entity<Vaga>().HasData(
              new Vaga
              {
                  Id = 1,
                  Abertura_Vaga = System.DateTime.Today,
                  Projeto = "Itau",
                  Codigo_Vaga = "#Itau9521",
                  Descricao_Vaga = "Desenvolvimento Java",
                  Qtd_Vaga = 5,
                  Status = true
              }
          );

          builder.Entity<Vaga>().HasData(
              new Vaga
              {
                  Id = 2,
                  Abertura_Vaga = System.DateTime.Today,
                  Projeto = "Santander",
                  Codigo_Vaga = "#Santander8566",
                  Descricao_Vaga = "Desenvolvimento .Net",
                  Qtd_Vaga = 1,
                  Status = true
              }
          );

          builder.Entity<Vaga>().HasData(
              new Vaga
              {
                  Id = 3,
                  Abertura_Vaga = System.DateTime.Today,
                  Projeto = "Sulamerica",
                  Codigo_Vaga = "#Sulamerica4511",
                  Descricao_Vaga = "JavaScript",
                  Qtd_Vaga = 2,
                  Status = true
              }
          );

          builder.Entity<Vaga>().HasData(
              new Vaga
              {
                  Id = 4,
                  Abertura_Vaga = System.DateTime.Today,
                  Projeto = "Itau",
                  Codigo_Vaga = "#Itau3546",
                  Descricao_Vaga = "Angular",
                  Qtd_Vaga = 9,
                  Status = true
              }
          );

          builder.Entity<Vaga>().HasData(
              new Vaga
              {
                  Id = 5,
                  Abertura_Vaga = System.DateTime.Today,
                  Projeto = "Original",
                  Codigo_Vaga = "#Original7624",
                  Descricao_Vaga = "Desenvolvimento Java",
                  Qtd_Vaga = 2,
                  Status = true
              }
          );

         

          builder.Entity<Funcionario>().HasData(
              new Funcionario
              {
                  Id = 1,
                  Nome = "Marcia",
                  Cargo = "Desenvolvedor Java",
                  Matricula = "456324",
                  Inicio_Wa = System.DateTime.Today,
                  Termino_Wa = new System.DateTime(2020,12,15),
                  Status = true
              }
          );

          builder.Entity<Funcionario>().HasData(
              new Funcionario
              {
                  Id = 2,
                  Nome = "José",
                  Cargo = "Desenvolvedor .Net",
                  Matricula = "123456",
                  Inicio_Wa = System.DateTime.Today,
                  Termino_Wa = new System.DateTime(2020,12,28),
                  Status = true
              }
          );
          builder.Entity<Funcionario>().HasData(
              new Funcionario
              {
                  Id = 3,
                  Nome = "João",
                  Cargo = "Desenvolvedor .Net",
                  Matricula = "159753",
                  Inicio_Wa = System.DateTime.Today,
                  Termino_Wa = new System.DateTime(2020,12,12),
                  Status = true
              }
          );

          builder.Entity<Funcionario>().HasData(
              new Funcionario
              {
                  Id = 4,
                  Nome = "Maria",
                  Cargo = "Desenvolvedor FrontEnd",
                  Matricula = "564987",
                  Inicio_Wa = System.DateTime.Today,
                  Termino_Wa = new System.DateTime(2020,12,15),
                  Status = true
              }
          );
          
          builder.Entity<Funcionario>().HasData(
              new Funcionario
              {
                  Id = 5,
                  Nome = "Julia",
                  Cargo = "Desenvolvedor Backend",
                  Matricula = "951357",
                  Inicio_Wa = System.DateTime.Today,
                  Termino_Wa = new System.DateTime(2020,12,21),
                  Status = true
              }
          );

          builder.Entity<Funcionario_Tecnologia>().HasData(
              new Funcionario_Tecnologia
              {
                  Funcionario_Id = 1,
                  Tecnologia_Id = 5
              }
          );

          builder.Entity<Funcionario_Tecnologia>().HasData(
              new Funcionario_Tecnologia
              {
                  Funcionario_Id = 2,
                  Tecnologia_Id = 1
              }
          );

          builder.Entity<Funcionario_Tecnologia>().HasData(
              new Funcionario_Tecnologia
              {
                  Funcionario_Id = 3,
                  Tecnologia_Id = 3
              }
          );

          builder.Entity<Funcionario_Tecnologia>().HasData(
              new Funcionario_Tecnologia
              {
                  Funcionario_Id = 4,
                  Tecnologia_Id = 2
              }
          );

          builder.Entity<Funcionario_Tecnologia>().HasData(
              new Funcionario_Tecnologia
              {
                  Funcionario_Id = 5,
                  Tecnologia_Id = 4
              }
          );
           builder.Entity<Vaga_Tecnologia>().HasData(
              new Vaga_Tecnologia
              {
                  Vaga_Id = 1,
                  Tecnologia_Id = 5
              }
          );

          builder.Entity<Vaga_Tecnologia>().HasData(
              new Vaga_Tecnologia
              {
                  Vaga_Id = 2,
                  Tecnologia_Id = 1
              }
          );

          builder.Entity<Vaga_Tecnologia>().HasData(
              new Vaga_Tecnologia
              {
                  Vaga_Id = 3,
                  Tecnologia_Id = 3
              }
          );

          builder.Entity<Vaga_Tecnologia>().HasData(
              new Vaga_Tecnologia
              {
                  Vaga_Id = 4,
                  Tecnologia_Id = 2
              }
          );

          builder.Entity<Vaga_Tecnologia>().HasData(
              new Vaga_Tecnologia
              {
                  Vaga_Id = 5,
                  Tecnologia_Id = 4
              }
          );
        }
     
    }
}
