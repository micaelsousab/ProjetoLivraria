using System.Collections.Generic;

namespace ProjetoLivraria.Models.ViewModels
{
    public class AutorViewModel
    {
        public AutorViewModel()
        {

        }

        public AutorViewModel(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
    }
}