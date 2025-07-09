using System;

namespace minijogo;
public class Guerreiro : Personagem
{
    public Guerreiro(string nome) : base(nome, 120, 15)
    {

    }
    public override void Atacar(Personagem alvo)
    {
        int dano = AtaqueBase + 5;
        Console.WriteLine($"{Nome}desfere um golpepoderoso em {alvo.Nome} causando {dano} de dano!");
        alvo.ReceberDano(dano);
    }

    public override void UsarHabilidade(Personagem alvo)
    {
        int danoHabilidade = AtaqueBase * 2;
        Console.WriteLine($"{Nome} usa **Investida Ferroz** em {alvo.Nome} causando {danoHabilidade} de dano!");
        alvo.ReceberDano(danoHabilidade);
    }
}

