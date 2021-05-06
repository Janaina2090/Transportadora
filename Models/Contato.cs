using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("Contato")]
    public class Contato
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome deve ser preenchido")]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; }


        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo E-mail deve ser preenchido ")]
        public string Email { get; set; }

        [Required(ErrorMessage = " O campo empresa deve ser preenchido")]
        public string Empresa { get; set; }

        [Required(ErrorMessage = "O campo telefone deve ser preenchido")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = " O campo empresa deve ser preenchido")]
        public string Mensagem { get; set; }
    }
}