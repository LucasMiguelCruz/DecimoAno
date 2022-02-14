using System;

namespace ex2Tutorial19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplificar a passagem de parametros(por valor e por referencia");
            int a = 1;
            int b = 2;
            int x, y;


            metodoValor(a, b);
            Console.WriteLine("Segunda etapa: Valor de a:" + a + ", valor de b: " + b);

            metodoReferencia(ref a, ref b);
            Console.WriteLine("Quarta etapa: (ref): Valor de a: " + a + ", valor de b: " + b);

        }
        static void metodoValor(int vA, int vB)
        {
            Console.WriteLine("o valor de a = {0} e o valor de b={1}", vA, vB);
            vA = 100; vB = 200;
        }
        static void metodoReferencia(ref int vA, ref int vB)
        {
            Console.WriteLine("3º Etapa: o valor de a= {0} e o valor de b={1}", vA, vB);
            vA = 100; vB = 200;
        }
    }
}
