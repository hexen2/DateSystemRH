namespace DateSystemRH
{
    partial class FormPesquisaProcessoSelecao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkBoxSituacao = new System.Windows.Forms.CheckBox();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarNome = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarMS = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonOculto = new System.Windows.Forms.RadioButton();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.dataGridViewPesquisaProcessoSeletivo = new System.Windows.Forms.DataGridView();
            this.ID_PROCESSO_SELETIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_EMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_PROFISSAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_CRIACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_FECHAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANT_VAGAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisaNomeEmpresa = new System.Windows.Forms.TextBox();
            this.txtPesquisaMs = new System.Windows.Forms.TextBox();
            this.buttonPesquisaProcessoSeletivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonProcesso = new System.Windows.Forms.RadioButton();
            this.txtProcessoSeletivo = new System.Windows.Forms.TextBox();
            this.comboBoxProfissao = new System.Windows.Forms.ComboBox();
            this.radioButtonProfissaoVaga = new System.Windows.Forms.RadioButton();
            this.checkBoxFinalizado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisaProcessoSeletivo)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxSituacao
            // 
            this.checkBoxSituacao.AutoSize = true;
            this.checkBoxSituacao.Checked = true;
            this.checkBoxSituacao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSituacao.Location = new System.Drawing.Point(328, 38);
            this.checkBoxSituacao.Name = "checkBoxSituacao";
            this.checkBoxSituacao.Size = new System.Drawing.Size(115, 17);
            this.checkBoxSituacao.TabIndex = 180;
            this.checkBoxSituacao.Text = "Processo Seleção:";
            this.checkBoxSituacao.UseVisualStyleBackColor = true;
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(80, 5);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(66, 17);
            this.radioButtonTodos.TabIndex = 179;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "TODOS:";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            this.radioButtonTodos.CheckedChanged += new System.EventHandler(this.radioButtonTodos_CheckedChanged);
            // 
            // radioButtonPesquisarNome
            // 
            this.radioButtonPesquisarNome.AutoSize = true;
            this.radioButtonPesquisarNome.Location = new System.Drawing.Point(302, 7);
            this.radioButtonPesquisarNome.Name = "radioButtonPesquisarNome";
            this.radioButtonPesquisarNome.Size = new System.Drawing.Size(60, 17);
            this.radioButtonPesquisarNome.TabIndex = 178;
            this.radioButtonPesquisarNome.TabStop = true;
            this.radioButtonPesquisarNome.Text = "NOME:";
            this.radioButtonPesquisarNome.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarNome.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarNome_CheckedChanged);
            // 
            // radioButtonPesquisarMS
            // 
            this.radioButtonPesquisarMS.AutoSize = true;
            this.radioButtonPesquisarMS.Location = new System.Drawing.Point(146, 5);
            this.radioButtonPesquisarMS.Name = "radioButtonPesquisarMS";
            this.radioButtonPesquisarMS.Size = new System.Drawing.Size(44, 17);
            this.radioButtonPesquisarMS.TabIndex = 177;
            this.radioButtonPesquisarMS.TabStop = true;
            this.radioButtonPesquisarMS.Text = "MS:";
            this.radioButtonPesquisarMS.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarMS.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarMS_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(858, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 176;
            this.label8.Text = "0";
            // 
            // radioButtonOculto
            // 
            this.radioButtonOculto.AutoSize = true;
            this.radioButtonOculto.Checked = true;
            this.radioButtonOculto.Enabled = false;
            this.radioButtonOculto.Location = new System.Drawing.Point(858, 112);
            this.radioButtonOculto.Name = "radioButtonOculto";
            this.radioButtonOculto.Size = new System.Drawing.Size(41, 17);
            this.radioButtonOculto.TabIndex = 174;
            this.radioButtonOculto.TabStop = true;
            this.radioButtonOculto.Text = "MS";
            this.radioButtonOculto.UseVisualStyleBackColor = true;
            this.radioButtonOculto.Visible = false;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(846, 66);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(26, 26);
            this.buttonFechar.TabIndex = 172;
            this.buttonFechar.Text = "F";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // dataGridViewPesquisaProcessoSeletivo
            // 
            this.dataGridViewPesquisaProcessoSeletivo.AllowUserToAddRows = false;
            this.dataGridViewPesquisaProcessoSeletivo.AllowUserToDeleteRows = false;
            this.dataGridViewPesquisaProcessoSeletivo.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewPesquisaProcessoSeletivo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPesquisaProcessoSeletivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPesquisaProcessoSeletivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesquisaProcessoSeletivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PROCESSO_SELETIVO,
            this.MS,
            this.NOME_EMPRESA,
            this.NOME_PROFISSAO,
            this.DATA_CRIACAO,
            this.DATA_FECHAMENTO,
            this.QUANT_VAGAS});
            this.dataGridViewPesquisaProcessoSeletivo.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewPesquisaProcessoSeletivo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPesquisaProcessoSeletivo.Location = new System.Drawing.Point(4, 73);
            this.dataGridViewPesquisaProcessoSeletivo.MultiSelect = false;
            this.dataGridViewPesquisaProcessoSeletivo.Name = "dataGridViewPesquisaProcessoSeletivo";
            this.dataGridViewPesquisaProcessoSeletivo.RowHeadersVisible = false;
            this.dataGridViewPesquisaProcessoSeletivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPesquisaProcessoSeletivo.Size = new System.Drawing.Size(832, 312);
            this.dataGridViewPesquisaProcessoSeletivo.TabIndex = 171;
            this.dataGridViewPesquisaProcessoSeletivo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPesquisaProcessoSeletivo_CellDoubleClick);
            // 
            // ID_PROCESSO_SELETIVO
            // 
            this.ID_PROCESSO_SELETIVO.DataPropertyName = "ID_PROCESSO_SELETIVO";
            this.ID_PROCESSO_SELETIVO.HeaderText = "PROCESSO SELETIVO";
            this.ID_PROCESSO_SELETIVO.Name = "ID_PROCESSO_SELETIVO";
            // 
            // MS
            // 
            this.MS.DataPropertyName = "MS";
            dataGridViewCellStyle6.Format = "(99) 0000-0000";
            dataGridViewCellStyle6.NullValue = null;
            this.MS.DefaultCellStyle = dataGridViewCellStyle6;
            this.MS.HeaderText = "MS";
            this.MS.Name = "MS";
            this.MS.Width = 50;
            // 
            // NOME_EMPRESA
            // 
            this.NOME_EMPRESA.DataPropertyName = "NOME_EMPRESA";
            this.NOME_EMPRESA.HeaderText = "NOME EMPRESA";
            this.NOME_EMPRESA.Name = "NOME_EMPRESA";
            this.NOME_EMPRESA.Width = 250;
            // 
            // NOME_PROFISSAO
            // 
            this.NOME_PROFISSAO.DataPropertyName = "NOME_PROFISSAO";
            this.NOME_PROFISSAO.HeaderText = "NOME PROFISSÃO";
            this.NOME_PROFISSAO.Name = "NOME_PROFISSAO";
            // 
            // DATA_CRIACAO
            // 
            this.DATA_CRIACAO.DataPropertyName = "DATA_CRIACAO";
            this.DATA_CRIACAO.HeaderText = "DATA CRIAÇÃO";
            this.DATA_CRIACAO.Name = "DATA_CRIACAO";
            this.DATA_CRIACAO.Width = 130;
            // 
            // DATA_FECHAMENTO
            // 
            this.DATA_FECHAMENTO.DataPropertyName = "DATA_FECHAMENTO";
            this.DATA_FECHAMENTO.HeaderText = "DATA FECHAMENTO";
            this.DATA_FECHAMENTO.Name = "DATA_FECHAMENTO";
            this.DATA_FECHAMENTO.Width = 130;
            // 
            // QUANT_VAGAS
            // 
            this.QUANT_VAGAS.DataPropertyName = "QUANT_VAGAS";
            this.QUANT_VAGAS.HeaderText = "QUANT VAGAS";
            this.QUANT_VAGAS.Name = "QUANT_VAGAS";
            // 
            // txtPesquisaNomeEmpresa
            // 
            this.txtPesquisaNomeEmpresa.Enabled = false;
            this.txtPesquisaNomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaNomeEmpresa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPesquisaNomeEmpresa.Location = new System.Drawing.Point(366, 5);
            this.txtPesquisaNomeEmpresa.Name = "txtPesquisaNomeEmpresa";
            this.txtPesquisaNomeEmpresa.Size = new System.Drawing.Size(233, 21);
            this.txtPesquisaNomeEmpresa.TabIndex = 170;
            this.txtPesquisaNomeEmpresa.TextChanged += new System.EventHandler(this.txtPesquisaNomeEmpresa_TextChanged);
            this.txtPesquisaNomeEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaNomeEmpresa_KeyPress);
            // 
            // txtPesquisaMs
            // 
            this.txtPesquisaMs.Enabled = false;
            this.txtPesquisaMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaMs.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPesquisaMs.Location = new System.Drawing.Point(191, 4);
            this.txtPesquisaMs.Name = "txtPesquisaMs";
            this.txtPesquisaMs.Size = new System.Drawing.Size(103, 21);
            this.txtPesquisaMs.TabIndex = 169;
            this.txtPesquisaMs.TextChanged += new System.EventHandler(this.txtPesquisaMs_TextChanged);
            this.txtPesquisaMs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaMs_KeyPress);
            // 
            // buttonPesquisaProcessoSeletivo
            // 
            this.buttonPesquisaProcessoSeletivo.Location = new System.Drawing.Point(799, 5);
            this.buttonPesquisaProcessoSeletivo.Name = "buttonPesquisaProcessoSeletivo";
            this.buttonPesquisaProcessoSeletivo.Size = new System.Drawing.Size(51, 23);
            this.buttonPesquisaProcessoSeletivo.TabIndex = 168;
            this.buttonPesquisaProcessoSeletivo.Text = "Busca";
            this.buttonPesquisaProcessoSeletivo.UseVisualStyleBackColor = true;
            this.buttonPesquisaProcessoSeletivo.Click += new System.EventHandler(this.buttonPesquisaProcessoSeletivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 167;
            this.label1.Text = "Pesquisa ficha:";
            // 
            // radioButtonProcesso
            // 
            this.radioButtonProcesso.AutoSize = true;
            this.radioButtonProcesso.Location = new System.Drawing.Point(611, 9);
            this.radioButtonProcesso.Name = "radioButtonProcesso";
            this.radioButtonProcesso.Size = new System.Drawing.Size(87, 17);
            this.radioButtonProcesso.TabIndex = 182;
            this.radioButtonProcesso.TabStop = true;
            this.radioButtonProcesso.Text = " PROCESSO";
            this.radioButtonProcesso.UseVisualStyleBackColor = true;
            this.radioButtonProcesso.CheckedChanged += new System.EventHandler(this.radioButtonProcesso_CheckedChanged);
            // 
            // txtProcessoSeletivo
            // 
            this.txtProcessoSeletivo.Enabled = false;
            this.txtProcessoSeletivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcessoSeletivo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtProcessoSeletivo.Location = new System.Drawing.Point(699, 7);
            this.txtProcessoSeletivo.Name = "txtProcessoSeletivo";
            this.txtProcessoSeletivo.Size = new System.Drawing.Size(94, 21);
            this.txtProcessoSeletivo.TabIndex = 181;
            this.txtProcessoSeletivo.TextChanged += new System.EventHandler(this.txtProcessoSeletivo_TextChanged);
            this.txtProcessoSeletivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProcessoSeletivo_KeyPress);
            // 
            // comboBoxProfissao
            // 
            this.comboBoxProfissao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfissao.Enabled = false;
            this.comboBoxProfissao.FormattingEnabled = true;
            this.comboBoxProfissao.Location = new System.Drawing.Point(157, 36);
            this.comboBoxProfissao.Name = "comboBoxProfissao";
            this.comboBoxProfissao.Size = new System.Drawing.Size(153, 21);
            this.comboBoxProfissao.TabIndex = 203;
            this.comboBoxProfissao.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfissao_SelectedIndexChanged);
            // 
            // radioButtonProfissaoVaga
            // 
            this.radioButtonProfissaoVaga.AutoSize = true;
            this.radioButtonProfissaoVaga.Location = new System.Drawing.Point(12, 38);
            this.radioButtonProfissaoVaga.Name = "radioButtonProfissaoVaga";
            this.radioButtonProfissaoVaga.Size = new System.Drawing.Size(139, 17);
            this.radioButtonProfissaoVaga.TabIndex = 204;
            this.radioButtonProfissaoVaga.TabStop = true;
            this.radioButtonProfissaoVaga.Text = "PROFISSÃO DA VAGA:";
            this.radioButtonProfissaoVaga.UseVisualStyleBackColor = true;
            this.radioButtonProfissaoVaga.CheckedChanged += new System.EventHandler(this.radioButtonProfissaoVaga_CheckedChanged);
            // 
            // checkBoxFinalizado
            // 
            this.checkBoxFinalizado.AutoSize = true;
            this.checkBoxFinalizado.Location = new System.Drawing.Point(449, 38);
            this.checkBoxFinalizado.Name = "checkBoxFinalizado";
            this.checkBoxFinalizado.Size = new System.Drawing.Size(123, 17);
            this.checkBoxFinalizado.TabIndex = 205;
            this.checkBoxFinalizado.Text = "Finalizado Processo:";
            this.checkBoxFinalizado.UseVisualStyleBackColor = true;
            // 
            // FormPesquisaProcessoSelecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 390);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxFinalizado);
            this.Controls.Add(this.radioButtonProfissaoVaga);
            this.Controls.Add(this.comboBoxProfissao);
            this.Controls.Add(this.radioButtonProcesso);
            this.Controls.Add(this.txtProcessoSeletivo);
            this.Controls.Add(this.checkBoxSituacao);
            this.Controls.Add(this.radioButtonTodos);
            this.Controls.Add(this.radioButtonPesquisarNome);
            this.Controls.Add(this.radioButtonPesquisarMS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButtonOculto);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.dataGridViewPesquisaProcessoSeletivo);
            this.Controls.Add(this.txtPesquisaNomeEmpresa);
            this.Controls.Add(this.txtPesquisaMs);
            this.Controls.Add(this.buttonPesquisaProcessoSeletivo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPesquisaProcessoSelecao";
            this.Text = "PESQUISA PROCESSO SELEÇÃO";
            this.Load += new System.EventHandler(this.FormPesquisaProcessoSelecao_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormPesquisaProcessoSelecao_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisaProcessoSeletivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxSituacao;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonPesquisarNome;
        private System.Windows.Forms.RadioButton radioButtonPesquisarMS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonOculto;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.DataGridView dataGridViewPesquisaProcessoSeletivo;
        private System.Windows.Forms.TextBox txtPesquisaNomeEmpresa;
        private System.Windows.Forms.TextBox txtPesquisaMs;
        private System.Windows.Forms.Button buttonPesquisaProcessoSeletivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonProcesso;
        private System.Windows.Forms.TextBox txtProcessoSeletivo;
        private System.Windows.Forms.ComboBox comboBoxProfissao;
        private System.Windows.Forms.RadioButton radioButtonProfissaoVaga;
        private System.Windows.Forms.CheckBox checkBoxFinalizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PROCESSO_SELETIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_EMPRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_PROFISSAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_CRIACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_FECHAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANT_VAGAS;
    }
}