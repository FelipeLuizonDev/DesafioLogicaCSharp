namespace DesafioLogicaCSharp;

class Program 
{
    static void Main() 
    {
        Exercicio01_BoasVindas();
    }

    static void Exercicio01_BoasVindas() 
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine() ?? "";
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo(a)!");
    }
}