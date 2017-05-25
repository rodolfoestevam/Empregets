using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.atendente
{
    public interface IAtendente
    {
        void Cadastrar(Atendente atendente);

        void Alterar(Atendente atendente);

        void Remover(Atendente atendente);

        List<Atendente> Listar(Atendente filtro);

    }
}
