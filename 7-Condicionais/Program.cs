using System;
class programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("Executamdo o projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;


        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!!!!");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Ele está acompanhado, pode emtrar!!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!!");
            }
        }
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
