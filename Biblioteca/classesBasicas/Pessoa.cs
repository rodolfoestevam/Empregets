﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.classesBasicas
{
    public abstract class Pessoa
    {
        public String Nome { get; set; }
        public String RG { get; set; }
        public String CPF { get; set; }
        public String Telefone { get; set; }
        public String Celular { get; set; }
        public String Email { get; set; }
        public DateTime dataNascimento { get; set; }
        public String sexo { get; set; }

        private Endereco Endereco { get; set; }

        public Pessoa()
        {
            Endereco = new Endereco();
        }
    }
}
