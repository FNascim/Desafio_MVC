using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio_MVC.Models
{
    public class Funcionario_Tecnologia
    {
        [Key]
        [Column(Order = 1)]
        public Int64 Funcionario_Id { get; set; }
        [ForeignKey("Funcionario_Id")]
        public Funcionario Funcionario {get; set;}
        [Key]
        [Column(Order = 2)]
        public Int64 Tecnologia_Id { get; set; }
        [ForeignKey("Tecnologia_Id")]
        public Tecnologia Tecnologia {get; set; }
        
    }
}