using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario;
        salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro;
        salarioInteiro = (int)salario; // converter variável salário int em double
        Console.WriteLine(salarioInteiro);

        long x; // serve como int para trabalhar com números maiores (64 bits)
        x = 20000000000000;
        Console.WriteLine(x);

        short y; // serve como int para trabalhar com números menores
        y = 15000;

        float altura;
        altura = 1.62f; // serve como double com menos precisão

        float peso = 56; // boas práticas (clean code)


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}