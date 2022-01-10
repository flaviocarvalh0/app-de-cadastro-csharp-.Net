using System.Collections.Generic;
namespace Produtos.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();

        T RetonaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualizar(int id, T entidade);
        int ProximoId();
    }
}