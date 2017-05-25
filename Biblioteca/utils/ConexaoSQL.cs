using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Utils
{
    public class ConexaoSQL
    {
        #region variáveis

        public SqlConnection sqlConn;

        private const string local = @"TURING-PC\SQLEXPRESS";

        private const string banco_de_dados = "teste";

        private const string usuario = "dolfo";

        private const string senha = "123";
        #endregion

        string connectionStringSqlServer = @"Data Source=" + local + ";Initial Catalog=" + banco_de_dados + ";UId=" + usuario + ";Password=" + senha + ";";

        public void abrirConexao()
        {
            this.sqlConn = new SqlConnection(connectionStringSqlServer);

            this.sqlConn.Open();
        }
        public void fecharConexao()
        {

            sqlConn.Close();

            sqlConn.Dispose();
        }
    }
}
