using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoLivraria.Models
{
    public class LivroModel
    {
        [DisplayName("Título")]
        [Required(ErrorMessage = "O  campo {0} é requerido!")]
        [MaxLength(50, ErrorMessage = "O máximo de caracteres permitido é 50!")]
        public string Titulo { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O  campo {0} é requerido!")]
        [MaxLength(200, ErrorMessage = "O máximo de caracteres permitido é 200!")]
        public string Descricao { get; set; }

        [DisplayName("Preço")]
        [Required(ErrorMessage = "O  campo {0} é requerido!")]
        public double Preco { get; set; } 
    }
}