using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Desafio_MVC.Models;

namespace Desafio_MVC.DTO
{
    public class Vaga_TecnologiaDTO
    {
        
        
        public Int64 Vaga_Id { get; set; }
        public Vaga Vaga {get; set; }

        public Int64 Tecnologia_Id {get; set; }
        public Tecnologia Tecnologia {get; set;}
        
    }
}