using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoLivraria.Models
{
    public class AutorModel
    {
        public AutorModel()
        {
            
        }

        public AutorModel(string nome)
        {
            Nome = nome;
        }

        [Required(ErrorMessage = "O campo {0} é requerido!")]
        [MaxLength(50, ErrorMessage = "O máximo de caracteres permitido para {0} é de 50!")]
        public string Nome { get; set; }
    }
}