using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.cliente
{
    interface ICliente
    {
        void Cadastrar(Cliente cliente);

        void Alterar(Cliente cliente);

        void Remover(Cliente cliente);

        List<Cliente> Listar(Cliente filtro);
    }
}
