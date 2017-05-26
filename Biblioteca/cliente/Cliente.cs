using Biblioteca.classesBasicas;
using Biblioteca.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.cliente
{
    public class Cliente : Pessoa
    {
        public int ID_Cliente { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }

        public Contrato Contrato { get; set; }
    }
}
