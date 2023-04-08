using gisa_dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gisa_dominio.Interfaces.Repositorios
{
    public interface IGenericRepository<T> where T : EntidadeBase
    {
        IEnumerable<T> ObterTodos();
        T ObterPorId(object id);
        void Inserir(T obj);
        void Atualizar(T obj);
        void Remover(object id);
    }
}
