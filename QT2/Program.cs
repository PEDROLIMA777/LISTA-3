/*-------------------------------------------------------------------
Questão 2: Cálculo de Pontuação por Missão com Níveis de 
Dificuldade
Contextualização:
Em um jogo de aventuras, um jogador completa missões com diferentes níveis de dificuldade.
Cada nível de dificuldade afeta a pontuação ganha por inimigo derrotado.
Comando:
Desenvolva um programa em C# que:
1. Pergunte ao jogador quantas missões ele completou.
2. Para cada missão, pergunte qual o nível de dificuldade (Fácil, Médio, Difícil).
3. Para cada missão, pergunte quantos inimigos ele derrotou.
A pontuação por inimigo depende do nível de dificuldade:
* Fácil: 50 pontos por inimigo
* Médio: 100 pontos por inimigo
Serviço Nacional de Aprendizagem Industrial
Centro de Formação Profissional Antônio Urbano de Almeida
Técnico em Jogos Digitais
Lógica de Programação
Lista de Exercícios 3
3
* Difícil: 150 pontos por inimigo
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
            int missoes, inimigos, fi = 0,f1 = 0,f2 = 0,f3 = 0;
            Console.WriteLine(" Quantidade de missões completadas?");
            int.TryParse(Console.ReadLine(), out missoes);
            for (int i = 0; i < missoes; i++)
        {
            Console.WriteLine("A cada missão, qual a dificuldade?");
            nivel = Console.ReadLine();
            if (nivel == "facil")
            {
                Console.WriteLine("Quantos inimigos foram derrotados durante a missão?");
                int.TryParse(Console.ReadLine(), out inimigos);
                fi = 50 * inimigos;
            }
             else if (nivel == "medio")
            {
                Console.WriteLine("Quantos inimigos foram derrotados durante a missão?");
                int.TryParse(Console.ReadLine(), out inimigos);
                f1 = 100 * inimigos;
            }
             else if (nivel == "dificil")
            {
                Console.WriteLine("Quantos inimigos foram derrotados durante a missão?");
                int.TryParse(Console.ReadLine(), out inimigos);
                f2 = 150 * inimigos;
            }
            f3=fi+f1+f2;
        }
            Console.WriteLine($"Você ganhou {f3} pontos!");
    }
}