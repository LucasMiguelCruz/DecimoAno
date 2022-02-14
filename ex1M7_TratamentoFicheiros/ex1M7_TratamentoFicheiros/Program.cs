using System;
using System.IO;

namespace ex1M7_TratamentoFicheiros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Módulo 7- Tratamento de ficheiros");
            string pathF1 = "E:\\ExercFiles\\f1.txt";
            string textoAEscrever = "Exercicio 1 - Modulo 7 - Tratamento de ficheiros";

            //criar ficheiro e escrever com o streamWriter
            if (!File.Exists(pathF1))
            {
                using (StreamWriter sw = File.CreateText(pathF1))
                {
                    sw.WriteLine(textoAEscrever);
                    sw.WriteLine("Olá!");
                    sw.WriteLine("Bem-vindo mestre");
                    Console.WriteLine("Ficheiro" + pathF1 + "criado com sucesso!");
                }
            }
            //ler o ficheiro pathF1
            using (StreamReader sr = File.OpenText(pathF1))
            {
                Console.WriteLine("Leitura do ficheiro" + pathF1);
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            //Copiar ficheiros
            try
            {
                if (File.Exists(pathF1))
                {
                    Console.WriteLine("Copia do ficheiro" + pathF1 + " para f2.txt");
                    File.Copy(pathF1, "E:\\ExercFiles\\f2.txt");
                    Console.WriteLine("Cópia do ficheiro f1 para f2 realizada com sucesso");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro na copia do ficheiro f1.txt: " + ex.Message);
            }
            ///4. Apagar ficheiros com o File.Delete()
            Console.WriteLine("Deseja apagar o ficheiro pathF1.txt");
            string res = Console.ReadLine();
            if (res == "s")
            {
                if (File.Exists(pathF1))
                {
                    try
                    {


                        File.Delete(pathF1);
                        Console.WriteLine("Ficheiro f1.txt apagado!");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro: não foi possivel apagar o ficheiro f1.txt" +
                            ex.Message);
                    }
                }
            }

            Console.WriteLine("Deseja apagar o ficheiro f2.txt");
            res = Console.ReadLine();
            if (res == "s")
            {
                if (File.Exists("E:\\ExercFiles\\f2.txt"))
                {
                    try
                    {
                        File.Delete("E:ExercFiles\\f2.txt");
                        Console.WriteLine("Ficheiro f2.txt apagado!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro: não foi possivel apagar o ficheiro f2.txt" +
                            ex.Message);
                    }
                }
            }
            //obter informações sobre o disco principal(drive c:\)
            System.IO.DriveInfo info = new System.IO.DriveInfo(@"c:\");
            Console.WriteLine("Espaço total da Drive C: " + info.TotalSize);
            Console.WriteLine("Espaço total da Drive C: " + info.TotalFreeSpace);
            Console.WriteLine("Nome do disco:" + info.VolumeLabel);

            //Obter informações sobre a pasta atual
            string pastaAtual = Directory.GetCurrentDirectory();
            Console.WriteLine("7. Pasta atual: " + pastaAtual.ToString());

            //criar nova diretoria/pasta
            string novaPasta = @"E:\temp";
            if(!Directory.Exists(novaPasta))
            {
                Directory.CreateDirectory(novaPasta);
                Console.WriteLine("8. Nova pasta criada com sucesso:" + novaPasta);
            }
            //listar todos os ficheiros de uma pasta
            //copia ficheiros
            string pastaOld = @"E:\ExercFiles";
            if(Directory.Exists(pastaOld))
            {
                string[] ficheiros = Directory.GetFiles(pastaOld);
                foreach(string s in ficheiros)
                {
                    string nomeFich = Path.GetFileName(s);
                    string pathFich = Path.GetFullPath(s);
                    Console.WriteLine("- " + nomeFich + ": " + pathFich);
                    string fichDestino = Path.Combine(novaPasta, nomeFich);
                    File.Copy(pathFich, fichDestino, true);
                    
                }
                Console.WriteLine("9. Listagem dos ficheiros copiados");
            }
            string f3 = Path.Combine(novaPasta, "f3M7");
            File.WriteAllText(f3, textoAEscrever);
            Console.WriteLine("10. Ficheiro criado com sucesso: " + f3.ToString());

            //outra forma de ler o ficheiro
            string textoALer = File.ReadAllText(f3);
            Console.WriteLine(textoALer);
            Console.WriteLine("11. Leitura do ficheiro " + f3.ToString() + ": " + textoALer);

        }
    }
}




        