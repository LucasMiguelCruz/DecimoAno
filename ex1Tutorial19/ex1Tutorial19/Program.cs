using System;

namespace ex1Tutorial19
{
    class Program
    {
        static void quadradoValor(int op)
        {
            op *= op;
            Console.WriteLine("Valor do quadrado dentro do método: {0}", op);
        }
        static void quadradoRef(ref int op)
        {
            op *= op;
            Console.WriteLine("Valor do quadrado dentro do método: {0}", op);
        }
        static void Main(string[]args)
        {
            int arg = 7;
            quadradoValor(arg);
            Console.WriteLine("V. Valor do quadrado: {0}", arg);

            arg = 7;
            quadradoRef(ref arg);
            Console.WriteLine("R. Valor do quadrado {0}", arg);
        }   
    }
}
