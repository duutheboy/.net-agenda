﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteEmMVC.Models
{
    [Table("Contato")]
    public class ContatoModel
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }
    }
}
