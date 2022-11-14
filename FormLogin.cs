using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_Username
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnAcesso_Click(object sender, EventArgs e)
        {
            string User = "admin";
            string Password = "admin";

            if (TxtUsuario.Text == User & TxtSenha.Text == Password)
                
            {
                MessageBox.Show("Acesso liberado!!");
                Form1 FrmMain = new Form1();
                FrmMain.Show();
                this.Hide();

            }
            else 
            {
                MessageBox.Show("Usuário ou senha incorretos!!");
            }

        }
    }
}
