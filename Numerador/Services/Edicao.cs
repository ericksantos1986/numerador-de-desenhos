using System;
using System.Data.OleDb;
using System.Windows.Forms;
using Numerador.Entities;

namespace Numerador.Services
{
    class Edicao
    {
        Conexao conexao = new Conexao();

        public void atualizarDesenho(Ordem ordem, Numero numero, Usuario usuario, string num)
        {
            string sqlComando = "UPDATE Dados SET OrdemDeServico=@OrdemDeServico, Cliente=@Cliente, TipoDeDesenho=@TipoDeDesenho, NumeroDoDesenho=@NumeroDoDesenho," +
                                "Descricao=@Descricao, Usuario=@Usuario, Data=@Data Where NumeroDoDesenho like '" + num + "'";

            OleDbCommand comando = new OleDbCommand(sqlComando, conexao.AbrirConexao());

            comando.Parameters.AddWithValue("@OrdemDeServico", ordem.OrdemDeServico);
            comando.Parameters.AddWithValue("@Cliente", ordem.Cliente);
            comando.Parameters.AddWithValue("@TipoDeDesenho", numero.TipoDeDesenho);
            comando.Parameters.AddWithValue("@NumeroDoDesenho", num);
            comando.Parameters.AddWithValue("@Descricao", numero.Descricao);
            comando.Parameters.AddWithValue("@Usuario", usuario.Nome);
            comando.Parameters.AddWithValue("@Data", numero.Data);

            try
            {
                conexao.AbrirConexao();
                comando.ExecuteNonQuery();
                Status.altStatus("Desenho " + num + " atualizado com sucesso.");
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

        public void atualizarOrdem(Ordem ordem, string cliente)
        {
            string sqlComando = "UPDATE OrdemDeServico SET OrdemDeServico=@OrdemDeServico, Cliente=@Cliente Where OrdemDeServico=" + ordem.OrdemDeServico;
            OleDbCommand comando = new OleDbCommand(sqlComando, conexao.AbrirConexao());

            comando.Parameters.AddWithValue("@OrdemDeServico", ordem.OrdemDeServico);
            comando.Parameters.AddWithValue("@Cliente", cliente);

            try
            {
                conexao.AbrirConexao();
                comando.ExecuteNonQuery();
                Status.altStatus("Ordem de Serviço " + ordem.OrdemDeServico + " atualizada com sucesso.");
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

        public void atualizarUsuario(Usuario usuario, string usuarioAntigo)
        {
            string sqlComando = "UPDATE Usuarios SET Nome=@Nome Where Nome='" + usuarioAntigo + "'";
            OleDbCommand comando = new OleDbCommand(sqlComando, conexao.AbrirConexao());

            comando.Parameters.AddWithValue("@Nome", usuario.Nome);

            try
            {
                conexao.AbrirConexao();
                comando.ExecuteNonQuery();
                Status.altStatus("Usuário " + usuario.Nome + " atualizado com sucesso.");
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

