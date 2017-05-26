using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.contrato
{
   public interface IContrato
    {
        void Cadastrar(Contrato contrato);

        void Alterar(Contrato contrato);

        void Remover(Contrato contrato);

        List<Contrato> Listar(Contrato filtro);
    }
}
