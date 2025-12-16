namespace DesafioLogicaCSharp;

class Program 
{
    static void Main() 
    {
        Exercicio05_ValidarPlaca();
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

    static void Exercicio03_OperacoesDouble() 
    {
        Console.Write("Digite o primeiro número: ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        double soma = n1 + n2;
        double subtracao = n1 - n2;
        double multiplicacao = n1 * n2;
        double media = (n1 + n2) / 2;

        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");

        if (n2 != 0) 
        {
            double divisao = n1 / n2;
            Console.WriteLine($"Divisão: {divisao}");
        } else
            Console.WriteLine("Divisão: Não é possível dividir por zero.");

        Console.WriteLine($"Média: {media}");
    }

    static void Exercicio04_ContarCaracteres() 
    {
        Console.Write("Digite uma palavra ou frase: ");
        string texto = Console.ReadLine() ?? "";

        int contador = 0;
        foreach (char c in texto) 
        {
            if (c != ' ')
                contador++;
        }

        Console.WriteLine($"Quantidade de caracteres (sem espaço): {contador}");
    }

    static void Exercicio05_ValidarPlaca() 
    {
        Console.Write("Digite a placa de um veículo: ");
        string placa = Console.ReadLine() ?? "";

        bool placaValida = true;
        if (placa.Length != 7)
            placaValida = false;
        else 
        {
            for (int i = 0; i < 3; i++) 
            { 
                if (!char.IsLetter(placa[i]))
                    placaValida = false;
            }
            for (int i = 3; i < 7; i++) 
            {
                if (!char.IsDigit(placa[i]))
                    placaValida = false;
            }
        }

        Console.WriteLine(placaValida ? "Placa válida!" : "Placa inválida!");
    }
}