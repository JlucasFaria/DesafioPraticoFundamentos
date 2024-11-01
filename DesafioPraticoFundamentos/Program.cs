using System.ComponentModel;
using System.Text.RegularExpressions;

namespace DesafioPraticoFundamentos;

class Exercicios {

    static void Main() {

        Console.WriteLine("Exercicío 1:");

        Console.WriteLine("Digite seu nome:");
        string? userName = Console.ReadLine();
        Console.WriteLine($"Olá, {userName}! Que bom ter você aqui!");

        Console.WriteLine("----------------------------------------------");

        Console.WriteLine("Exercicío 2:");

        Console.WriteLine("Digite seu nome:");
        string? firstName = Console.ReadLine();
        Console.WriteLine("Digite seu sobrenome:");
        string? lastName = Console.ReadLine();
        Console.WriteLine($"Olá, {firstName} {lastName}");

        Console.WriteLine("----------------------------------------------");

        Console.WriteLine("Exercicío 3:");
        
        double num1 = 0;
        double num2 = 0;

        Console.WriteLine("Insira o primeiro número:");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira o segundo número:");
        num2 = Convert.ToDouble(Console.ReadLine());

        double soma = num1 + num2;
        double subtracao = num1 - num2;
        double multiplicacao = num1 * num2;
        double? divisao = num2 != 0 ? num1 / num2 : (double?)null;
        double media = soma / 2;

        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");
        Console.WriteLine($"Divisão: {divisao}");
        Console.WriteLine($"Média: {media}");

        Console.WriteLine("----------------------------------------------");

        Console.WriteLine("Exercicío 4:");

        Console.WriteLine("Insira uma palavra ou frase para saber quantos letras elas possui:");
        string? text = Console.ReadLine();

        int letterCounter = text.Count(c => !char.IsWhiteSpace(c));

        Console.WriteLine($"A quantidade de letras: {letterCounter}");

        Console.WriteLine("----------------------------------------------");

        Console.WriteLine("Exercicío 5:");

        Console.WriteLine("Digite a placa do veículo para saber se é válida:");
        string? placa = Console.ReadLine();

        string padraoPlaca = @"^[A-Za-z]{3}[0-9][A-Za-z][0-9]{2}$";

        bool validaPlaca = Regex.IsMatch(placa, padraoPlaca);

        Console.WriteLine(validaPlaca ? "Verdadeiro" : "Falso");

        Console.WriteLine("----------------------------------------------");

        Console.WriteLine("Exercicío 6:");

        DateTime currentDate = DateTime.Now;

        Console.WriteLine(currentDate.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss"));
        Console.WriteLine(currentDate.ToString("dd/MM/yyyy"));
        Console.WriteLine(currentDate.ToString("HH:mm"));
        Console.WriteLine(currentDate.ToString("dd 'de' MMMM 'de' yyyy"));








    }
}
