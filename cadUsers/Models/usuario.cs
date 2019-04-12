using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace usuarios.Models
{
    public class usuario
    {
        [Key]
        public int Código { get; set; }
        [Required(ErrorMessage = "Por favor, digite um nome.")]
        public string Nome { get; set; }
    }
}