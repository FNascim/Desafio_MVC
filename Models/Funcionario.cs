using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Desafio_MVC.DTO;

namespace Desafio_MVC.Models
{
    public class Funcionario
    {
        public Int64 Id { get; set; }
        public string Cargo { get; set; }
        public DateTime Inicio_Wa { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public DateTime Termino_Wa { get; set; }
        
        public Gft Gft {get; set;}
        public Vaga Vaga {get; set;}
        public bool Status {get; set; }

        public virtual ICollection<Funcionario_Tecnologia> Funcionario_Tecnologias {get; set; }

    }
}