using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e Textos");

        char letra = 'a'; // importante manter aspas simples
        Console.WriteLine(letra);

        letra = (char)65; // ASCII table
        Console.WriteLine(letra);

        letra = (char)(65 + 1); //ASCII table
        Console.WriteLine(letra);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}