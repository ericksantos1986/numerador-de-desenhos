using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.ComponentModel;
using Numerador.Entities;
using Numerador.Services;

namespace Numerador
{
    public partial class FrmNum : Form
    {
        Ordem ordem = new Ordem();
        Consulta consulta = new Consulta();
        Numero numero = new Numero();
        Usuario usuario = new Usuario();
        Cadastro cadastro = new Cadastro();
        Edicao edicao = new Edicao();
        Exclusao exclusao = new Exclusao();
        bool testar = false;
        string msg;
        DialogResult confirmar = new DialogResult();

        public FrmNum()
        {
            InitializeComponent();

            TxtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            consulta.carregarUsuarios(CbxUser);

            if (consulta.testUser)
            {
                CbxUser.Text = consulta.userWin;
            }

            if (consulta.userWin == "GERALDO SILVA" || consulta.userWin == "ERICK SANTOS")
            {
                BtnAddUser.Enabled = true;
            }

        }

        private void FrmNum_Load(object sender, EventArgs e)
        {
            //consulta.carregarUsuarios(CbxUser);
            //if (TxtOrdem.Text != "" && CbxTipo.Text != "")
        }

        private void testarVazios()
        {
            msg = "Todos os campos são de prenchimento obrigatório, e o(s) campo(s) abaixo está(ão) em branco, favor preenchê-lo(s) para continuar:" + Environment.NewLine;

            if (TxtOrdem.Text == "")
            {
                msg += Environment.NewLine + "- Ordem de Serviço";
                testar = true;
            }
            if (TxtCliente.Text == "")
            {
                msg += Environment.NewLine + "- Cliente";
                testar = true;
            }
            if (CbxTipo.Text == "")
            {
                msg += Environment.NewLine + "- Tipo de Desenho";
                testar = true;
            }
            if (CbxUser.Text == "")
            {
                msg += Environment.NewLine + "- Usuário";
                testar = true;
            }
            if (TxtData.Text == "")
            {
                msg += Environment.NewLine + "- Data";
                testar = true;
            }
            if (TxtNumDes.Text == "")
            {
                msg += Environment.NewLine + "- Número do Desenho";
                testar = true;
            }
            if (TxtDescr.Text == "")
            {
                msg += Environment.NewLine + "- Descrição";
                testar = true;
            }
            else
            {
                testar = false;
            }
        }

        private void ConfigDgv()
        {
                DgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DgvDados.MultiSelect = false;
            if (DgvDados.DataSource != null)
            {
                DataGridViewColumn column0 = DgvDados.Columns[0];
                column0.Width = 160;
                column0.HeaderText = "Número do Desenho";
                DataGridViewColumn column1 = DgvDados.Columns[1];
                column1.Width = 370;
                column1.HeaderText = "Descrição";
                DataGridViewColumn column2 = DgvDados.Columns[2];
                column2.Width = 175;
                column2.HeaderText = "Usuário";
                DataGridViewColumn column3 = DgvDados.Columns[3];
                column3.Width = 120;
                column3.HeaderText = "Data";
                lblQuant.Text = DgvDados.Rows.Count.ToString() + " desenho(s) encontrado(s)";
                DgvDados.Sort(DgvDados.Columns[0], ListSortDirection.Ascending);
                DgvDados.CurrentCell = DgvDados.Rows[DgvDados.Rows.Count - 1].Cells[0];
            }
            else
            {
                lblQuant.Text = string.Empty;
            }
        }

