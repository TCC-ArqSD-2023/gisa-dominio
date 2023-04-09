using GisaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GisaDominio.Interfaces.Repositorios
{
    public interface IRepositorioBase<T> where T : EntidadeBase
    {
        IEnumerable<T> ObterTodos();
        T? ObterPorId(long id);
        void Inserir(T entidade);
        void Atualizar(T entidade);
        void Remover(long id);
    }
}
