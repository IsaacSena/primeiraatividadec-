using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_De_Pilantra.Model
{
    internal class Login
    {
        private static int codigo;
        private static string email;
        private static string senha;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string Email { get => email; set => email = value; }
        public static string Senha { get => senha; set => senha = value; }
    }
}
