using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_De_Pilantra.Model
{
    internal class Presos
    {
        private static string nomepreso;
        private static string idadepreso;
        private static string cargopreso;
        private static string dataprisao;
        private static string tempopena;

        public static string Nomepreso { get => nomepreso; set => nomepreso = value; }
        public static string Idadepreso { get => idadepreso; set => idadepreso = value; }
        public static string Cargopreso { get => cargopreso; set => cargopreso = value; }
        public static string Dataprisao { get => dataprisao; set => dataprisao = value; }
        public static string TempoPena { get => tempopena; set => tempopena = value; }
    }
}
