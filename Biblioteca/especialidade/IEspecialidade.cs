using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.especialidade
{
    public interface IEspecialidade
    {
        void CadastrarEspecialidade(Especialidade especialidade);
        void AtualizarEspecialidade(Especialidade especialidade);
        void RemoverEspecialidade(Especialidade especialidade);
        List<Especialidade> ListarEspecialidade(Especialidade filtro);
        bool VerificarExistenciaEspecialidade(Especialidade especialidade);
    }
}
