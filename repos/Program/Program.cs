using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            String cp1;
            int cp2;
            Console.WriteLine("-------------------");
            Console.WriteLine("LOGIN");
            Console.WriteLine("-------------------");
            Console.WriteLine("Escribe tú usuario o correo");
            cp1 = Console.ReadLine();
            Console.WriteLine("Escribe tú contraseña");
            int.TryParse(Console.ReadLine(), out cp2);
            if ((cp1 == "admin") && (cp2 == 1234))
            {
                Console.Clear();
                Console.WriteLine("-------------------");
                Console.WriteLine("Escoge una opcion");
                Console.WriteLine("1 sumar");
                Console.WriteLine("2 restar");
                Console.WriteLine("3 multiplicar");
                Console.WriteLine("4 dividir");
                Console.WriteLine("-------------------");
                int opciones = int.Parse(Console.ReadLine());
                switch (opciones)
                {
                    case 1:
                        Console.WriteLine("Escribe el primer numero");
                        double primero = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el segundo numero");
                        double segundo = Double.Parse(Console.ReadLine());
                        Operaciones operaciones = new Operaciones(primero, segundo);
                        Console.WriteLine("Tu resultado es: " + operaciones.sumar().ToString());
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Escribe el primer numero");
                        primero  = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el segundo numero");
                        segundo  = Double.Parse(Console.ReadLine());
                        operaciones = new Operaciones(primero, segundo);
                        Console.WriteLine("Tu resultado es: " + operaciones.restar().ToString());
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Escribe el primer numero");
                        primero  = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el segundo numero");
                        segundo  = Double.Parse(Console.ReadLine());
                        operaciones = new Operaciones(primero, segundo);
                        Console.WriteLine("Tu resultado es: " + operaciones.multiplicar().ToString());
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Escribe el primer numero");
                        primero  = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el segundo numero");
                        segundo  = Double.Parse(Console.ReadLine());
                        operaciones = new Operaciones(primero, segundo);
                        Console.WriteLine("Tu resultado es: " + operaciones.dividir().ToString());
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
