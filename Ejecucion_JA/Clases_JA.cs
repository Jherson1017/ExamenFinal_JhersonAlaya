using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejecucion_JA
{
    public class Clases_JA
    {
        Ram
        string[] arti = new string[] { "Articulo " }
        public void GeneraNotasT2()
        {
            Random R = new Random();
            int col = 1;
            Console.WriteLine(":::::NOTAS T2:::::");
            for (int i = 0; i < matriz_notas.GetLength(0); i++)
            {
                int not = R.Next(0, 21);
                Console.WriteLine(articulos[i] + ": " + not);
                matriz_notas[i, col] = not;
                Thread.Sleep(500);
            }
        }
        public void GeneraNotasT3()
        {
            Random R = new Random();
            int col = 2;
            Console.WriteLine(":::::NOTAS T3:::::");
            for (int i = 0; i < matriz_notas.GetLength(0); i++)
            {
                int not = R.Next(0, 21);
                Console.WriteLine(articulos[i] + ": " + not);
                matriz_notas[i, col] = not;
                Thread.Sleep(500);
            }
        }
        public void GeneraNotasEF()
        {
            Random R = new Random();
            int col = 3;
            Console.WriteLine(":::::NOTAS EF:::::");
            for (int i = 0; i < matriz_notas.GetLength(0); i++)
            {
                int not = R.Next(0, 21);
                Console.WriteLine(articulos[i] + ": " + not);
                matriz_notas[i, col] = not;
                Thread.Sleep(500);
            }
        }
        public void MostrarRegistro()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Nombres y Apellidos\t\tT1\tT2\tT3\tEF");
            Console.ResetColor();
            for (int i = 0; i < matriz_notas.GetLength(0); i++)
            {
                for (int j = 0; j < matriz_notas.GetLength(1); j++)
                {
                    Console.Write(matriz_notas[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }

}
    
