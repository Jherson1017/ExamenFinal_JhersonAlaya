using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ejecucion_JA;

namespace ExamenFinal_JhersonAlaya
{
    class Program
    {
        static void Main(string[] args)
        {
            Clases_JA AR = new Clases_JA();
            AR.GenerarArticulos();
            AR.GenerarVentas();
            AR.MostrarMatriz();
            AR.MostrarTotalesPorArticulo();
            AR.MostrarTotalesPorDia();
            Console.ReadKey();
        }
    }
}
