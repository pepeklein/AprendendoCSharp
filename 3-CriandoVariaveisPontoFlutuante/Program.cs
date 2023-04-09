using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Variáveis Ponto Flutuante");
        double salario; // tipo de variável para armazenar números com vírgula
        salario = 3000.10;

        salario = 3000; // var tipo double aceita int mas int não aceita double

        double idade;
        idade = 7 / 5; // devolverá número inteiro pois tratam-se de dois inteiros

        idade = 7.0 / 5; // devolverá número correto (double)

        Console.WriteLine(idade);

        Console.WriteLine(salario);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}