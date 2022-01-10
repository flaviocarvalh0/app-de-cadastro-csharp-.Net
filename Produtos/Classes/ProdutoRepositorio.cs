using System;
using System.Collections;
using System.Collections.Generic;
using Produtos.Interfaces;


namespace Produtos
{
    public class ProdutoRepositorio : IRepositorio<Produto>
    {

        private List<Produto> listaProduto = new List<Produto>();
        public void Atualizar(int id, Produto objeto)
        {
            listaProduto[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaProduto[id].Excluir();
        }

        public void Insere(Produto objeto)
        {
            listaProduto.Add(objeto);
        }

        public List<Produto> Lista()
        {
            return listaProduto;
        }

        public int ProximoId()
        {
            return listaProduto.Count;
        }

        public Produto RetonaPorId(int id)
        {
            return listaProduto[id];
        }
    }
}