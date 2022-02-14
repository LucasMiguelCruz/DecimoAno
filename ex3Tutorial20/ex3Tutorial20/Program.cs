using System;
using System.IO;
using System.Threading.Tasks;


namespace ex3Tutorial20
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Programa para verificar se uma pasta existe e mostrar os ficheiros dentro dela");
            Console.WriteLine("Escreva o nome da pasta que deseja ver se os ficheiros existem");
            string pastaE;
            pastaE = Console.ReadLine();
            Console.WriteLine("");
            string pathF2 = "E:\\" + pastaE + "\\F2.txt";
            string pathF3 = "E:\\" + pastaE + "\\F3.txt";
            string pathF4 = "E:\\" + pastaE + "\\F4.txt";
            string pathF5 = "E:\\" + pastaE + "\\F5.txt";

  
           
            Console.WriteLine("Pasta existente:" + pastaE.ToString());

            string pastaTestes = @"E:\LUCASCRUZ ";
            if(Directory.Exists(pastaTestes))
            {
                Console.WriteLine("A pasta existe");
                string[] ficheiros = Directory.GetFiles(pastaTestes);
                    foreach(string s in ficheiros)
                {
                    string nomeFich = Path.GetFileName(s);
                    string pathFich = Path.GetFullPath(s);  
                }
            }
            using (StreamReader sr = File.OpenText(pathF2))
            {
                Console.WriteLine("\n1. Leitura do ficheiro " + pathF2);
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            using (StreamReader sr = File.OpenText(pathF3))
            {

                Console.WriteLine("\n2. Leitura do ficheiro " + pathF3);
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            using (StreamReader sr = File.OpenText(pathF4))
            {
                Console.WriteLine("\n3. Leitura do ficheiro " + pathF4);
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            using (StreamReader sr = File.OpenText(pathF5))
            {
                Console.WriteLine("\n4. Leitura do ficheiro " + pathF5);
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Pronto. Aperta 'Enter' para sair!");
            Console.ReadLine();
        }
        

    }

}
