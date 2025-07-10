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

        }
    }
}
