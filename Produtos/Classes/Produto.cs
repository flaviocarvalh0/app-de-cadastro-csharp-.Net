using System;
using Produtos;

namespace Produtos
{
    public class Produto : EntidadeBase
    {

        //Atrubutos
        private Categoria Categoria { get; set; }
        private string Nome { get; set; }
        private double Preco { get; set; }
        private string Descricao { get; set; }
        private bool Excluido { get; set; }

        //Métodos
        public Produto(int id, Categoria categoria, string nome, double preco, string descricao)
        {
            this.Id = id;
            this.Categoria = categoria;
            this.Nome = nome;
            this.Preco = preco;
            this.Descricao = descricao;
            this.Excluido = false;
        }

        public override string ToString()
        {

            string retorno = "";
            retorno += "Categoria" + this.Categoria + Environment.NewLine;
            retorno += "Nome" + this.Nome + Environment.NewLine;
            retorno += "Preço" + this.Preco + Environment.NewLine;
            retorno += "Descrição" + this.Descricao + Environment.NewLine;
            retorno += "Excluido" + this.Excluido + Environment.NewLine;

            return retorno;
        }

        public string retornaNome()
        {
            return this.Nome;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}