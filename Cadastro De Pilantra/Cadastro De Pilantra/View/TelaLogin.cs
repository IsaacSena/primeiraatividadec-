using Cadastro_De_Pilantra.Controller;
using Cadastro_De_Pilantra.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_De_Pilantra.View
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EsqueceuSenha telaEsqueceuSenha = new EsqueceuSenha();

            telaEsqueceuSenha.Show();

            this.Hide();

        }

        private void EntrarLogin_Click(object sender, EventArgs e)
        {
           

            Login.Email = tbx_email.Text;
            Login.Senha = tbx_senha.Text;

            ControllerLogin controllerLogin = new ControllerLogin();
            controllerLogin.EnviarBancoLogin();

            TelaCadastro telaCadastro = new TelaCadastro();

            telaCadastro.Show();

            this.Hide();


        }
    }
}
