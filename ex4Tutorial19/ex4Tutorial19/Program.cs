using System;

namespace ex4Tutorial19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de valor da hipotenusa");
            Console.Write("Valor do cateto 1: ");
            double cat1 = double.Parse(Console.ReadLine());
            Console.Write("Valor do cateto 2: ");
            double cat2 = double.Parse(Console.ReadLine());
            double hipot = 0;

            calcularHipotenusa(cat1, cat2, hipot);
            Console.WriteLine("2. Hipotenusa do triângulo com catetos {0} e {1} = {2}", cat1, cat2, hipot);

            calcularHipotenusaRef(ref cat1, ref cat2, ref hipot);
            Console.WriteLine("4. Hipotenusa do triângulo com catetos {0} e {1} = {2}", cat1, cat2, hipot);


        }
        static void calcularHipotenusa(double ct1, double ct2, double hp)
        {
            hp = Math.Sqrt(ct1 * ct1 + ct2 * ct2);
            Console.WriteLine("1. Hipotenusa do triângulo com catetos {0} e {1} = {2}", ct1, ct2, hp);
        }

        //metodo com passagem de parametros por referencia
        static void calcularHipotenusaRef(ref double ct1, ref double ct2, ref double hp)
        {
            hp = Math.Sqrt(ct1 * ct1 + ct2 * ct2);
            Console.WriteLine("3. Hipotenusa do triângulo com catetos {0} e {1} = {2}", ct1, ct2, hp);
        }
    }
}
