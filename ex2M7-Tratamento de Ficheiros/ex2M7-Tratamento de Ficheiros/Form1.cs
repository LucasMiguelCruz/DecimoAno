using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ex2M7_Tratamento_de_Ficheiros
{
    public partial class Form1 : Form
    {
        static public string link = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelPastaAtual.Text = Directory.GetCurrentDirectory();
            labelData.Text = DateTime.Now.ToLongDateString() + " - " +
                DateTime.Now.ToLongTimeString();
            timer1.Enabled = true;
            linkLabelSite.Text = "https://www.letras.mus.br/bngoficial/rap-do-minecraft/";
            link = "https://www.letras.mus.br/bngoficial/rap-do-minecraft/";
        }

        private void linkLabelSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBrowser frm = new FormBrowser();
            frm.ShowDialog();

        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Ficheiros de texto| *.txt";
            string nameFile;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nameFile = openFileDialog1.FileName;
                if (nameFile != null)
                    textBoxNomeFicheiro.Text = nameFile;
            }

        }

        private void buttonLerFicheiro_Click(object sender, EventArgs e)
        {
            StreamReader fluxoTexto;
            string linhaTexto;
            if (File.Exists(textBoxNomeFicheiro.Text))
            {
                textBoxConteudo.Text = "\nConteúdo do ficheiro: \n";
                fluxoTexto = new StreamReader(textBoxNomeFicheiro.Text);
                linhaTexto = fluxoTexto.ReadLine();
                while (linhaTexto != null)
                {
                    textBoxConteudo.Text = textBoxConteudo.Text + linhaTexto + "\r\n";
                    linhaTexto = fluxoTexto.ReadLine();
                }
                fluxoTexto.Close();
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxConteudo.Text = string.Empty;
            textBoxConteudo.Text = "";
            textBoxNomeFicheiro.Text = "";
            textBoxNovaLinha.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelData.Text = DateTime.Now.ToLongDateString() + " - " +
                DateTime.Now.ToLongTimeString();
        }

        private void buttonSubstituir_Click(object sender, EventArgs e)
        {
            //classes em uso: File, Directory, Path
            string nFile = textBoxNomeFicheiro.Text;
            if (nFile != "")
            {
                if (Path.GetExtension(nFile) == ".txt")
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(nFile))
                        {
                            sw.WriteLine(textBoxConteudo.Text, true);
                            Console.WriteLine("Ficheiro substituido com sucesso");
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro na substituição do contéudo:" + ex.Message);
                    }
                }
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //classes em uso: File, Directory, Path
            string nFile = textBoxNomeFicheiro.Text;
            if (nFile != "")
            {
                if (Path.GetExtension(nFile) == ".txt")
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(nFile))
                        {
                            sw.WriteLine(textBoxConteudo.Text, true);
                            Console.WriteLine("Ficheiro guardado com sucesso");
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao guardar o ficheiro:" + ex.Message);
                    }
                }
            }
        }

        private void buttonAnexarLinha_Click(object sender, EventArgs e)
        {
            //classes em uso: File, Directory, Path
            string nFile = textBoxNomeFicheiro.Text;
            if (File.Exists(nFile))
            {
                if (Path.GetExtension(nFile) == ".txt")
                {
                    if (textBoxNovaLinha.Text != "")
                    {
                        try
                        {
                            using (StreamWriter sw = new StreamWriter(nFile, true))
                            {
                                sw.WriteLine("\n\n");
                                sw.WriteLine(textBoxNovaLinha.Text, true);
                                MessageBox.Show("Ficheiro substituido com sucesso");
                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao anexar texto   :" + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Coloque alguma coisa a textBox com o texto a anexar");
                    }
                }
            }
        }

        private void buttonAbrirFicheiro_Click(object sender, EventArgs e)
        {
            buttonLerFicheiro_Click(sender, e);
        }

        private void buttonExercicio1_Click(object sender, EventArgs e)
        {
            try
            {
                string pastaAtual = Directory.GetCurrentDirectory();
                labelPastaAtual.Text = pastaAtual;
                MessageBox.Show("Pasta Atual: " + pastaAtual);
                for (int i = 1; i <= 10; i++)
                {
                    string path = pastaAtual + "\\" + 1;
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void buttonExercicio2_Click(object sender, EventArgs e)
        {

            try
            {
                string pastaAtual = Directory.GetCurrentDirectory();
                string filetxt = pastaAtual + "\\docFiles.txt";
                textBoxConteudo.Text = string.Empty;
                textBoxConteudo.Text = "Colocar ananás na pizza é um erro";
                using (StreamWriter sw = new StreamWriter(filetxt))
                    sw.WriteLine(textBoxConteudo.Text);
                MessageBox.Show("Ficheiro docFiles.txt criado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }
    }
}

