using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTanaka07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escoja la figura al calcular\n1. Rectángulo\n2. Triangulo\n3. Circulo");
            int opt = int.Parse(Console.ReadLine());
            switch (opt)
            {
                case 1: Console.WriteLine("Ingresa el valor de la base");
                        float bas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el valor de la altura");
                        float alt = int.Parse(Console.ReadLine());
                        Rectángulo r = new Rectángulo(bas,alt);
                    Console.WriteLine($"El área del rectángulo es {r.CalcularArea()}");
                break;
            }
        }
    }
}