        private void limparFrm()
        {
            DialogResult limpar = new DialogResult();
            limpar = MessageBox.Show("Deseja limpar os dados do formuário?", "Numerador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (limpar == DialogResult.Yes)
            {
                CbxTipo.SelectedIndex = -1;
                TxtNumDes.Text = "";
                TxtOrdem.Text = "";
                TxtDescr.Text = "";
                BtnExcluir.Enabled = false;
                BtnLote.Enabled = false;
                BtnAtualizar.Enabled = false;
                BtnInserir.Enabled = true;
                TxtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
                TxtOrdem.Focus();
                toolStripStatusLabel1.Text = "";
            }
        }

        private void TxtOrdem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void TxtOrdem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Enter))
            {
                e.Handled = true;
            }
        }

        private void TxtOrdem_TextChanged(object sender, EventArgs e)
        {
            if (TxtOrdem.Text != "")
            {
                ordem.OrdemDeServico = TxtOrdem.Text;
                TxtCliente.Text = "";
                BtnInserir.Enabled = true;
                BtnAtualizar.Enabled = false;
                BtnExcluir.Enabled = false;
                TxtDescr.Text = "";
            }
            else
            {
                TxtCliente.Text = "";
                TxtDescr.Text = "";
                lblQuant.Text = "";
                toolStripStatusLabel1.Text = "";
            }
        }

        private void TxtOrdem_Leave(object sender, EventArgs e)
        {
            if (TxtOrdem.Text != "")
            {
                consulta.carregarCliente(ordem);
                TxtCliente.Text = ordem.Cliente;
                TxtCliente.Select(0, 0);
            }
            else
            {
                TxtCliente.Text = "";
            }
        }

        private void TxtCliente_TextChanged(object sender, EventArgs e)
        {
            if (TxtCliente.Text != "")
            {
                CbxTipo.Enabled = true;
            }
            else
            {
                CbxTipo.SelectedIndex = -1;
                DgvDados.DataSource = null;
                TxtNumDes.Text = "";
                CbxTipo.Enabled = false;
            }
        }

        private void CbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxTipo.SelectedIndex >= 0)
            {
                BtnLote.Enabled = true;
                numero.TipoDeDesenho = CbxTipo.SelectedIndex + 1;
                consulta.gerarSequencial(ordem, numero);
                numero.GerarNumero(ordem);
                consulta.carregarDataGrid(DgvDados, ordem, numero);
                ConfigDgv();
                TxtNumDes.Text = numero.NumeroDoDesenho;
            }
            else
            {
                BtnLote.Enabled = false;
            }
            TxtDescr.Text = "";
            BtnInserir.Enabled = true;
            BtnExcluir.Enabled = false;
            BtnAtualizar.Enabled = false;
            TxtData.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void BtnAddOs_Click(object sender, EventArgs e)
        {
            FrmAddOs frm = new FrmAddOs();
            frm.ShowDialog();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            FrmAddUser frm = new FrmAddUser();
            frm.ShowDialog();
        }

        private void btnLote_Click(object sender, EventArgs e)
        {
            //    FrmLote frm = new FrmLote();
            //    frm.ShowDialog();
        }

        private void TxtDescr_TextChanged(object sender, EventArgs e)
        {
            if (TxtDescr.Text != "")
            {
                numero.Descricao = TxtDescr.Text;
            }
        }

        private void TxtData_TextChanged(object sender, EventArgs e)
        {
            if (TxtData.Text != "")
            {
                numero.Data = DateTime.Parse(TxtData.Text);
            }
        }

        private void CbxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxUser.Text != "")
            {
                usuario.Nome = CbxUser.Text;
            }
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            testarVazios();
            if (testar)
            {
                MessageBox.Show(msg, "Numerador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                confirmar = MessageBox.Show("Confirma o cadastramento do desenho " + numero.NumeroDoDesenho + "? ", "Numerador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmar == DialogResult.Yes)
                {
                    cadastro.cadastrarDesenho(ordem, numero, usuario);
                    consulta.gerarSequencial(ordem, numero);
                    numero.GerarNumero(ordem);
                    consulta.carregarDataGrid(DgvDados, ordem, numero);
                    ConfigDgv();
                    TxtNumDes.Text = numero.NumeroDoDesenho;
                    TxtDescr.Text = "";
                    TxtDescr.Focus();
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            limparFrm();
        }

        private void DgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                TxtNumDes.Text = DgvDados.CurrentRow.Cells[0].Value.ToString();
                TxtDescr.Text = DgvDados.CurrentRow.Cells[1].Value.ToString();
                CbxUser.Text = DgvDados.CurrentRow.Cells[2].Value.ToString();
                TxtData.Text = DateTime.Parse(DgvDados.CurrentRow.Cells[3].Value.ToString()).ToString("dd/MM/yyyy");
                BtnAtualizar.Enabled = true;
                BtnInserir.Enabled = false;
                BtnExcluir.Enabled = true;
                TxtDescr.Focus();
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            testarVazios();
            if (testar)
            {
                MessageBox.Show(msg, "Numerador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string num = TxtNumDes.Text;
                confirmar = MessageBox.Show("Confirma a atualização do desenho " + num + "? ", "Numerador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmar == DialogResult.Yes)
                {
                    edicao.atualizarDesenho(ordem, numero, usuario, num);
                    consulta.gerarSequencial(ordem, numero);
                    numero.GerarNumero(ordem);
                    consulta.carregarDataGrid(DgvDados, ordem, numero);
                    ConfigDgv();
                    TxtNumDes.Text = numero.NumeroDoDesenho;
                    TxtDescr.Text = "";
                    TxtDescr.Focus();
                    TxtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
                }
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            string num = TxtNumDes.Text;
            confirmar = MessageBox.Show("Confirma a exclusão do desenho " + num + "? ", "Numerador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar == DialogResult.Yes)
            {
                exclusao.excluirDesenho(num);
                consulta.gerarSequencial(ordem, numero);
                numero.GerarNumero(ordem);
                consulta.carregarDataGrid(DgvDados, ordem, numero);
                ConfigDgv();
                TxtNumDes.Text = numero.NumeroDoDesenho;
                TxtDescr.Text = "";
                TxtDescr.Focus();
                BtnAtualizar.Enabled = false;
                BtnInserir.Enabled = true;
                BtnExcluir.Enabled = false;
                TxtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
        }

        private void FrmNum_Activated(object sender, EventArgs e)
        {
            if (TxtOrdem.Text != "" && CbxTipo.SelectedIndex > -1)
            {
                consulta.gerarSequencial(ordem, numero);
                numero.GerarNumero(ordem);
                consulta.carregarDataGrid(DgvDados, ordem, numero);
                TxtNumDes.Text = numero.NumeroDoDesenho;
                ConfigDgv();
            }
        }
    }
}

