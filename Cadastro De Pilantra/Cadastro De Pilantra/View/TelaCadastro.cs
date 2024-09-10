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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void botaopreso_Click(object sender, EventArgs e)
        {
            Presos.Nomepreso = tbx_nomepreso.Text;
            Presos.Idadepreso = tbx_idadepreso.Text;
            Presos.Cargopreso = tbx_cargopreso.Text;
            Presos.Dataprisao = tbx_datahorapreso.Text;
            Presos.TempoPena = cbx_penapreso.Text;

            ControllerPresos controllerPresos = new ControllerPresos();
            controllerPresos.EnviarBancoPreso();

            TelaCadastro telaCadastro = new TelaCadastro();

            telaCadastro.Show();

            this.Hide();

        }


    }
}
