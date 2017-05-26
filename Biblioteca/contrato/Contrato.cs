using Biblioteca.administrador;
using Biblioteca.atendente;
using Biblioteca.cliente;
using Biblioteca.contrato_diarista;
using Biblioteca.localidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.contrato
{
    public class Contrato

    {
        public int ID_Contrato { get; set; }
        public DateTime Data_Inicio { get; set; }
        public DateTime Data_Fim { get; set; }
        public double valor { get; set; }
        public string observacoes { get; set; }

        public Localidade localidade { get; set; }
        public ContratoDiarista contratoDiarista { get; set; }
        public Atendente atendente { get; set; }
        public Cliente cliente { get; set; }
        public Administrador administrador { get; set; }

        public Contrato(DateTime Data_Inicio, DateTime Data_Fim, Localidade localidade, ContratoDiarista contratoDiarista, Atendente atendente, Cliente cliente, Administrador administrador)
        {
            this.localidade = localidade;
            this.contratoDiarista = contratoDiarista;
            this.atendente = atendente;
            this.cliente = cliente;
            this.administrador = administrador;
        }
    }

}

