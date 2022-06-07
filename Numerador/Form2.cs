using System;
using System.Windows.Forms;
using Numerador.Entities;
using Numerador.Services;

namespace Numerador
{

    public partial class FrmAddOs : Form
    {
        Ordem ordem = new Ordem();
        Consulta consulta = new Consulta();
        Cadastro cadastro = new Cadastro();
        Edicao edicao = new Edicao();
        bool testar = false;
        string msg;
        DialogResult confirmar = new DialogResult();

        public FrmAddOs()
        {
            InitializeComponent();
        }

        private void testarVazios()
        {
            msg = "Todos os campos são de prenchimento obrigatório, e o(s) campo(s) abaixo está(ão) em branco, favor preenchê-los para continuar:" + Environment.NewLine;
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
            else
            {
                testar = false;
            }
        }

        private void FrmAddOs_Load(object sender, EventArgs e)
        {
        }

        private void FrmAddOs_Shown(object sender, EventArgs e)
        {
            if (TxtOrdem.Text != "")
            {
                TxtCliente.Focus();
            }
        }

        private void TxtOrdem_TextChanged(object sender, EventArgs e)
        {
            TxtCliente.Text = "";
            BtnInserir.Enabled = true;
            BtnAtualizar.Enabled = false;
            if (TxtOrdem.Text != "")
            {
                ordem.OrdemDeServico = TxtOrdem.Text;
                TxtCliente.Enabled = true;
            }
            else
            {
                TxtCliente.Enabled = false;
            }
        }

        private void TxtOrdem_Leave(object sender, EventArgs e)
        {
            if (TxtOrdem.Text != "")
            {
                consulta.carregarClienteAddOS(ordem);
                TxtCliente.Text = ordem.Cliente;
            }
            if (ordem.Cliente == "")
            {
                BtnAtualizar.Enabled = false;
                BtnInserir.Enabled = true;
            }
            else
            {
                BtnAtualizar.Enabled = true;
                BtnInserir.Enabled = false;
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
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TxtCliente_TextChanged(object sender, EventArgs e)
        {
            if (TxtCliente.Text != "")
            {
                ordem.Cliente = TxtCliente.Text;
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
                confirmar = MessageBox.Show("Confirma o cadastramento da ordem de serviço " + ordem.OrdemDeServico + "? ", "Numerador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmar == DialogResult.Yes)
                {
                    cadastro.cadastrarOS(ordem);
                    TxtCliente.Text = "";
                    TxtOrdem.Text = "";
                    TxtOrdem.Focus();
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtCliente.Text = "";
            TxtOrdem.Text = "";
            TxtOrdem.Focus();
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
                confirmar = MessageBox.Show("Confirma a atualização da ordem de serviço " + ordem.OrdemDeServico + "? ", "Numerador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmar == DialogResult.Yes)
                {
                    string cliente = TxtCliente.Text;
                    edicao.atualizarOrdem(ordem, cliente);
                    TxtCliente.Text = "";
                    TxtOrdem.Text = "";
                    TxtOrdem.Focus();
                }
            }
        }
    }
}
