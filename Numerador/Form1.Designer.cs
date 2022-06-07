namespace Numerador
{
    partial class FrmNum
    {

        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNum));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtOrdem = new System.Windows.Forms.TextBox();
            this.TxtNumDes = new System.Windows.Forms.TextBox();
            this.TxtDescr = new System.Windows.Forms.TextBox();
            this.CbxTipo = new System.Windows.Forms.ComboBox();
            this.CbxUser = new System.Windows.Forms.ComboBox();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnAddOs = new System.Windows.Forms.Button();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.DgvDados = new System.Windows.Forms.DataGridView();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.lblQuant = new System.Windows.Forms.Label();
            this.BtnLote = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordem de Serviço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo do Desenho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Usuário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(712, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Numero do Desenho";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Descrição";
            // 
            // TxtOrdem
            // 
            this.TxtOrdem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOrdem.Location = new System.Drawing.Point(134, 21);
            this.TxtOrdem.Name = "TxtOrdem";
            this.TxtOrdem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtOrdem.Size = new System.Drawing.Size(80, 22);
            this.TxtOrdem.TabIndex = 0;
            this.TxtOrdem.Tag = "Ordem de Serviço";
            this.TxtOrdem.TextChanged += new System.EventHandler(this.TxtOrdem_TextChanged);
            this.TxtOrdem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtOrdem_KeyDown);
            this.TxtOrdem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOrdem_KeyPress);
            this.TxtOrdem.Leave += new System.EventHandler(this.TxtOrdem_Leave);
            // 
            // TxtNumDes
            // 
            this.TxtNumDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumDes.Location = new System.Drawing.Point(150, 99);
            this.TxtNumDes.Name = "TxtNumDes";
            this.TxtNumDes.ReadOnly = true;
            this.TxtNumDes.Size = new System.Drawing.Size(167, 22);
            this.TxtNumDes.TabIndex = 4;
            this.TxtNumDes.Tag = "Número do Desenho";
            // 
            // TxtDescr
            // 
            this.TxtDescr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescr.Location = new System.Drawing.Point(431, 99);
            this.TxtDescr.Name = "TxtDescr";
            this.TxtDescr.Size = new System.Drawing.Size(429, 22);
            this.TxtDescr.TabIndex = 5;
            this.TxtDescr.Tag = "Descrição";
            this.TxtDescr.TextChanged += new System.EventHandler(this.TxtDescr_TextChanged);
            // 
            // CbxTipo
            // 
            this.CbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTipo.Enabled = false;
            this.CbxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxTipo.FormattingEnabled = true;
            this.CbxTipo.Items.AddRange(new object[] {
            "001 - Placa de Identificação",
            "002 - Desenho de Conjunto",
            "003 - Diagramas Elétricos",
            "004 - Bobinas e Parte Ativa",
            "005 - Chaparia e Usinagem",
            "006 - Acessórios",
            "007 - Desenhos de Aprovação"});
            this.CbxTipo.Location = new System.Drawing.Point(130, 59);
            this.CbxTipo.Name = "CbxTipo";
            this.CbxTipo.Size = new System.Drawing.Size(228, 24);
            this.CbxTipo.TabIndex = 2;
            this.CbxTipo.Tag = "Tipo de Desenho";
            this.CbxTipo.SelectedIndexChanged += new System.EventHandler(this.CbxTipo_SelectedIndexChanged);
            // 
            // CbxUser
            // 
            this.CbxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxUser.FormattingEnabled = true;
            this.CbxUser.Items.AddRange(new object[] {
            "Erick Santos"});
            this.CbxUser.Location = new System.Drawing.Point(455, 59);
            this.CbxUser.Name = "CbxUser";
            this.CbxUser.Size = new System.Drawing.Size(190, 24);
            this.CbxUser.TabIndex = 3;
            this.CbxUser.Tag = "Usuário";
            this.CbxUser.SelectedIndexChanged += new System.EventHandler(this.CbxUser_SelectedIndexChanged);
            // 
            // BtnInserir
            // 
            this.BtnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInserir.Location = new System.Drawing.Point(785, 137);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(75, 24);
            this.BtnInserir.TabIndex = 6;
            this.BtnInserir.Text = "&Inserir";
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Enabled = false;
            this.BtnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.Location = new System.Drawing.Point(623, 137);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(75, 24);
            this.BtnAtualizar.TabIndex = 8;
            this.BtnAtualizar.Text = "&Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(542, 137);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 24);
            this.BtnLimpar.TabIndex = 9;
            this.BtnLimpar.Text = "&Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnAddOs
            // 
            this.BtnAddOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddOs.Location = new System.Drawing.Point(836, 20);
            this.BtnAddOs.Name = "BtnAddOs";
            this.BtnAddOs.Size = new System.Drawing.Size(24, 24);
            this.BtnAddOs.TabIndex = 12;
            this.BtnAddOs.TabStop = false;
            this.BtnAddOs.Text = "+";
            this.BtnAddOs.UseVisualStyleBackColor = true;
            this.BtnAddOs.Click += new System.EventHandler(this.BtnAddOs_Click);
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Enabled = false;
            this.BtnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddUser.Location = new System.Drawing.Point(651, 59);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(24, 24);
            this.BtnAddUser.TabIndex = 11;
            this.BtnAddUser.TabStop = false;
            this.BtnAddUser.Text = "+";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // TxtData
            // 
            this.TxtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtData.Location = new System.Drawing.Point(755, 60);
            this.TxtData.MaxLength = 10;
            this.TxtData.Name = "TxtData";
            this.TxtData.ReadOnly = true;
            this.TxtData.Size = new System.Drawing.Size(105, 22);
            this.TxtData.TabIndex = 4;
            this.TxtData.TabStop = false;
            this.TxtData.Tag = "Data";
            this.TxtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtData.TextChanged += new System.EventHandler(this.TxtData_TextChanged);
            // 
            // DgvDados
            // 
            this.DgvDados.AllowUserToAddRows = false;
            this.DgvDados.AllowUserToDeleteRows = false;
            this.DgvDados.AllowUserToResizeColumns = false;
            this.DgvDados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDados.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDados.Location = new System.Drawing.Point(14, 177);
            this.DgvDados.Name = "DgvDados";
            this.DgvDados.ReadOnly = true;
            this.DgvDados.RowHeadersVisible = false;
            this.DgvDados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDados.Size = new System.Drawing.Size(846, 434);
            this.DgvDados.TabIndex = 11;
            this.DgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDados_CellClick);
            // 
            // TxtCliente
            // 
            this.TxtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCliente.Location = new System.Drawing.Point(301, 21);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.ReadOnly = true;
            this.TxtCliente.Size = new System.Drawing.Size(529, 22);
            this.TxtCliente.TabIndex = 1;
            this.TxtCliente.Tag = "Cliente";
            this.TxtCliente.WordWrap = false;
            this.TxtCliente.TextChanged += new System.EventHandler(this.TxtCliente_TextChanged);
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuant.Location = new System.Drawing.Point(12, 624);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(0, 16);
            this.lblQuant.TabIndex = 0;
            // 
            // BtnLote
            // 
            this.BtnLote.Enabled = false;
            this.BtnLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLote.Location = new System.Drawing.Point(410, 137);
            this.BtnLote.Name = "BtnLote";
            this.BtnLote.Size = new System.Drawing.Size(126, 24);
            this.BtnLote.TabIndex = 10;
            this.BtnLote.Text = "&Cadastro em Lote";
            this.BtnLote.UseVisualStyleBackColor = true;
            this.BtnLote.Click += new System.EventHandler(this.btnLote_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(704, 137);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 24);
            this.BtnExcluir.TabIndex = 7;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 658);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(875, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(855, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 680);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DgvDados);
            this.Controls.Add(this.BtnLote);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnInserir);
            this.Controls.Add(this.BtnAddOs);
            this.Controls.Add(this.BtnAddUser);
            this.Controls.Add(this.CbxUser);
            this.Controls.Add(this.CbxTipo);
            this.Controls.Add(this.TxtDescr);
            this.Controls.Add(this.TxtNumDes);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(this.TxtOrdem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblQuant);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numerador";
            this.Activated += new System.EventHandler(this.FrmNum_Activated);
            this.Load += new System.EventHandler(this.FrmNum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNumDes;
        private System.Windows.Forms.TextBox TxtDescr;
        private System.Windows.Forms.ComboBox CbxTipo;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnAddOs;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.DataGridView DgvDados;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Button BtnLote;
        private System.Windows.Forms.Button BtnExcluir;
        public System.Windows.Forms.TextBox TxtOrdem;
        public System.Windows.Forms.ComboBox CbxUser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

