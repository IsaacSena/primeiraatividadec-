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
    public partial class EsqueceuSenha : Form
    {
        public EsqueceuSenha()
        {
            InitializeComponent();
        }

        private void ConfirmarRecuperar_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();

            telaLogin.Show();

            this.Hide();

            MessageBox.Show("Senha alterada com sucesso");
        }
    }
}
