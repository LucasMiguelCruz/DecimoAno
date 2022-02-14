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
namespace ExFicheiro3
{
    public partial class Form1 : Form
    {
        //variaveis e constantes
        public static bool OkLogin = false;
        struct dataP
        {
            public string nome;
            public string address;
            public DateTime birthD;
            public string city;
            public string country;
        }
        //lista com dados de pessoas
        List<dataP> Pers = new List<dataP>();

        //path files
        string pathFolder = Application.StartupPath.ToString() + "\\Files";
        string pathFCountries = Application.StartupPath.ToString() + "\\Files\\countries.text";
        string pathFCities = Application.StartupPath.ToString() + "\\Files\\cities.text";
        string pathFPersons = Application.StartupPath.ToString() + "\\Files\\persons.text";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            buttonClean.Visible = false;
            buttonLoad.Visible = false;
            buttonSave.Visible = false;
            downloadToolStripMenuItem.Enabled = false;
            folderPropertiesToolStripMenuItem.Enabled = false;
            tssLabelName.Text = "Lucas Cruz";
            tssLabelDate.Text = DateTime.Now.ToLongDateString();
            LoadData();



        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OkLogin = false;
            FormLogin frm = new FormLogin();
            frm.ShowDialog();
            if (OkLogin)
            {
                tabControl1.Visible = true;
                buttonClean.Visible = true;
                buttonLoad.Visible = true;
                buttonSave.Visible = true;
                downloadToolStripMenuItem.Enabled = true;
                folderPropertiesToolStripMenuItem.Enabled = true;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            buttonClean.Visible = false;
            buttonSave.Visible = false;
            buttonLoad.Visible = false;
            downloadToolStripMenuItem.Enabled = false;
            folderToolStripMenuItem.Enabled = false;
            OkLogin = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssLabelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddCountry_Click(object sender, EventArgs e)
        {
            if (textBoxCountry.Text != string.Empty)
            {
                comboBoxCountries.Items.Add(textBoxCountry.Text);
                comboBoxPerson.Items.Add(textBoxCountry.Text);
                textBoxCountry.Text = "";
                textBoxCountry.Focus();
            }
        }

        private void buttonAddCities_Click(object sender, EventArgs e)
        {
            if (textBoxCity.Text != string.Empty)
            {
                comboBoxPersonCity.Items.Add(textBoxCity.Text);
                comboBoxPersonCity.Items.Add(textBoxCity.Text);
                textBoxCity.Text = "";
                textBoxCity.Focus();
            }
        }
        private void LoadData()
        {
            try
            {
                if (File.Exists(pathFCountries))
                {
                    StreamReader srCountries = new StreamReader(pathFCountries);
                    string s = srCountries.ReadLine();
                    if (s != null)
                    {
                        comboBoxCountries.Items.Add(s);
                        comboBoxCountry.Items.Add(s);
                        s = srCountries.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loading data error: " + ex.Message);
            }
            try
            {
                if (File.Exists(pathFCities))
                {
                    StreamReader srCities = new StreamReader(pathFCities);
                    string s = srCities.ReadLine();
                    while (s != null)
                    {
                        comboBoxCities.Items.Add(s);
                        comboBoxPersonCity.Items.Add(s);
                        s = srCities.ReadLine();
                    }
                    srCities.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loading data error: " + ex.Message);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(pathFolder))
                Directory.CreateDirectory(pathFolder);
            try
            {
                if (tabControl1.SelectedIndex == 0)
                {
                    StreamWriter sw = new StreamWriter(pathFCountries);
                    foreach (string country in comboBoxCountries.Items)
                    {
                        sw.WriteLine(country);
                    }
                    sw.Close();
                    MessageBox.Show("Countries file saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Saving data error: " + ex.Message);
            }
            if (!Directory.Exists(pathFolder))
                Directory.CreateDirectory(pathFolder);
            try
            {
                if (tabControl1.SelectedIndex == 0)
                {
                    StreamWriter sw = new StreamWriter(pathFCities);
                    foreach (string cities in comboBoxCities.Items)
                    {
                        sw.WriteLine(cities);
                    }
                    sw.Close();
                    MessageBox.Show("Cities File saved successully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Saving data error: " + ex.Message);
            }
            if (File.Exists(pathFCities))
            {
                StreamReader srCities = new StreamReader(pathFCities);
                string s = srCities.ReadLine();
                while (s != null)
                {
                    comboBoxCities.Items.Add(s);
                    comboBoxPersonCity.Items.Add(s);
                    s = srCities.ReadLine();
                }
                srCities.Close();
            }
        }
    }
}

