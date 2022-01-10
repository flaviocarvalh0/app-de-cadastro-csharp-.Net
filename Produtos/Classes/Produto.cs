using System;
using Produtos.Enum;

namespace Produtos
{
    public class Produto : EntidadeBase
    {

        //Atrubutos
        private Categoria Categoria { get; set; }
        private string Nome { get; set; }

        private double Preco { get; set; }
        private string Descricao { get; set; }

        //Métodos
        public Produto(int id,Categoria categoria, string nome, double preco, string descricao)
        {
            this.Id = id;
            this.Categoria = categoria;
            this.Nome = nome;
            this.Preco = preco;
            this.Descricao = descricao;
        }

        public override string ToString()
        {
            
            string retorno = "";
            retorno += "Categoria" + this.Categoria + Environment.NewLine;
            retorno += "Nome" + this.Nome + Environment.NewLine;
            retorno += "Preço" + this.Preco + Environment.NewLine;
            retorno += "Descrição" + this.Descricao + Environment.NewLine;
        
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
    }
}