using System;
using System.Collections.Generic; //Necessaria para List <T>
using System.Linq; // Necessaria  para (Find, where)


// Produto.cs

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Estoque { get; set; }
    public Produto(int id, string nome, decimal preco, int estoque)

    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }

    public void ExibirInfo()
    {
        Console.WriteLine($"ID: {Id}, Nome: {Nome}, Preco: {Preco:c}, Estoque: {Estoque}");
    }
}

class Program
{
    private static List<Produto> produtos = new List<Produto>();
    private static int proximoId = 1; // Para gerar  o ID  único de cada produto
    static void Main(string[] args)
    {
        bool rodando = true;
        while (rodando)
        {
            Console.Clear(); //limpa a tela do console
            Console.WriteLine("--- Gerenciador de Produtor");
            Console.WriteLine("1 - Criar Produtos");
            Console.WriteLine("2 - Listar  Produtos");
            Console.WriteLine("3 - Atualizar Produtos");
            Console.WriteLine("4 - Excluir Produtos");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CriarProduto();
                    break;
                case "2":
                    ListarProdutos();
                    break;
                case "3":
                    AtualizarProduto();
                    break;
                case "4":
                    ExcluirProduto();
                    break;
                case "5":
                    rodando = false;
                    Console.WriteLine("to saindo");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla pra continuar...");
            Console.ReadKey();

        }
    }

    static void CriarProduto()
    {
        Console.WriteLine("--- Criar novo produto ---");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Preço: ");
        decimal preco;
        while (!decimal.TryParse(Console.ReadLine(), out preco) || preco < 0)
        {
            Console.WriteLine("Preço inválido. Digite um valor positivo: ");
        }
        Console.Write("Estoque: ");
        int estoque;
        while (!int.TryParse(Console.ReadLine(), out estoque) || estoque < 0)
        {
            Console.WriteLine("Estoque inválido. Digite um valor positivo: ");
        }

        Produto novoProduto = new Produto(proximoId++, nome, preco, estoque);
        produtos.Add(novoProduto);
        Console.WriteLine($"Produto: '{novoProduto.Nome}' (ID: {novoProduto.Id}) criado com sucesso");
    }

    static void ListarProdutos()
    {
        Console.WriteLine("--- Listar Produtos ---");

        if (produtos.Count == 0)
        {
            Console.WriteLine("nenhum produto cadastrado");
            return;
        }

        foreach (var produto in produtos)
        {
            produto.ExibirInfo();
        }
    }

    static void AtualizarProduto()
    {
        Console.WriteLine("--- Atualizar Produtos ---");

        Console.Write("Digite o ID do produto: ");
        int idAtualizar;
        while (!int.TryParse(Console.ReadLine(), out idAtualizar));
        {
            Console.WriteLine("Id inválido");   
        }
    }

