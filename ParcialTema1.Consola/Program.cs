using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialTema1.Consola
{
    internal class Program
    {
            private static double CalcularVolumen(double baseCilindro, double altura)
            {
                double resultado;
                resultado = baseCilindro * altura;
                return resultado;
            }

            private static double CalcularBase(double radio)
            {
                double resultado;
                resultado = Math.PI * Math.Pow(radio, 2);
                return resultado;
            }

            private static double CalcularArea(double radio, double altura)
            {
                double resultado;
                resultado = 2 * Math.PI * radio * (altura + radio);
                return resultado;
            }

            private static void Main(string[] args)
            {
                double area, volumen, radio, altura, baseCilindro;
                int contadorCilindros = 0;

                do
                {
                    Console.Write("Ingrese el radio del cilindro: ");
                    radio = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese la altura del cilindro: ");
                    altura = Convert.ToDouble(Console.ReadLine());

                    if (altura > 0)
                    {
                        baseCilindro = CalcularBase(radio);
                        area = CalcularArea(radio, altura);
                        volumen = CalcularVolumen(baseCilindro, altura);

                        Console.WriteLine("El área del cilindro es: " + area);
                        Console.WriteLine("El volumen del cilindro es: " + volumen);

                        contadorCilindros++;
                    }
                    else
                    {
                        Console.WriteLine("Número ingresado no válido.");
                    }
                } while (radio > 0 && altura > 0);

                Console.WriteLine("Cilindros contabilizados: " + contadorCilindros);
            }
        }
    }
    

