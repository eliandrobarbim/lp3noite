using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TodoWeb.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }



        [Required]
        public string Email { get; set; }



        [Required]
        public string Senha { get; set; }

    }
}