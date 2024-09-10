using Cadastro_De_Pilantra.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_De_Pilantra.Controller
{
    internal class ControllerPresos
    {
        public void EnviarBancoPreso() 
        {
            SqlConnection pe = new SqlConnection(ConexaoPresos.ConectarPresos());
            SqlCommand cmdpe = new SqlCommand("CadastroPresos", pe);
            cmdpe.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmdpe.Parameters.AddWithValue("@nomepreso", Presos.Nomepreso);
                cmdpe.Parameters.AddWithValue("@idadepreso", Presos.Idadepreso);
                cmdpe.Parameters.AddWithValue("@cargopreso", Presos.Cargopreso);
                cmdpe.Parameters.AddWithValue("@dataprisao", Presos.Dataprisao);
                cmdpe.Parameters.AddWithValue("@tempopena", Presos.TempoPena);

                pe.Open();
                cmdpe.ExecuteNonQuery();
                MessageBox.Show("Vagabundo cadastrado com sucesso");
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
