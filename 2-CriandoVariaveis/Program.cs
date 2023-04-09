using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variáveis");

        int idade; // declarada a variável e sempre será inteira
        idade = 27; // valor da variável

        Console.WriteLine(idade); // print da variável
        idade = 27 - 5; // é possível alterar o valor da variável 

        Console.WriteLine("Minha idade é " + idade); // string + variável
        idade = 5 * 2 - 6;

        Console.Write(idade); // é possível utilizar 'Console.Write', porém não quebrará a linha

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }
}