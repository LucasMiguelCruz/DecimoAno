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
using System.Reflection;
namespace ex3M7_VisualizadorImagens
{
    public partial class Form1 : Form
    {
        //variaveis globais ao projeto
        DirectoryInfo pastaImagens;
        FileInfo[] ficheiros;
        int nFichEscolhido;
        int nFicheiros = 0;
        string caminhoFichEscolhido;
        bool bPlay = false;
        string ext = "*.png";
        string extJPG = "*.jpg";
        string extGIF = "*.gif";
        string extTIFF = "*.tiff";


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonPlay.Visible = false;
            numericUpDown1.Visible = false;
            bPlay = false;
            comboBox1.Visible = true;
            listBoxExtImg.Visible = true;
            timer1.Interval = 500;
            comboBox1.Items.Add("500ms");
            comboBox1.Items.Add("1000ms");
            comboBox1.Items.Add("2000ms");
            comboBox1.Items.Add("3000ms");
            
        }
        private void buttonBrowser_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                //adequar o código para permitir vários tipos de extensões
                comboBox1.Visible = true;
                listBoxExtImg.Visible = true;
                pastaImagens = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                ficheiros = pastaImagens.GetFiles(ext);
                nFicheiros = ficheiros.Length;
                if (nFicheiros != 0)
                {
                    nFichEscolhido = 0;

                    caminhoFichEscolhido = ficheiros[nFichEscolhido].FullName;
                    pictureBox1.Image = Image.FromFile(caminhoFichEscolhido);
                    numericUpDown1.Visible = true;
                    numericUpDown1.Minimum = 0;

                    numericUpDown1.Maximum = nFicheiros - 1;

                    bPlay = false;

                    buttonPlay.Visible = true;

                }
            }
        }
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (!bPlay) //bPlay==false se não está a apresentar
            {
                bPlay = true;
                buttonPlay.Text = "Pausa";
                timer1.Enabled = true;
            }
            else
            {
                bPlay = false;
                buttonPlay.Text = "Play";
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nFicheiros != 0)
            {
                try
                {
                    if (nFichEscolhido < nFicheiros - 1)
                        nFichEscolhido++;
                    else
                        nFichEscolhido = 0;
                    numericUpDown1.Value = nFichEscolhido;

                    caminhoFichEscolhido = ficheiros[nFichEscolhido].FullName;
                    pictureBox1.Image = Image.FromFile(caminhoFichEscolhido);
                    toolTip1.SetToolTip(pictureBox1, caminhoFichEscolhido);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                nFichEscolhido = (int)numericUpDown1.Value;
                caminhoFichEscolhido = ficheiros[nFichEscolhido].FullName;
                pictureBox1.Image = Image.FromFile(caminhoFichEscolhido);
                toolTip1.SetToolTip(pictureBox1, caminhoFichEscolhido);
                if (numericUpDown1.Value == numericUpDown1.Maximum - 1)
                    numericUpDown1.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            //alinea a
            if (comboBox1.Text == "500ms")
            {
                timer1.Interval = 500;
            }
            else if (comboBox1.Text == "1000ms")
            {
                timer1.Interval = 1000;
            }
            else if (comboBox1.Text == "2000ms")
            {
                timer1.Interval = 2000;
            }
            else if (comboBox1.Text == "3000ms")
            {
                timer1.Interval = 3000;
            }
        }

        private void listBoxExtImg_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //alínea b
            if ("*.png" == listBoxExtImg.SelectedItem.ToString())
            {
                ext = "*.png";
            }
            else if ("*.jpg" == listBoxExtImg.SelectedItem.ToString())
            {
                extJPG = "*.jpg";
            }
            else if ("*.gif" == listBoxExtImg.SelectedItem.ToString())
            {
                extGIF = "*.gif";
            }
            else if ("*.tiff" == listBoxExtImg.SelectedItem.ToString())
            {
                extTIFF = "*.tiff";
            }
        }
    }
}
