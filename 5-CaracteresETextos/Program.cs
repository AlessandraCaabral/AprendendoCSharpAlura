using System;
class programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e Textos ..");

        char letra = 'a';   
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cursos em c#";
        Console.WriteLine(primeiraFrase);

        string cursos =@"Cursos oferecidos:
- React 
- C# 
- Go 
- Java"; 

        Console.WriteLine(cursos);    

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();



    }
}
