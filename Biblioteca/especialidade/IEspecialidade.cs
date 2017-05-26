using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.especialidade
{
    public interface IEspecialidade
    {
        //Cadastrar uma especialidade
        void CadastrarEspecialidade(Especialidade especialidade);
        //Atualizar uma especialidade
        void AtualizarEspecialidade(Especialidade especialidade);
        //Remover uma especialidade
        void RemoverEspecialidade(Especialidade especialidade);
        //Selecionar as especialidades que se encaixam no filtro de pesquisa
        List<Especialidade> ListarEspecialidade(Especialidade filtro);
        //Verificar se uma especialidade já está cadastrado
        bool VerificarExistenciaEspecialidade(Especialidade especialidade);
    }
}
