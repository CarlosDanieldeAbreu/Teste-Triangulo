using System;

namespace TesteTriangulo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Descubra o tipo de triângulo");
            Console.ResetColor();
            Console.WriteLine("============================");
            Console.WriteLine(" ");
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----------MENU--------------");
                Console.ResetColor();
                Console.WriteLine("============================");
                Console.WriteLine("Digite:" + "\n" + "1 - Para ver o tipo de triângulo" + "\n" + "S - Para sair");
                Console.WriteLine(" ");
                string opcao = Console.ReadLine();
                Console.WriteLine();
                if (opcao == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Informe o lado A");
                    Console.ResetColor();
                    string strLadoA = Console.ReadLine();
                    float LadoA = float.Parse(strLadoA);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Informe o lado B");
                    Console.ResetColor();
                    string strLadoB = Console.ReadLine();
                    float LadoB = float.Parse(strLadoB);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Informe o lado C");
                    Console.ResetColor();
                    string strLadoC = Console.ReadLine();
                    float LadoC = float.Parse(strLadoC);
                    Console.WriteLine();

                    if (LadoA == LadoB && LadoA == LadoC)
                    {
                        Console.WriteLine("Seu triângulo é um Eqüilátero");
                        Console.WriteLine();
                    }
                    else if (LadoA == LadoB && LadoA != LadoC || LadoA != LadoB && LadoA == LadoC || LadoA != LadoB && LadoB == LadoC)
                    {
                        Console.WriteLine("Seu triângulo é um Isósceles");
                        Console.WriteLine();
                    }
                    else if (LadoA != LadoB && LadoA != LadoC)
                    {
                        Console.WriteLine("Seu triângulo é um Escaleno");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Triângulo invalido");
                        Console.WriteLine();
                    }
                }
                if (opcao == "S" || opcao == "s")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Aperte ENTER para Sair");
                    Console.ResetColor();
                    break;
                }  
            }
            
        }
    }
}
