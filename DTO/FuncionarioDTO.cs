using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Desafio_MVC.Models;

namespace Desafio_MVC.DTO
{
    public class FuncionarioDTO
    {
        [Required]
        public Int64 Id { get; set; }
        [Required(ErrorMessage="Cargo obrigatório")]
        [StringLength(100,ErrorMessage="Nome do cargo muito longo")]
        [MinLength(2,ErrorMessage="Nome do cargo muito curto")]
        public string Cargo { get; set; }
        [Required(ErrorMessage="Data de inicio obrigatória")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime Inicio_Wa { get; set; }
        [Required(ErrorMessage="Numero de matricula obrigatório")]
        [StringLength(100,ErrorMessage="Numero de matricula muito longo")]
        [MinLength(2,ErrorMessage="Numero de matricula muito curto")]
        public string Matricula { get; set; }
        [Required(ErrorMessage="Nome obrigatório")]
        [StringLength(100,ErrorMessage="Nome muito longo")]
        [MinLength(2,ErrorMessage="Nome muito curto")]
        public string Nome { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime Termino_Wa { get; set; }
        [Required(ErrorMessage="Local obrigatório")]
        public Int64 Gft_Id {get; set;}
        public Int64 Vaga_Id {get; set;}
        public virtual ICollection<Funcionario_TecnologiaDTO> Funcionario_Tecnologias {get; set; }


    }
}