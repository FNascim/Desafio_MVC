using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Desafio_MVC.DTO
{
    public class TecnologiaDTO
    {
        [Required]
        public Int64 Id { get; set; }
        [Required(ErrorMessage="Nome obrigatório")]
        [StringLength(100,ErrorMessage="Nome muito longo")]
        public string Nome { get; set; }
        public virtual ICollection<Funcionario_TecnologiaDTO> Funcionario_Tecnologias {get; set; }
    }
}