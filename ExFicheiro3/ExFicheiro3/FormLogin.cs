using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExFicheiro3
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((textBoxUserName.Text == "Adm") && (textBoxPassWord.Text == "ADEMIRO"))
            {
                Form1.OkLogin = true;
                this.Close();
            }
            else
            {
                textBoxUserName.Text = "";
                textBoxPassWord.Text = "";
                textBoxUserName.Focus();
                MessageBox.Show("Username/Password incorrect!");

            }
        }

        private void linkLabelClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabelCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        
        private void textBoxPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                CheckLogin();

        }
        private void CheckLogin()
        {
            if ((textBoxUserName.Text == "admin") && (textBoxPassWord.Text == "1234"))
            {
                Form1.OkLogin = true;
                this.Close();
            }
            else
            {
                textBoxUserName.Text = "";
                textBoxPassWord.Text = "";
                textBoxUserName.Focus();
                MessageBox.Show("username/password incorrect!");
            }
        }
    }

}
