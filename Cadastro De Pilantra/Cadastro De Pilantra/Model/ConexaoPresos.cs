using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_De_Pilantra.Model
{
    internal class ConexaoPresos
    {
        public static string ConectarPresos()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\isaac\source\repos\Cadastro De Pilantra\Cadastro De Pilantra\Dados\bdPolicia.mdf"";Integrated Security=True";        
        }
    }
}
