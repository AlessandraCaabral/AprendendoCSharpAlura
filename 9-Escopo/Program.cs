﻿using System;
class programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("Executamdo o projeto 9 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true;

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Pode entrar!!!!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!!");
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
