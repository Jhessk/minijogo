using System;

namespace minijogo;
public class Mago : Personagem
{
    public Mago(string nome) : base(nome, 80, 10)
    {

    }
    public override void UsarHabilidade(Personagem alvo)
    {
        int danoMagico = AtaqueBase + 20;
        Console.WriteLine($" {Nome} conjura uma **Bola de Fogo** em {alvo.Nome} causando {danoMagico} de dano mágico!");
        alvo.ReceberDano(danoMagico);
    }
}
