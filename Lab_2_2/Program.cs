using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalAcumulado = 0;

            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Elevar al cuadrado");
                Console.WriteLine("6. Raíz cuadrada");
                Console.WriteLine("7. Reset");
                Console.WriteLine("8. Salir");

                int opcion;
                bool esNumero = int.TryParse(Console.ReadLine(), out opcion);

                if (!esNumero)
                {
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                }
                else
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el número a sumar:");
                            double suma;
                            if (double.TryParse(Console.ReadLine(), out suma))
                            {
                                totalAcumulado += suma;
                                Console.WriteLine("Suma realizada. Valor acumulado: " + totalAcumulado);
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida. Ingrese un número válido.");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Ingrese el número a restar:");
                            double resta;
                            if (double.TryParse(Console.ReadLine(), out resta))
                            {
                                totalAcumulado -= resta;
                                Console.WriteLine("Resta realizada. Valor acumulado: " + totalAcumulado);
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida. Ingrese un número válido.");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Ingrese el número a multiplicar:");
                            double multiplicacion;
                            if (double.TryParse(Console.ReadLine(), out multiplicacion))
                            {
                                totalAcumulado = Multiplicar(totalAcumulado, multiplicacion);
                                Console.WriteLine("Multiplicación realizada. Valor acumulado: " + totalAcumulado);
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida. Ingrese un número válido.");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Ingrese el número divisor:");
                            double divisor;
                            if (double.TryParse(Console.ReadLine(), out divisor))
                            {
                                if (divisor != 0)
                                {
                                    totalAcumulado /= divisor;
                                    Console.WriteLine("División realizada. Valor acumulado: " + totalAcumulado);
                                }
                                else
                                {
                                    Console.WriteLine("No se puede dividir entre cero.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida. Ingrese un número válido.");
                            }
                            break;
                        case 5:
                            totalAcumulado = Math.Pow(totalAcumulado, 2);
                            Console.WriteLine("Valor acumulado elevado al cuadrado: " + totalAcumulado);
                            break;
                        case 6:
                            if (totalAcumulado >= 0)
                            {
                                double raizCuadrada = Math.Sqrt(totalAcumulado);
                                Console.WriteLine("Raíz cuadrada del valor acumulado: " + raizCuadrada);
                            }
                            else
                            {
                                Console.WriteLine("No se puede calcular la raíz cuadrada de un número negativo.");
                            }
                            break;
                        case 7:
                            totalAcumulado = 0;
                            Console.WriteLine("Acumulador reseteado a cero.");
                            break;
                        case 8:
                            Console.WriteLine("Saliendo del programa...");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                            break;
                    }
                }
            }
        }

        private static double Multiplicar(double a, double b)
        {
            double result = 0;
            for (int i = 0; i < b; i++)
            {
                result += a;
            }
            return result;
        }

    }
}
