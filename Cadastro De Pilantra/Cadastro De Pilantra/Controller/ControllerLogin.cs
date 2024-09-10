using Cadastro_De_Pilantra.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_De_Pilantra.Controller
{
    internal class ControllerLogin
    {
        public void EnviarBancoLogin()
        {
            SqlConnection lg = new SqlConnection(Conexao.Conectar());
            SqlCommand cmdlg = new SqlCommand("CadastroLogin", lg);
            cmdlg.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmdlg.Parameters.AddWithValue("@email", Login.Email);
                cmdlg.Parameters.AddWithValue("@senha", Login.Senha);

                lg.Open();
                cmdlg.ExecuteNonQuery();
               
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
