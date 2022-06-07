using System;
using System.Windows.Forms;
using Numerador.Services;
using System.ComponentModel;
using Numerador.Entities;

namespace Numerador
{
    public partial class FrmAddUser : Form
    {
        Cadastro cadastro = new Cadastro();
        Consulta consulta = new Consulta();
        Usuario usuario = new Usuario();
        Edicao edicao = new Edicao();
        FrmNum frm = new FrmNum();
        Exclusao exclusao = new Exclusao();
        DialogResult confirmar = new DialogResult();

        public FrmAddUser()
        {
            InitializeComponent();
        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            consulta.carregarUsuariosDgv(DgvUsuarios);
            ConfigDgv();
        }

        private void ConfigDgv()
        {
            DgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvUsuarios.MultiSelect = false;
            if (DgvUsuarios.DataSource != null)
            {
                DataGridViewColumn column0 = DgvUsuarios.Columns[0];
                column0.Width = 390;
                column0.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                MessageBox.Show("Por favor, preencha o campo usuário para continuar.", "Numerador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                confirmar = MessageBox.Show("Confirma o cadastramento do usuario " + TxtUsuario.Text + "? ", "Numerador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmar == DialogResult.Yes)
                {
                    cadastro.cadastrarUsuario(usuario);
                    consulta.carregarUsuariosDgv(DgvUsuarios);
                    ConfigDgv();
                    TxtUsuario.Text = "";
                    BtnAtualizar.Enabled = false;
                    BtnExcluir.Enabled = false;
                    BtnInserir.Enabled = true;
                }
            }
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (TxtUsuario.Text != "")
            {
                usuario.Nome = TxtUsuario.Text;
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                MessageBox.Show("Por favor, preencha o campo usuário para continuar.", "Numerador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string usuarioAntigo = DgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                confirmar = MessageBox.Show("Confirma a atualização do usuario " + usuarioAntigo + "? ", "Numerador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmar == DialogResult.Yes)
                {
                    edicao.atualizarUsuario(usuario, usuarioAntigo);
                    consulta.carregarUsuariosDgv(DgvUsuarios);
                    ConfigDgv();
                    TxtUsuario.Text = "";
                    BtnAtualizar.Enabled = false;
                    BtnExcluir.Enabled = false;
                    BtnInserir.Enabled = true;
                }
            }
        }

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtUsuario.Text = DgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            BtnAtualizar.Enabled = true;
            BtnExcluir.Enabled = true;
            BtnInserir.Enabled = false;

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtUsuario.Text = "";
            BtnAtualizar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnInserir.Enabled = true;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            string usuario = DgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            confirmar = MessageBox.Show("Confirma a exclusão do usuario " + usuario + "? ", "Numerador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar == DialogResult.Yes)
            {
                exclusao.excluirUsuario(usuario);
                consulta.carregarUsuariosDgv(DgvUsuarios);
                ConfigDgv();
                TxtUsuario.Text = "";
                BtnAtualizar.Enabled = false;
                BtnExcluir.Enabled = false;
                BtnInserir.Enabled = true;
            }
        }
    }
}
