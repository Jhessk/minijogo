using System;
using minijogo;
class Program
{
    static void Main(string[] args)
{
    Console.WriteLine("Bem-vindo ao Mini Jogo de combate poo!");
    Console.WriteLine("Escolha seu heói:");
    Console.WriteLine("1. Guerreiro (Ataque Forte, Habilidade: Investida Ferroz)");
    Console.WriteLine("2. mago (Ataque Normal, Habilidade: Bola de Fogo)");
    Console.WriteLine("Digite o número da sua escola:");

    Personagem heroi;
    string escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
        heroi = new Guerreiro("Sir Arthur");
        break;
        case "2":
        heroi = new Mago("Merlin");
        break;
        default:
        Console.WriteLine("Escolha inválida. Você será um Guerreiro por padrão.");
        heroi = new Guerreiro("Sir Arthur");
        break;

    }

    Monstro monstro = new Monstro("Goblin", 60, 10);

    Console.WriteLine($"\n{heroi.Nome} vs {monstro.Nome}!");

    while (heroi.EstaVivo() &&monstro.EstaVivo())
    {
        Console.WriteLine("\n--- seu turno ---");
        heroi.ExibirStatus();
        monstro.ExibirStatus();

        Console.WriteLine("Escolha sua ação:");
        Console.WriteLine("1. Atacar");
        Console.WriteLine("2. usar Habilidade Especial");
        Console.WriteLine("Digite o número da sua ação: ");
        string acao =  Console.ReadLine();

        switch (acao)
        {
            case "1":
            heroi.Atacar(monstro);
            break;
            case "2":
            heroi.UsarHabilidade(monstro);
            break;
            default:
            Console.WriteLine("Ação inválidade. Você perdeu seu truno!");
            break;
        }

        if (!monstro.EstaVivo())
        {
            Console.WriteLine($"\n{monstro.Nome} foi derrotado! {heroi.Nome} venceu!");
            break;
        }

        Console.WriteLine($"\n--- truno do Monstro ---");
        monstro.Atacar(heroi);

        if (!heroi.EstaVivo())
        {
            Console.WriteLine($"\n{heroi.Nome} foi derrotado! {monstro.Nome} venceu!");
            break;
        }
        Console.WriteLine("\nPressione Enter para continuar...");
        Console.ReadLine();
    }
    Console.WriteLine("\nFim do Jogo.");
}
    
}
