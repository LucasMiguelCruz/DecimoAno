using System;
using System.IO;

namespace ex2_Tutorial20
{
    class Program
    {
        static void Main(string[] args)
        {

            string pastaDestino;
            barra();
            Console.WriteLine("Digite o nome da pasta ou o Destino dos ficheiros: ");
            pastaDestino = Console.ReadLine();
            barra();
            string pathF2 = "E:\\" + pastaDestino + "\\F2.txt";
            string pathF3 = "E:\\" + pastaDestino + "\\F3.txt";
            string pathF4 = "E:\\" + pastaDestino + "\\F4.txt";
            string pathF5 = "E:\\" + pastaDestino + "\\F5.txt";
            string textoEscrever2 = "M5:Estruturas de dados estáticas";
            string textoEscrever3 = "M5:Estruturas de dados compostas";
            string textoEscrever4 = "M6:Estruturas de dados dinâmicas";
            string textoEscrever5 = "M7:Tratamento de Ficheiros";


            if (!File.Exists(pathF2))
            {
                string pasta = "E:\\pastaDestino";
                if (!Directory.Exists(pasta))
                    Directory.CreateDirectory(pasta);


                using (StreamWriter sw = File.CreateText(pathF2))
                {
                    sw.WriteLine(textoEscrever2);
                    Console.WriteLine("\n1. Ficheiro " + pathF2 + " criado com sucesso!");
                }
                barra();
                using (StreamWriter sw = File.CreateText(pathF3))
                {
                    sw.WriteLine(textoEscrever3);
                    Console.WriteLine("\n2. Ficheiro " + pathF3 + " criado com sucesso!");
                }
                barra();
                using (StreamWriter sw = File.CreateText(pathF4))
                {
                    sw.WriteLine(textoEscrever4);
                    Console.WriteLine("\n3. Ficheiro " + pathF4 + " criado com sucesso!");
                }
                barra();
                using (StreamWriter sw = File.CreateText(pathF5))
                {
                    sw.WriteLine(textoEscrever5);
                    Console.WriteLine("\n4. Ficheiro " + pathF5 + " criado com sucesso!");
                }
                barra();
                Console.WriteLine("Não esqueças o nome do Local dos Arquivos!");
                barra();
            }

            Console.WriteLine("");
            Console.WriteLine("Foi tudo feito com sucesso clique no Enter para fechar.");
            Console.ReadLine();

        }

        static public void barra()
        {
            for (int i = 1; i < 100; i++)
                Console.Write("=");
            Console.WriteLine();
        }
    }
}
