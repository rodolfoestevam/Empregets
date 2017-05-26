using Biblioteca.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.cliente
{
    public class ClienteBD : ConexaoSQL, ICliente
    {
        public void Alterar(Cliente cliente)
        {
            try
            {
                this.abrirConexao();
                string sql = "UPDATE Cliente SET ID_Cliente = @ID_Cliente, @Nome, @CPF, @Telefone," +
                    "@Celular, @Email, @Sexo, @Logradouro, @Numero," +
                    "@Complemento, @UF, @Bairro, @Cidade, @CEP, @RazaoSocial, @CNPJ; ";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.fecharConexao();
            }
            catch (Exception err)
            {
                throw new Exception("Erro ao atualizar cliente" + err);
            }

        }

        public void Cadastrar(Cliente cliente)
        {
            try
            {
                this.abrirConexao();
                string sql = "INSERT INTO Cliente (ID_Cliente, Nome, CPF, Telefone, Celular, Email, Sexo," +
                    "Complemento, Logradouro, Numero, UF, Bairro, Cidade, CEP, RazaoSocial, CNPJ)"
                    +
                    "VALUES (@ID_Atendente, @Nome, @CPF, @Telefone, @Celular, @Email, @Sexo, @Logradouro, @Numero," +
                    "@Complemento, @UF, @Bairro, @Cidade, @CEP, @RazaoSocial, @CNPJ);";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.fecharConexao();
            }
            catch (Exception err)
            {
                throw new Exception("Erro ao cadastrar cliente" + err);
            }
        }

        public List<Cliente> Listar(Cliente filtro)
        {
            List<Cliente> retornolist = new List<Cliente>();
            try
            {
                this.abrirConexao();

                string sql = "SELECT ID_Cliente, Nome, CPF, Telefone, Celular, Email, Sexo," +
                    "Complemento, Logradouro, Numero, UF, Bairro, Cidade, CEP," +
                    "RazaoSocial, CNPJ From Cliente where 1=1;";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                SqlDataReader DBReader = cmd.ExecuteReader();

                while (DBReader.Read())
                {
                    Cliente cliente = new Cliente();

                    retornolist.Add(cliente);
                }
                DBReader.Close();
                cmd.Dispose();
                this.fecharConexao();
            }
            catch (Exception err)
            {
                throw new Exception("Erro ao listar clientes " + err.Message);
            }
            return retornolist;
        }
        public void Remover(Cliente cliente)
        {
            try
            {
                this.abrirConexao();

                string sql = "DELETE Cliente WHERE ID_Cliente = @ID_Cliente";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
            }
            catch (Exception err)
            {
                throw new Exception("Erro ao deletar cliente " + err.Message);
            }

        }
    }
}
