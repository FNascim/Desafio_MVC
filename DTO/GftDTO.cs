using System;
using System.ComponentModel.DataAnnotations;

namespace Desafio_MVC.DTO
{
    public class GftDTO
    {
        [Required]
        public Int64 Id { get; set; }
        [Required(ErrorMessage="CEP obrigatório")]
        [StringLength(8,ErrorMessage="CEP muito longo")]
        [MinLength(8,ErrorMessage="CEP muito curto")]
        public string Cep { get; set; }
        [Required(ErrorMessage="Nome da cidade obrigatório")]
        [StringLength(100,ErrorMessage="Nome da cidade muito longo")]
        [MinLength(2,ErrorMessage="Nome da cidade muito curto")]
        public string Cidade { get; set; }
        [Required(ErrorMessage="Endereço obrigatório")]
        [StringLength(100,ErrorMessage="Endereço muito longo")]
        [MinLength(2,ErrorMessage="Endereço muito curto")]
        public string Endereco { get; set; }
        [Required(ErrorMessage="Nome do Estado obrigatório")]
        [StringLength(2,ErrorMessage="Nome do estado muito longo, Utilize a sigla do estado")]
        [MinLength(2,ErrorMessage="Nome do estado muito curto")]
        public string Estado { get; set; }
        [Required(ErrorMessage="Nome obrigatório")]
        [StringLength(100,ErrorMessage="Nome muito longo")]
        [MinLength(2,ErrorMessage="Nome muito curto")]
        public string Nome { get; set; }
        [Required(ErrorMessage="Telefone obrigatório")]
        [StringLength(100,ErrorMessage="Numero de telefone muito longo")]
        [MinLength(2,ErrorMessage="Numero de telefone muito curto")]
        public string Telefone { get; set; }
    }
}