using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.ComponentModel;
using System.Windows.Forms;
using Numerador.Entities;

namespace Numerador.Services
{
    class Consulta
    {
        public string userWin = Environment.UserName.Replace(".", " ").ToUpper();
        public bool testUser = false;
        public List<string> UserList = new List<string>();

        Conexao conexao = new Conexao();

        public void carregarCliente(Ordem ordem)
        {
            try
            {
                string sqlComando = "Select * From OrdemDeServico Where OrdemDeServico=" + ordem.OrdemDeServico;
                conexao.AbrirConexao();
                DataSet ds = new DataSet();
                OleDbDataAdapter adapt = new OleDbDataAdapter(sqlComando, conexao.AbrirConexao());
                adapt.Fill(ds, "Ordem");
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    DialogResult confirmar = new DialogResult();
                    confirmar = MessageBox.Show("A Ordem de serviço " + ordem.OrdemDeServico + " não esta cadastrada no sistema, deseja cadastrá-la agora? ", "Numerador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmar == DialogResult.Yes)
                    {
                        FrmAddOs frm = new FrmAddOs();
                        frm.TxtOrdem.Text = ordem.OrdemDeServico.ToString();
                        frm.ShowDialog();
                    }
                    ordem.Cliente = "";
                }
                else
                {
                    ordem.Cliente = ds.Tables[0].Rows[0][1].ToString();
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message, "Numerador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ordem.Cliente = "";
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void carregarClienteAddOS(Ordem ordem)
        {
            try
            {
                string sqlComando = "Select * From OrdemDeServico Where OrdemDeServico=" + ordem.OrdemDeServico;
                conexao.AbrirConexao();
                DataSet ds = new DataSet();
                OleDbDataAdapter adapt = new OleDbDataAdapter(sqlComando, conexao.AbrirConexao());
                adapt.Fill(ds, "Ordem");
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    ordem.Cliente = "";
                }
                else
                {
                    ordem.Cliente = ds.Tables[0].Rows[0][1].ToString();
                }
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

        public void gerarSequencial(Ordem ordem, Numero numero)
        {
            try
            {
                string sqlComando = "SELECT Sequencial FROM Dados Where OrdemDeServico = " + ordem.OrdemDeServico + "And TipoDeDesenho like '" + numero.TipoDeDesenho + "'"; ;
                conexao.AbrirConexao();
                DataSet ds = new DataSet();
                OleDbDataAdapter adapt = new OleDbDataAdapter(sqlComando, conexao.AbrirConexao());
                adapt.Fill(ds, "Numero");

                int lin = ds.Tables[0].Rows.Count + 1;
                int seq = 0;

                List<int> num = new List<int>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    num.Add(int.Parse(row[0].ToString()));
                }

                for (int i = 1; i < lin; i++)
                {
                    if (num.Contains(i) == false)
                    {
                        seq = i;
                        break;
                    }
                }
                if (seq != 0)
                {
                    numero.Sequencial = seq;
                }
                else
                {
                    numero.Sequencial = lin;
                }
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

        public void carregarDataGrid(DataGridView dgv, Ordem ordem, Numero numero)
        {
            try
            {
                string sqlComando = "SELECT NumeroDoDesenho, Descricao, Usuario, Data FROM Dados Where OrdemDeServico = " + ordem.OrdemDeServico + "And TipoDeDesenho like '" + numero.TipoDeDesenho + "'";
                DataSet ds = new DataSet();
                OleDbDataAdapter adapt = new OleDbDataAdapter(sqlComando, conexao.AbrirConexao());
                adapt.Fill(ds, "Numero");
                dgv.DataSource = null;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgv.DataSource = ds.Tables[0];
                }
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

        public void carregarUsuarios(ComboBox cbx)
        {
            try
            {
                string sqlComando = "Select Nome From Usuarios";
                DataSet ds = new DataSet();
                OleDbDataAdapter adapt = new OleDbDataAdapter(sqlComando, conexao.AbrirConexao());
                adapt.Fill(ds, "Usuarios");

                cbx.Items.Clear();

                for (int i = 0; i < ds.Tables["Usuarios"].Rows.Count; i++)
                {
                    if (ds.Tables["Usuarios"].Rows[i]["Nome"].ToString() == userWin)
                    {
                        testUser = true;
                    }
                    UserList.Add(ds.Tables["Usuarios"].Rows[i]["Nome"].ToString());
                    UserList.Sort();
                }
                
                foreach(var s in UserList)
                {
                    cbx.Items.Add(s);
                }
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
        public void carregarUsuariosDgv(DataGridView dgv)
        {
            try
            {
                string sqlComando = "Select Nome From Usuarios";
                DataSet ds = new DataSet();
                OleDbDataAdapter adapt = new OleDbDataAdapter(sqlComando, conexao.AbrirConexao());
                adapt.Fill(ds, "Usuarios");

                dgv.DataSource = null;
                dgv.DataSource = ds.Tables[0];
                dgv.Sort(dgv.Columns[0], ListSortDirection.Ascending);
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

        public void verificarRegistro(Numero numero)
        {

        }
    }
}
