using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Desafio_MVC.Models;

namespace Desafio_MVC.DTO
{
    public class Funcionario_TecnologiaDTO
    {
        
        public Int64 Funcionario_Id { get; set; }
       
        public Funcionario Funcionario {get; set;}

        public Int64 Tecnologia_Id { get; set; }
        public Tecnologia Tecnologia {get; set;}
        

    }
}