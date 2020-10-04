using ProjetoLivraria.Models;
using ProjetoLivraria.Models.ViewModels;
using System.Collections.Generic;

namespace ProjetoLivraria.Conversor
{
    public class AutorConversor
    {
        public List<AutorViewModel> ObterListaAutores(List<Autor> listaEntidadeAutor)
        {
            List<AutorViewModel> listaAutorViewModel = new List<AutorViewModel>();

            foreach (var entidadeAutor in listaEntidadeAutor)
            {
                listaAutorViewModel.Add(new AutorViewModel(entidadeAutor.Id, entidadeAutor.Nome));
            }

            return listaAutorViewModel;
        }

        public Autor ObterEntidadeAutor(AutorModel autorModel)
        {
            Autor autor = new Autor
            {
                Nome = autorModel.Nome
            };

            return autor;
        }

        public Autor ObterEntidadeAutorEdicao(AutorViewModel autorModel)
        {
            Autor autor = new Autor
            {
                Id = autorModel.Id,
                Nome = autorModel.Nome
            };

            return autor;
        }

        public AutorViewModel ObterAutorViewModel(Autor autorEntidade)
        {
            return new AutorViewModel(autorEntidade.Id, autorEntidade.Nome);
        }
    }
}