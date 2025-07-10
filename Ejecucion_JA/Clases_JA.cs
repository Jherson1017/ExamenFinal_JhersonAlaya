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
        string[] articulos = new string[7];
        int[,] ventas = new int[7, 7];
        string[] dias = { "Lun", "Mar", "Mié", "Jue", "Vie", "Sáb", "Dom" };
        public void GenerarArticulos()
        {
            for (int i = 0; i < articulos.Length; i++)
            {
                articulos[i] = "Artículo " + (i + 1);
            }
        }
        public void GenerarVentas()
        {
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("::::: VENTAS GENERADAS :::::\n");
            Console.ResetColor();
            for (int i = 0; i < articulos.Length; i++)
            {
                Console.Write(articulos[i] + ":\t");

                for (int j = 0; j < 7; j++)
                {
                    ventas[i, j] = rnd.Next(5, 200);
                    Console.Write(ventas[i, j] + "\t");
                    Thread.Sleep(300);
                }
                Console.WriteLine();
            }
        }
        public void MostrarMatriz()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n::::: MATRIZ DE VENTAS :::::");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nProducto\tLun\tMar\tMié\tJue\tVie\tSáb\tDom");
            Console.ResetColor();

            for (int i = 0; i < articulos.Length; i++)
            {
                Console.Write(articulos[i] + "\t");
                for (int j = 0; j < dias.Length; j++)
                {
                    Console.Write(ventas[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void MostrarTotalesPorArticulo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n::::: TOTALES POR ARTÍCULO :::::");
            Console.ResetColor();   
            Console.WriteLine("Artículo\tTotal\tMin\tMax\tProm");

            int totalGeneral = 0;

            for (int i = 0; i < articulos.Length; i++)
            {
                int suma = 0;
                int min = ventas[i, 0];
                int max = ventas[i, 0];

                for (int j = 0; j < 7; j++)
                {
                    int val = ventas[i, j];
                    suma += val;
                    if (val < min) min = val;
                    if (val > max) max = val;
                }

                double prom = suma / 7.0;
                totalGeneral += suma;

                Console.WriteLine(articulos[i]+"\t"+suma+"\t"+min+"\t"+max+"\t"+prom);
            };
            Console.WriteLine("\nTOTAL GENERAL DE TODOS LOS ARTÍCULOS: " + totalGeneral);
        }

        public void MostrarTotalesPorDia()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n::::: VENTAS POR DÍA :::::");
            Console.ResetColor();

            int totalGeneral = 0;

            for (int j = 0; j < 7; j++)
            {
                int sumaDia = 0;

                for (int i = 0; i < 7; i++)
                {
                    sumaDia += ventas[i, j];
                }

                totalGeneral += sumaDia;
                Console.WriteLine(dias[j]+ ":\t"+sumaDia);
            }

            Console.WriteLine("\nTOTAL SEMANAL GENERAL: "+totalGeneral);
        }

       
    }
}
    
