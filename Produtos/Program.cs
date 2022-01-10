using System;
using Produtos;


namespace Produtos
{



    class Program
    {

        static ProdutoRepositorio repositorio = new ProdutoRepositorio();
        static void Main(string[] args)
        {

            string opcaoUser = ObterOpcaoUsuario();

            while (opcaoUser.ToUpper() != "X")
                switch (opcaoUser)
                {
                    case "1":
                        ListarProdutos();
                        break;

                    case "2":
                        InserirProduto();
                        break;

                    case "3":
                        break;
                }

        }

        private static void atualizarProduto()
        {
            Console.Write("Digite o id do produdo: ");
            int indicerProduto = int.Parse(Console.ReadLine());
        }

        private static void InserirProduto()
        {
            Console.WriteLine("Inserir um novo produto");

            foreach (var i in Enum.GetValues(typeof(Categoria)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Categoria), i));
            }

            Console.Write("Digite a categoria das opções acima: ");
            int entradaCategoria = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do produto: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            double entradaPreco = double.Parse(Console.ReadLine());

            Console.Write("Digite a descrição do produto: ");
            string entradaDescricao = Console.ReadLine();



            Produto novoProduto = new Produto(id: repositorio.ProximoId(),
                                                categoria: (Categoria)entradaCategoria,
                                                nome: entradaNome,
                                                preco: entradaPreco,
                                                descricao: entradaDescricao);

            repositorio.Insere(novoProduto);


        }


        private static void ListarProdutos()
        {
            System.Console.WriteLine("Listar produtos");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum produto encontrado");
                return;

            }
            else
            {

                foreach (var produto in lista)
                {
                    Console.WriteLine("#ID {0}: - {1}", produto.retornaId(), produto.retornaNome());
                }
            }



        }


        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Bem vindo, Doni Donnie's Delivery ao seu dispor.");
            Console.Write("Informe a opção desejada: ");
            Console.WriteLine();

            Console.WriteLine("1 - Cárdapio");
            Console.WriteLine("2 - Inserir novo produto");
            Console.WriteLine("3 - Atualizar produto");
            Console.WriteLine("4 - Excluir produto");
            Console.WriteLine("5 - Detalhe do Produto");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine("");

            string opcaoUsario = Console.ReadLine().ToUpper();
            Console.WriteLine("");
            return opcaoUsario;

        }
    }
}
