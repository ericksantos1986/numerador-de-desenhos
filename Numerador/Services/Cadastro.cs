using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using Numerador.Entities;

namespace Numerador.Services
{
    class Cadastro
    {
        Conexao conexao = new Conexao();

        public void cadastrarOS(Ordem ordem)
        {
            string sqlComando = "INSERT INTO OrdemDeServico (OrdemDeServico, Cliente) Values (@OrdemDeServico, @Cliente)";
            OleDbCommand comando = new OleDbCommand(sqlComando, conexao.AbrirConexao());

            comando.Parameters.Add("@OrdemDeServico", OleDbType.VarChar).Value = ordem.OrdemDeServico;
            comando.Parameters.Add("@Cliente", OleDbType.VarChar).Value = ordem.Cliente;

            try
            {
                conexao.AbrirConexao();
                comando.ExecuteNonQuery();
                Status.altStatus("Ordem de serviço " + ordem.OrdemDeServico + " cadastrada com sucesso.");
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

        public void cadastrarUsuario(Usuario usuario)
        {
            string sqlComando = "INSERT INTO Usuarios (Nome) Values (@Nome)";
            OleDbCommand comando = new OleDbCommand(sqlComando, conexao.AbrirConexao());

            comando.Parameters.Add("@Nome", OleDbType.VarChar).Value = usuario.Nome;

            try
            {
                conexao.AbrirConexao();
                comando.ExecuteNonQuery();
                Status.altStatus("Usuário " + usuario.Nome + " cadastrado com sucesso.");
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

        public void cadastrarDesenho(Ordem ordem, Numero numero, Usuario usuario)
        {
            string sqlComando = "INSERT INTO Dados (OrdemDeServico, Cliente, TipoDeDesenho, Sequencial, NumeroDoDesenho, Descricao, Usuario, Data) " +
                             "Values (@OrdemDeServico, @Cliente, @TipoDeDesenho, @Sequencial, @NumeroDoDesenho, @Descricao, @Usuario, @Data)";
            OleDbCommand comando = new OleDbCommand(sqlComando, conexao.AbrirConexao());

            comando.Parameters.Add("@OrdemDeServico", OleDbType.VarChar).Value = ordem.OrdemDeServico;
            comando.Parameters.Add("@Cliente", OleDbType.VarChar).Value = ordem.Cliente;
            comando.Parameters.Add("@TipoDeDesenho", OleDbType.VarChar).Value = numero.TipoDeDesenho;
            comando.Parameters.Add("@Sequencial", OleDbType.VarChar).Value = numero.Sequencial;
            comando.Parameters.Add("@NumeroDoDesenho", OleDbType.VarChar).Value = numero.NumeroDoDesenho;
            comando.Parameters.Add("@Descricao", OleDbType.VarChar).Value = numero.Descricao;
            comando.Parameters.Add("@Usuario", OleDbType.VarChar).Value = usuario.Nome;
            comando.Parameters.Add("@Data", OleDbType.VarChar).Value = numero.Data;

            try
            {
                conexao.AbrirConexao();
                comando.ExecuteNonQuery();
                Status.altStatus("Desenho " + numero.NumeroDoDesenho + " cadastrado com sucesso.");
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
