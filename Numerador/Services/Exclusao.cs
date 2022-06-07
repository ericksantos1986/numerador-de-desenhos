using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Numerador.Services
{
    class Exclusao
    {
        Conexao conexao = new Conexao();

        public void excluirDesenho(string num)
        {
            string sqlComando = "DELETE FROM Dados Where NumeroDoDesenho like '" + num + "'";

            OleDbCommand comando = new OleDbCommand(sqlComando, conexao.AbrirConexao());

            try
            {
                conexao.AbrirConexao();
                comando.ExecuteNonQuery();
                Status.altStatus("Desenho " + num + " excluído com sucesso.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message, "Numerador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void excluirUsuario(string usuario)
        {
            string sqlComando = "DELETE FROM Usuarios Where Nome like '" + usuario + "'";

            OleDbCommand comando = new OleDbCommand(sqlComando, conexao.AbrirConexao());

            try
            {
                conexao.AbrirConexao();
                comando.ExecuteNonQuery();
                Status.altStatus("Usuário " + usuario + " excluído com sucesso.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message, "Numerador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
    }
}
