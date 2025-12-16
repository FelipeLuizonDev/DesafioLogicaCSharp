namespace DesafioLogicaCSharp;

class Program 
{
    static void Main() 
    {
        Exercicio02_NomeCompleto();
    }

    static void Exercicio01_BoasVindas() 
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine() ?? "";
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo(a)!");
    }

    static void Exercicio02_NomeCompleto() 
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine() ?? "";

        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine() ?? "";

        string nomeCompleto = nome + " " + sobrenome;
        Console.WriteLine($"Nome completo: {nomeCompleto}");
    }
}