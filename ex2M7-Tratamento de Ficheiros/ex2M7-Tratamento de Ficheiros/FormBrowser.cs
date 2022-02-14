using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2M7_Tratamento_de_Ficheiros
{
    public partial class FormBrowser : Form
    {
        public FormBrowser()
        {
            InitializeComponent();
        }

        private void FormBrowser_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Form1.link);
            System.Diagnostics.Process.Start(Form1.link);
        }
    }
}
