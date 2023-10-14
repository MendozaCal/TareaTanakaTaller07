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
                        float basR = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el valor de la altura");
                        float altR = float.Parse(Console.ReadLine());
                        Rectángulo r = new Rectángulo(basR,altR);
                        Console.WriteLine($"El área del rectángulo es {r.CalcularArea()}");
                        Console.ReadLine();
                    break;

                case 2: Console.WriteLine("Ingresa el valor de la base");
                        float basT = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el valor de la altura");
                        float altT = float.Parse(Console.ReadLine());
                        Triángulo t = new Triángulo(basT,altT);
                        Console.WriteLine($"El área del triángulo es {t.CalcularArea()}");
                        Console.ReadLine();
                    break;
                case 3: Console.WriteLine("Inserta el valor del radio");
                        float rad = float.Parse(Console.ReadLine());
                        Circulo C = new Circulo(rad);
                        Console.WriteLine($"El área del triángulo es {C.CalcularArea()}");
                        Console.ReadLine();
                    break;

            }
        }
    }
}
