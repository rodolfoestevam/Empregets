using Biblioteca.utils;
using Biblioteca.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.atendente
{
    public class AtendenteBD : IAtendente
    {

        public void Cadastrar(Atendente atendente)
        {
            try
            {
                IConexaoSQL con = ConexaoSQL.getInstance();
                SqlConnection instanceOfConnection = con.abrirConexao();
                string sql = "INSERT INTO Atendente (ID_Atendente, Nome, CPF, Telefone, Celular, Email, Sexo, Logradouro, Numero," +
                    "Complemento, UF, Bairro, Cidade, CEP)" 
                    +
                    "VALUES (@ID_Atendente, @Nome, @CPF, @Telefone, @Celular, @Email, @Sexo, @Logradouro, @Numero," +
                    "@Complemento, @UF, @Bairro, @Cidade);";

                SqlCommand cmd = new SqlCommand(sql, instanceOfConnection);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.fecharConexao();


            }
            catch (Exception err)
            {
                throw new Exception("Erro ao cadastrar atendente!" + err);
            }

        }
        public void Alterar(Atendente atendente)
        {
            try
            {
                IConexaoSQL con = ConexaoSQL.getInstance();
                SqlConnection instanceOfConnection = con.abrirConexao();
                string sql = "UPDATE Atendente SET ID_Atendente = @ID_Atendente, @Nome, @CPF, @Telefone," +
                    "@Celular, @Email, @Sexo, @Logradouro, @Numero," +
                    "@Complemento, @UF, @Bairro, @Cidade;";

                SqlCommand cmd = new SqlCommand(sql, instanceOfConnection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.fecharConexao();
            }
            catch (Exception err)
            {
                throw new Exception("Erro ao atualizar atendente!" + err);
            }

        }

        public void Remover(Atendente atendente)
        {
            try
            {
                IConexaoSQL con = ConexaoSQL.getInstance();
                SqlConnection instanceOfConnection = con.abrirConexao();

                string sql = "DELETE Atendente WHERE ID_Atendente = @ID_Atendente";

                SqlCommand cmd = new SqlCommand(sql, instanceOfConnection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.fecharConexao();
            }
            catch (Exception err)
            {
                throw new Exception("Erro ao remover atendente" + err.Message);
            }
        }


        public List<Atendente> Listar(Atendente filtro)
        {
            List<Atendente> retornoList = new List<Atendente>();
            try
            {
                IConexaoSQL con = ConexaoSQL.getInstance();
                SqlConnection instanceOfConnection = con.abrirConexao();

                string sql = "SELECT ID_Atendente, Nome, CPF, Telefone, Celular, Email, Sexo, Logradouro, Numero," +
                    "Complemento, UF, Bairro, Cidade, CEP FROM Atendente WHERE 1=1;";

                SqlCommand cmd = new SqlCommand(sql, instanceOfConnection);
                SqlDataReader DBReader = cmd.ExecuteReader();

                while (DBReader.Read())
                {
                    Atendente atendente = new Atendente();

                    retornoList.Add(atendente);
                }

                DBReader.Close();
                cmd.Dispose();
                con.fecharConexao();
            }
            catch (Exception e)
            {

                throw new Exception("Erro ao conectar e selecionar." + e.Message);
            }
            return retornoList;
        }
    }
}
    




