using System;
using System.Collections.Generic;

namespace Desafio_MVC.Models
{
    public class Tecnologia
    {
        public Int64 Id { get; set; }
        public string Nome { get; set; }
        public bool Status {get; set; }
        public virtual ICollection<Funcionario_Tecnologia> Funcionario_Tecnologias {get; set; }
    }
}