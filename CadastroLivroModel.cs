using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appComercio
{
    public class CadastroLivroModel
    {
        public int IDLivro { get; set; }

        public int ISBNLivro { get; set; } 
        public string TituloLivro { get; set; }
        public string GeneroLivro { get; set; }
        public string NomeEditora { get; set; }
    }
}
