/*-------------------------------------------------------------------
Questão 3: Gerenciamento de Inventário com Limite e Tipos de 
Itens
Contextualização
Em um RPG, o jogador gerencia um inventário com diferentes tipos de itens, cada um com sua
quantidade específica. O inventário tem um limite máximo de itens que pode conter.
Comando:
Crie um programa em C# que:
1. Pergunte ao jogador quantos tipos diferentes de itens ele deseja armazenar no
inventário.
2. Para cada tipo de item, pergunte o nome do item e quantos itens desse tipo ele possui.
3. Pergunte ao jogador qual é a capacidade máxima do inventário.
O programa deve calcular e mostrar a quantidade total de itens no inventário e verificar se está
dentro da capacidade máxima, informando se está excedido ou não.
O programa deve calcular e exibir a pontuação total acumulada pelo jogador.
@Lista: 03 - Condicionais
@Autor: PEDRO LIMA
@Data: 02/09/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
            string? nivel;
            int itens, invent, qnt, tintens = 0;

            Console.WriteLine(" Quantidade de tipos diferentes de itens deseja armazenar no inventário?");
            int.TryParse(Console.ReadLine(), out itens);

            Console.WriteLine(" Qual a capacidade máxima do slot?.");
            int.TryParse(Console.ReadLine(), out invent);

            for (int i = 0; i < itens; i++)
         {
            Console.WriteLine("Qual o nome do item?");
            nivel = Console.ReadLine();

            Console.WriteLine("Quantos tipos de itens possui?");
            int.TryParse(Console.ReadLine(), out qnt);

            tintens += qnt;
            }
            if(tintens<=invent)
            {
             Console.WriteLine($"Tem-se {tintens} itens,Dentro da capacidade");
            }
            else
            {
             Console.WriteLine($"Tem-se {tintens} itens,fora da capacidade");
            }
    }
}