using ProjetoLivraria.Conversor;
using ProjetoLivraria.Models;
using ProjetoLivraria.Models.ViewModels;
using ProjetoLivraria.Repositories;
using System;
using System.Web.Mvc;

namespace ProjetoLivraria.Controllers
{
    public class AutorController : Controller
    {
        AutorRepository autorRepository = new AutorRepository();
        AutorConversor autorConversor = new AutorConversor();

        [HttpGet]
        public ActionResult Index()
        {
            ListagemAutorViewModel viewModel = new ListagemAutorViewModel();

            viewModel.ListaAutores = autorConversor.ObterListaAutores(autorRepository.ObterTodosAutores());

            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(AutorModel autorModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    autorRepository.AdicionarNovoAutor(autorConversor.ObterEntidadeAutor(autorModel));

                    TempData["Mensagem"] = "Autor adicionado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(autorModel);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            try
            {
                var autor = autorConversor.ObterAutorViewModel(autorRepository.ObterAutor(id));

                AutorViewModel viewModel = new AutorViewModel(autor.Id, autor.Nome);

                return View(viewModel);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPost]
        public ActionResult Editar(AutorViewModel autorViewModel)
        {
            try
            {
                var autor = autorConversor.ObterEntidadeAutorEdicao(autorViewModel);

                Autor autorEntidade = new Autor 
                { 
                    Id = autor.Id,
                    Nome = autor.Nome
                };

                autorRepository.EditarAutor(autorEntidade);

                TempData["Mensagem"] = "Autor alterado com sucesso!";

                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                throw;
            }
        }

        [HttpGet]
        public ActionResult Deletar(int id)
        {
            autorRepository.DeletarAutor(id);

            TempData["Mensagem"] = "Autor deletado com sucesso!";

            return RedirectToAction("Index");
        }
    }
}