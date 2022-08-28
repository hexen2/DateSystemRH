namespace DateSystemRH
{
    partial class FormPesquisaEmpresaCadastradaCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkBoxSituacao = new System.Windows.Forms.CheckBox();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarNome = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarMS = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonOculto = new System.Windows.Forms.RadioButton();
            this.buttonCancelarOs = new System.Windows.Forms.Button();
            this.dataGridViewPesquisaEmpresas = new System.Windows.Forms.DataGridView();
            this.ID_EMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_EMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDERECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS_ATIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMENTARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisaNomeEmpresa = new System.Windows.Forms.TextBox();
            this.txtPesquisaMs = new System.Windows.Forms.TextBox();
            this.buttonPesquisaEmpresa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisaEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxSituacao
            // 
            this.checkBoxSituacao.AutoSize = true;
            this.checkBoxSituacao.Checked = true;
            this.checkBoxSituacao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSituacao.Location = new System.Drawing.Point(12, 485);
            this.checkBoxSituacao.Name = "checkBoxSituacao";
            this.checkBoxSituacao.Size = new System.Drawing.Size(97, 17);
            this.checkBoxSituacao.TabIndex = 166;
            this.checkBoxSituacao.Text = "Empresa Ativa:";
            this.checkBoxSituacao.UseVisualStyleBackColor = true;
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(97, 7);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(66, 17);
            this.radioButtonTodos.TabIndex = 165;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "TODOS:";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            this.radioButtonTodos.CheckedChanged += new System.EventHandler(this.radioButtonTodos_CheckedChanged);
            // 
            // radioButtonPesquisarNome
            // 
            this.radioButtonPesquisarNome.AutoSize = true;
            this.radioButtonPesquisarNome.Location = new System.Drawing.Point(328, 11);
            this.radioButtonPesquisarNome.Name = "radioButtonPesquisarNome";
            this.radioButtonPesquisarNome.Size = new System.Drawing.Size(60, 17);
            this.radioButtonPesquisarNome.TabIndex = 164;
            this.radioButtonPesquisarNome.TabStop = true;
            this.radioButtonPesquisarNome.Text = "NOME:";
            this.radioButtonPesquisarNome.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarNome.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarNome_CheckedChanged);
            // 
            // radioButtonPesquisarMS
            // 
            this.radioButtonPesquisarMS.AutoSize = true;
            this.radioButtonPesquisarMS.Location = new System.Drawing.Point(169, 7);
            this.radioButtonPesquisarMS.Name = "radioButtonPesquisarMS";
            this.radioButtonPesquisarMS.Size = new System.Drawing.Size(44, 17);
            this.radioButtonPesquisarMS.TabIndex = 163;
            this.radioButtonPesquisarMS.TabStop = true;
            this.radioButtonPesquisarMS.Text = "MS:";
            this.radioButtonPesquisarMS.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarMS.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarMS_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(850, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 162;
            this.label8.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(869, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 161;
            this.label6.Text = "Quantidade";
            // 
            // radioButtonOculto
            // 
            this.radioButtonOculto.AutoSize = true;
            this.radioButtonOculto.Checked = true;
            this.radioButtonOculto.Enabled = false;
            this.radioButtonOculto.Location = new System.Drawing.Point(862, 114);
            this.radioButtonOculto.Name = "radioButtonOculto";
            this.radioButtonOculto.Size = new System.Drawing.Size(41, 17);
            this.radioButtonOculto.TabIndex = 160;
            this.radioButtonOculto.TabStop = true;
            this.radioButtonOculto.Text = "MS";
            this.radioButtonOculto.UseVisualStyleBackColor = true;
            this.radioButtonOculto.Visible = false;
            // 
            // buttonCancelarOs
            // 
            this.buttonCancelarOs.Location = new System.Drawing.Point(850, 36);
            this.buttonCancelarOs.Name = "buttonCancelarOs";
            this.buttonCancelarOs.Size = new System.Drawing.Size(26, 26);
            this.buttonCancelarOs.TabIndex = 159;
            this.buttonCancelarOs.Text = "C";
            this.buttonCancelarOs.UseVisualStyleBackColor = true;
            this.buttonCancelarOs.Click += new System.EventHandler(this.buttonCancelarOs_Click);
            // 
            // dataGridViewPesquisaEmpresas
            // 
            this.dataGridViewPesquisaEmpresas.AllowUserToAddRows = false;
            this.dataGridViewPesquisaEmpresas.AllowUserToDeleteRows = false;
            this.dataGridViewPesquisaEmpresas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewPesquisaEmpresas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPesquisaEmpresas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPesquisaEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesquisaEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_EMPRESA,
            this.NOME_EMPRESA,
            this.ENDERECO,
            this.MS,
            this.STATUS_ATIVO,
            this.COMENTARIO});
            this.dataGridViewPesquisaEmpresas.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewPesquisaEmpresas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPesquisaEmpresas.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewPesquisaEmpresas.MultiSelect = false;
            this.dataGridViewPesquisaEmpresas.Name = "dataGridViewPesquisaEmpresas";
            this.dataGridViewPesquisaEmpresas.RowHeadersVisible = false;
            this.dataGridViewPesquisaEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPesquisaEmpresas.Size = new System.Drawing.Size(832, 443);
            this.dataGridViewPesquisaEmpresas.TabIndex = 157;
            this.dataGridViewPesquisaEmpresas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPesquisaEmpresas_CellDoubleClick);
            // 
            // ID_EMPRESA
            // 
            this.ID_EMPRESA.DataPropertyName = "REGISTRO";
            this.ID_EMPRESA.HeaderText = "REGISTRO";
            this.ID_EMPRESA.Name = "ID_EMPRESA";
            // 
            // NOME_EMPRESA
            // 
            this.NOME_EMPRESA.DataPropertyName = "NOME_EMPRESA";
            this.NOME_EMPRESA.HeaderText = "NOME EMPRESA";
            this.NOME_EMPRESA.Name = "NOME_EMPRESA";
            this.NOME_EMPRESA.Width = 250;
            // 
            // ENDERECO
            // 
            this.ENDERECO.DataPropertyName = "ENDERECO";
            this.ENDERECO.HeaderText = "ENDERECO";
            this.ENDERECO.Name = "ENDERECO";
            this.ENDERECO.Width = 130;
            // 
            // MS
            // 
            this.MS.DataPropertyName = "MS";
            dataGridViewCellStyle2.Format = "(99) 0000-0000";
            dataGridViewCellStyle2.NullValue = null;
            this.MS.DefaultCellStyle = dataGridViewCellStyle2;
            this.MS.HeaderText = "MS";
            this.MS.Name = "MS";
            // 
            // STATUS_ATIVO
            // 
            this.STATUS_ATIVO.DataPropertyName = "STATUS_ATIVO";
            this.STATUS_ATIVO.HeaderText = "STATUS_ATIVO";
            this.STATUS_ATIVO.Name = "STATUS_ATIVO";
            // 
            // COMENTARIO
            // 
            this.COMENTARIO.DataPropertyName = "COMENTARIO";
            this.COMENTARIO.HeaderText = "COMENTARIO";
            this.COMENTARIO.Name = "COMENTARIO";
            this.COMENTARIO.Width = 150;
            // 
            // txtPesquisaNomeEmpresa
            // 
            this.txtPesquisaNomeEmpresa.Enabled = false;
            this.txtPesquisaNomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaNomeEmpresa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPesquisaNomeEmpresa.Location = new System.Drawing.Point(394, 9);
            this.txtPesquisaNomeEmpresa.Name = "txtPesquisaNomeEmpresa";
            this.txtPesquisaNomeEmpresa.Size = new System.Drawing.Size(393, 21);
            this.txtPesquisaNomeEmpresa.TabIndex = 156;
            this.txtPesquisaNomeEmpresa.TextChanged += new System.EventHandler(this.txtPesquisaNomeEmpresa_TextChanged);
            this.txtPesquisaNomeEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaNomeEmpresa_KeyPress);
            // 
            // txtPesquisaMs
            // 
            this.txtPesquisaMs.Enabled = false;
            this.txtPesquisaMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaMs.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPesquisaMs.Location = new System.Drawing.Point(219, 8);
            this.txtPesquisaMs.Name = "txtPesquisaMs";
            this.txtPesquisaMs.Size = new System.Drawing.Size(103, 21);
            this.txtPesquisaMs.TabIndex = 155;
            this.txtPesquisaMs.TextChanged += new System.EventHandler(this.txtPesquisaMs_TextChanged);
            this.txtPesquisaMs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaRG_KeyPress);
            // 
            // buttonPesquisaEmpresa
            // 
            this.buttonPesquisaEmpresa.Location = new System.Drawing.Point(793, 7);
            this.buttonPesquisaEmpresa.Name = "buttonPesquisaEmpresa";
            this.buttonPesquisaEmpresa.Size = new System.Drawing.Size(51, 23);
            this.buttonPesquisaEmpresa.TabIndex = 154;
            this.buttonPesquisaEmpresa.Text = "Busca";
            this.buttonPesquisaEmpresa.UseVisualStyleBackColor = true;
            this.buttonPesquisaEmpresa.Click += new System.EventHandler(this.buttonPesquisaEmpresa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 153;
            this.label1.Text = "Pesquisa ficha:";
            // 
            // FormPesquisaEmpresaCadastradaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 504);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxSituacao);
            this.Controls.Add(this.radioButtonTodos);
            this.Controls.Add(this.radioButtonPesquisarNome);
            this.Controls.Add(this.radioButtonPesquisarMS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButtonOculto);
            this.Controls.Add(this.buttonCancelarOs);
            this.Controls.Add(this.dataGridViewPesquisaEmpresas);
            this.Controls.Add(this.txtPesquisaNomeEmpresa);
            this.Controls.Add(this.txtPesquisaMs);
            this.Controls.Add(this.buttonPesquisaEmpresa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPesquisaEmpresaCadastradaCliente";
            this.Text = "Pesquisa Empresa Cadastrada Cliente";
            this.Load += new System.EventHandler(this.FormPesquisaEmpresaCadastradaCliente_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormPesquisaEmpresaCadastradaCliente_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisaEmpresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxSituacao;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonPesquisarNome;
        private System.Windows.Forms.RadioButton radioButtonPesquisarMS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonOculto;
        private System.Windows.Forms.Button buttonCancelarOs;
        private System.Windows.Forms.DataGridView dataGridViewPesquisaEmpresas;
        private System.Windows.Forms.TextBox txtPesquisaNomeEmpresa;
        private System.Windows.Forms.TextBox txtPesquisaMs;
        private System.Windows.Forms.Button buttonPesquisaEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_EMPRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_EMPRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDERECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MS;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS_ATIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMENTARIO;
    }
}