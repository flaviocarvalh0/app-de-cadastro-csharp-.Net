using System;
using Produtos;


namespace Produtos
{



    class Program
    {

        static ProdutoRepositorio repositorio = new ProdutoRepositorio();
        static void Main(string[] args)
        {

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarProdutos();
                        break;
                    case "2":
                        InserirProduto();
                        break;
                    case "3":
                        AtualizarProduto();
                        break;
                    case "4":
                        ExcluirProduto();
                        break;
                    case "5":
                        VisualizarProduto();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }


        private static void VisualizarProduto()
        {
            System.Console.Write("Digite o id do produto que deseja visualizar: ");
            int indexProduto = int.Parse(Console.ReadLine());

            var produto = repositorio.RetonaPorId(indexProduto);

            System.Console.WriteLine(produto);
        }
        private static void ExcluirProduto()
        {
            System.Console.Write("Informe o id do produto que deseja excluir: ");
            int indexProduto = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Confirmar exclusão?");
            System.Console.WriteLine("s/n");

            string opcao = Console.ReadLine();

            if (opcao == "s")
            {
                repositorio.Exclui(indexProduto);
                System.Console.WriteLine("Produto ecluído com sucesso, vizualize produto para ver seu status");
            }
            else
            {
                System.Console.WriteLine("Produto não excluído.");
            }
        }

        private static void AtualizarProduto()
        {
            System.Console.Write("Digite o id do produto que deseja atualizar: ");
            int indexProduto = int.Parse(Console.ReadLine());
            foreach (int i in Enum.GetValues(typeof(Categoria)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Categoria), i));
            }
            Console.Write("Digite a categoria entre as opções acima: ");
            int entradaCategoria = int.Parse(Console.ReadLine());

            Console.Write("Digite o Nome do produto: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            double entradaPreco = double.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do produto: ");
            string entradaDescricao = Console.ReadLine();

            Produto atualizarProduto = new Produto(id: indexProduto,
                                        categoria: (Categoria)entradaCategoria,
                                        nome: entradaNome,
                                        preco: entradaPreco,
                                        descricao: entradaDescricao);

            repositorio.Atualizar(indexProduto, atualizarProduto);
        }
        private static void ListarProdutos()
        {
            Console.WriteLine("Cárdapio");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma produto cadastrada.");
                return;
            }

            foreach (var produto in lista)
            {
                var excluido = produto.retornaExcluido();
                System.Console.WriteLine("#ID {0}: {1} {2}", produto.retornaId(), produto.retornaNome(), (excluido ? "*Excluído*": ""));
            }

        }

        private static void InserirProduto()
        {
            Console.WriteLine("Inserir nova série");

            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
            foreach (int i in Enum.GetValues(typeof(Categoria)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Categoria), i));
            }
            Console.Write("Digite a categoria entre as opções acima: ");
            int entradaCategoria = int.Parse(Console.ReadLine());

            Console.Write("Digite o Nome do produto: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            double entradaPreco = double.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do produto: ");
            string entradaDescricao = Console.ReadLine();

            Produto novaSerie = new Produto(id: repositorio.ProximoId(),
                                        categoria: (Categoria)entradaCategoria,
                                        nome: entradaNome,
                                        preco: entradaPreco,
                                        descricao: entradaDescricao);

            repositorio.Insere(novaSerie);
        }


        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Doni Donnie's a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Cárdapio");
            Console.WriteLine("2- Inserir novo produto");
            Console.WriteLine("3- Atualizar produto");
            Console.WriteLine("4- Excluir produto");
            Console.WriteLine("5- Visualizar produto");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
