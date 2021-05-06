using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("Cotacao")]
    public class Cotacao
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome deve ser preenchido")]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo E-mail deve ser preenchido ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo telefone deve ser preenchido")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = " Este campo é obrigatório.")]
        public string Empresa { get; set; }

        [Required(ErrorMessage = " Este campo é obrigatório.")]
        public string Origem { get; set; }

        [Required(ErrorMessage = " Este campo é obrigatório.")]
        public string Destino { get; set; }

        [Required(ErrorMessage = " Este campo é obrigatório.")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = " Este campo é obrigatório.")]
        public int Peso { get; set; }

        [Required(ErrorMessage = " Este campo é obrigatório.")]
        public int Largura { get; set; }

        [Required(ErrorMessage = " Este campo é obrigatório.")]
        public int Altura { get; set; }

        [Required(ErrorMessage = " Este campo é obrigatório.")]
        public int Comprimento { get; set; }

        [Display(Name = "Valor NF-e")]
        [Required(ErrorMessage = " Este campo é obrigatório.")]
        public int ValorNf { get; set; }


        [Display(Name = "Observação")]
        [Required(ErrorMessage = " Este campo é obrigatório.")]
        public int Observacao { get; set; }
    }
}