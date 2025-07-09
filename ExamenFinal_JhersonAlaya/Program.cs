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
            AR.GenerarAlumnos();
            AR.GeneraNotasT1();
            Console.Clear();
            AR.GeneraNotasT2();
            Console.Clear();
            AR.GeneraNotasT3();
            Console.Clear();
            AR.GeneraNotasEF();
            Console.Clear();
            AR.MostrarRegistro();
            Console.ReadKey();
        }
    }
}
