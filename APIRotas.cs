using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static System.Net.WebRequestMethods;

namespace appComercio
{
    public static class apiRotasController
    {
        private static readonly string baseUrl = "http://127.0.0.1:5000";

        public static string CadastroUsuario => $"{baseUrl}/CadastroUsuario";
        public static string CadastroLivro => $"{baseUrl}/CadastroLivro";

    }
}