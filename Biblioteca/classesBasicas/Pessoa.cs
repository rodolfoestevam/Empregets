using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.classesBasicas
{
    public abstract class Pessoa
    {
        private String Nome { get; set; }
        private String RG { get; set; }
        private string CPF { get; set; }
        private String Telefone { get; set; }
        private String Celular { get; set; }
        private String Email { get; set; }
        private DateTime dataNascimento { get; set; }
        private String sexo { get; set; }

        private Endereco Endereco { get; set; }

        public Pessoa()
        {
            Endereco = new Endereco();
        }
    }
}
