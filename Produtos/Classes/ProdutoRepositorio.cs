using System;
using System.Collections;
using System.Collections.Generic;
using Produtos.Interfaces;


namespace Produtos
{
    public class ProdutoRepositorio : IRepositorio<Produto>
    {

        private List<Produto> listaProduto = new List<Produto>();
        public void Atualizar(int id, Produto entidade)
        {
            throw new NotImplementedException();
        }

        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Produto entidade)
        {
            throw new NotImplementedException();
        }

        public List<Produto> Lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            throw new NotImplementedException();
        }

        public Produto RetonaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}