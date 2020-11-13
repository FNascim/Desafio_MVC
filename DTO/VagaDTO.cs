using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Desafio_MVC.Models;

namespace Desafio_MVC.DTO
{
    public class VagaDTO
    {
        [Required]
        public Int64 Id { get; set; }
        [Required(ErrorMessage="Data de abertura obrigatória")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime Abertura_Vaga { get; set; }
        public string Codigo_Vaga { get; set; }
        [Required(ErrorMessage="Descrição obrigatória")]
        [StringLength(100,ErrorMessage="Descriçao muito longa")]
        [MinLength(2,ErrorMessage="Descrição muito curta")]
        public string Descricao_Vaga { get; set; }
        [Required(ErrorMessage="Projeto obrigatório")]
        [StringLength(100,ErrorMessage="Nome do projeto muito longo")]
        [MinLength(2,ErrorMessage="Nome do projeto muito curto")]
        public string Projeto { get; set; }
        [Required(ErrorMessage="Quantidade obrigatória")]
        public int Qtd_Vaga { get; set; }
        
    }
}