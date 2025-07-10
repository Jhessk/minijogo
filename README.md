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
            
        }
    }
}
