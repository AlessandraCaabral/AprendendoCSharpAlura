using System;
class programa
{
    static void Main(String[] args)
    {
        
        double salario;
        salario = 3400.16;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        long x= 1000000000000;
        Console.WriteLine(x);

        // Long = armazenar grandes valores que o int não suporte. Short armazenar pequenos valores.

        short y = 16000;
        Console.WriteLine(y);

        float altura = 1.59f;
        Console.WriteLine(altura);


        Console.WriteLine("Tecle enter para fechar .....");
        Console.ReadLine();

    }
}
