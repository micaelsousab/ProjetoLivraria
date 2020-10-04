using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProjetoLivraria.Repositories
{
    public class AutorRepository
    {
        public List<Autor> ObterTodosAutores()
        {
            using(var db = new LivrariaEntities())
            {
                return db.Autor.ToList();
            }
        }

        public void AdicionarNovoAutor(Autor autorEntity)
        {
            using(var db = new LivrariaEntities())
            {
                db.Autor.Add(autorEntity);
                db.SaveChanges();
            }
        }

        public Autor ObterAutor(int id)
        {
            using(var db = new LivrariaEntities())
            {
                return db.Autor.Find(id);
            }
        }

        public void EditarAutor(Autor autor)
        {
            using(var db = new LivrariaEntities())
            {
                db.Entry(autor).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeletarAutor(int id)
        {
            using(var db = new LivrariaEntities())
            {
                var autor = db.Autor.Find(id);

                db.Autor.Remove(autor);
                db.SaveChanges();
            }
        }
    }
}