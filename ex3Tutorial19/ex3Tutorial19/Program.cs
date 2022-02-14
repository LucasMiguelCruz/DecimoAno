using System;

namespace ex3Tutorial19
{
    class Program
    {
        static void trocaF(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Valor de a, no metodo: " + a);
            Console.WriteLine("Valor de b, no metodo: " + b);
        }
        static void troca(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Valor de a, no metodo: " + a);
            Console.WriteLine("Valor de b, no metodo: " + b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 5;
            int b = 10;
            Console.WriteLine("Valor de a, antes da troca: " + a);
            Console.WriteLine("Valor de b, antes da troca: " + b);
            troca(a, b);
            //dá: 10, 5
            Console.WriteLine("Valor de a, depois da troca: " + a);
            Console.WriteLine("Valor de b, depois da troca: " + b);
            trocaF(ref a, ref b);
            //dá: 10, 5
            Console.WriteLine("Valor de a, depois da troca: " + a);
            Console.WriteLine("Valor de b, depois da troca: " + b);
        }
    }
}
    

