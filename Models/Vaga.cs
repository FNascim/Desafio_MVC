using System;
using System.Collections.Generic;

namespace Desafio_MVC.Models
{
    public class Vaga
    {
        public Int64 Id { get; set; }
        public DateTime Abertura_Vaga { get; set; }
        public string Codigo_Vaga { get; set; }
        public string Descricao_Vaga { get; set; }
        public string Projeto { get; set; }
        public int Qtd_Vaga { get; set; }
        public bool Status {get; set; }
        public virtual ICollection<Vaga_Tecnologia> Vaga_Tecnologia {get; set; }
    }
}