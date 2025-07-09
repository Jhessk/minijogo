using System;

namespace minijogo;
public class Personagem
{
    public string Nome { get; protected set; }
    public int VidaAtual { get; protected set; }
    public int VidaMaxima { get; protected set; }
    public int AtaqueBase { get; protected set; }

    public Personagem(string nome, int vidaMaxima, int ataqueBase)
    {
        Nome = nome;
        VidaAtual = vidaMaxima;
        VidaMaxima = vidaMaxima;
        AtaqueBase = ataqueBase;
    }

    public virtual void Atacar(Personagem alvo)
    {
        int dano = AtaqueBase;
        Console.WriteLine($"{Nome} atca {alvo.Nome} causando {dano} de dano!");
        alvo.ReceberDano(dano);
    }

    public virtual void UsarHabilidade(Personagem alvo)
    {
        Console.WriteLine($"{Nome} não tem habilidade especial.");
    }

    public void ReceberDano(int dano)
    {
        VidaAtual -= dano;
        Console.WriteLine($"{Nome} recebeu {dano} de dano. Vida atual: {VidaAtual}/{VidaMaxima}");
        if (VidaAtual <= 0)
        {
            Console.WriteLine($" {Nome} foi derrotado!");
        }
    }

    public bool EstaVivo()
    {
        return VidaAtual > 0;
    }

    public void ExibirStatus()
    {
        Console.WriteLine($"Nome; {Nome} | Vida: {VidaAtual}/{VidaMaxima}");
    }

}
