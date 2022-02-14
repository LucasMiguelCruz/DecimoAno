using System;
using System.Collections.Generic;
using System.Linq;

namespace ex2Revisao
{
    class Program
    {
        //variaveis globais
        static double max = 0;
        static double min = 9999999;
        static double media = 0;

        //criação da lista/conjunto de numeros
        static List<double> setNum = new List<double>();

        static void linha()
        {
            Console.WriteLine();
            for (int i = 1; i < 80; i++) 
                Console.Write("=");
            Console.WriteLine();
        }

        //método tipo função que devolve um double
        static double CalculaMaximo()
        {
            double maxi = 0;
            foreach (double d in setNum)
            {
                if (d > maxi) maxi = d;

            }
            return maxi;
        }
        //método tipo prodecimento que não devolve nada(por causa do void)
        static void calculaMinimo()
        {
            foreach (double d in setNum)
                if (d < min) min = d;
            Console.WriteLine("Elemento minimo do conjunto:" + min);
        }
        static double calculaMedia()
        {
            double soma = 0;
            double medi = 0;
            int c = 0;
            foreach (double d in setNum)
            {
                soma = soma + d;
                c++;
            }
            medi = soma / c;
            return medi;
        }
        static void apresentaNumeros()
        {
            foreach (double d in setNum)
                Console.WriteLine("Número: " + d);
            Console.WriteLine();
        }
        //metodo tipo prodecimento (não devolve nada por causa do void)

        static void apresentarInverso()
        {
            Console.WriteLine("\n\n Sequencia dos numeros introduzidos por ordem inversa");
            setNum.Reverse();
            foreach (double d in setNum)
                Console.WriteLine("Numero:" + d);
            Console.WriteLine();
        }
        //metodo tipo função para devolver o ultimo elemento
        static double DevolverUltimo()
        {
            double d;
            d = setNum.Last();
            return d;
        }
        static double DevolverPrimeiro()
        {
            double d;
            d = setNum.First();
            return d;
        }
        static void IdentificarParImpar()
        {
            foreach (double d in setNum)
            {
                int n = (int)d; //  converte o numero d(tipo double) para inteiro
                if (n % 2 == 0) Console.WriteLine(n + " - Par");
                else Console.WriteLine(n + " - Impar");
            }
            Console.WriteLine();
        }
        //metodo com o parametro
        static void DecompoeMaximo(double mx)
        {
            int n = (int)mx;
            int m = n / 1000; //milhares
            int r = n % 1000; //resto da divisao por 1000
            int c = r / 100; //centenas
            int rt = r % 100; //resto da divisao por 100
            int d = rt / 10; //dezenas
            int u = rt % 10; //unidade

            Console.WriteLine("\n\n Decomposição do máximo " + n + " em Milhares, Centenas, Dezenas e Unidade");
            Console.WriteLine("Milhares: " + m);
            Console.WriteLine("Centenas: " + c);
            Console.WriteLine("Dezenas: " + d);
            Console.WriteLine("Unidades: " + u);
        }
        static void Main(string[] args)
        {
            linha();
            Console.WriteLine("Programa para calcular o máximo, mínimo, média");
            Console.WriteLine(" e outros de um conjunto de números");
            linha();
            Console.WriteLine("Introduza os números: ");
            for (int i = 1; i <= 8; i++)
            {
                Console.Write("Numero: ");
                double num = double.Parse(Console.ReadLine());
                setNum.Add(num);
            }
            linha();
            Console.WriteLine("RESULTADOS");
            apresentaNumeros();
            max = CalculaMaximo();
            Console.WriteLine("Elemento máximo: " + max);
            calculaMinimo();
            media = calculaMedia();
            Console.WriteLine("Média dos elementos introduzidos: " + media);
            //invocação de método com parâmetro
            DecompoeMaximo(max);
            //invocação do método para apresentar o inverso do conjunto
            apresentarInverso();
            //invocação do método tipo função para devolver o último elemento
            double d = DevolverUltimo();
            Console.WriteLine("\n\n Ultimo elemento do conjunto: " + d);
            linha();
            Console.ReadLine();
        }
    }
}
