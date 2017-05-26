using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.utils
{
    interface IConexaoSQL
    {
        SqlConnection abrirConexao();

        void fecharConexao(); 


    }
}
