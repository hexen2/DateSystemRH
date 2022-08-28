namespace DateSystemRH
{
    partial class FormPesquisaFichaSolicitacaoEmprego
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkBoxSituacao = new System.Windows.Forms.CheckBox();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarNome = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarRG = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonOculto = new System.Windows.Forms.RadioButton();
            this.buttonFecharOs = new System.Windows.Forms.Button();
            this.dataGridViewPesquisaFichas = new System.Windows.Forms.DataGridView();
            this.PESSOA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CELULAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE_RECADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CELULAR_RECADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_RECARDO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_REGIAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisaNomePessoa = new System.Windows.Forms.TextBox();
            this.txtPesquisaRG = new System.Windows.Forms.TextBox();
            this.buttonPesquisaFicha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonCpf = new System.Windows.Forms.RadioButton();
            this.txtCpf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisaFichas)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxSituacao
            // 
            this.checkBoxSituacao.AutoSize = true;
            this.checkBoxSituacao.Location = new System.Drawing.Point(895, 389);
            this.checkBoxSituacao.Name = "checkBoxSituacao";
            this.checkBoxSituacao.Size = new System.Drawing.Size(94, 17);
            this.checkBoxSituacao.TabIndex = 150;
            this.checkBoxSituacao.Text = "Ficha Criminal:";
            this.checkBoxSituacao.UseVisualStyleBackColor = true;
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(97, 7);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(66, 17);
            this.radioButtonTodos.TabIndex = 149;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "TODOS:";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            this.radioButtonTodos.CheckedChanged += new System.EventHandler(this.radioButtonTodos_CheckedChanged);
            // 
            // radioButtonPesquisarNome
            // 
            this.radioButtonPesquisarNome.AutoSize = true;
            this.radioButtonPesquisarNome.Location = new System.Drawing.Point(519, 11);
            this.radioButtonPesquisarNome.Name = "radioButtonPesquisarNome";
            this.radioButtonPesquisarNome.Size = new System.Drawing.Size(60, 17);
            this.radioButtonPesquisarNome.TabIndex = 148;
            this.radioButtonPesquisarNome.TabStop = true;
            this.radioButtonPesquisarNome.Text = "NOME:";
            this.radioButtonPesquisarNome.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarNome.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarNome_CheckedChanged);
            // 
            // radioButtonPesquisarRG
            // 
            this.radioButtonPesquisarRG.AutoSize = true;
            this.radioButtonPesquisarRG.Location = new System.Drawing.Point(169, 7);
            this.radioButtonPesquisarRG.Name = "radioButtonPesquisarRG";
            this.radioButtonPesquisarRG.Size = new System.Drawing.Size(44, 17);
            this.radioButtonPesquisarRG.TabIndex = 147;
            this.radioButtonPesquisarRG.TabStop = true;
            this.radioButtonPesquisarRG.Text = "RG:";
            this.radioButtonPesquisarRG.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarRG.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarRG_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(933, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 146;
            this.label8.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(962, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 145;
            this.label6.Text = "Quantidade";
            // 
            // radioButtonOculto
            // 
            this.radioButtonOculto.AutoSize = true;
            this.radioButtonOculto.Checked = true;
            this.radioButtonOculto.Enabled = false;
            this.radioButtonOculto.Location = new System.Drawing.Point(995, 202);
            this.radioButtonOculto.Name = "radioButtonOculto";
            this.radioButtonOculto.Size = new System.Drawing.Size(41, 17);
            this.radioButtonOculto.TabIndex = 144;
            this.radioButtonOculto.TabStop = true;
            this.radioButtonOculto.Text = "MS";
            this.radioButtonOculto.UseVisualStyleBackColor = true;
            this.radioButtonOculto.Visible = false;
            // 
            // buttonFecharOs
            // 
            this.buttonFecharOs.Location = new System.Drawing.Point(995, 36);
            this.buttonFecharOs.Name = "buttonFecharOs";
            this.buttonFecharOs.Size = new System.Drawing.Size(26, 26);
            this.buttonFecharOs.TabIndex = 142;
            this.buttonFecharOs.Text = "F";
            this.buttonFecharOs.UseVisualStyleBackColor = true;
            this.buttonFecharOs.Click += new System.EventHandler(this.buttonFecharOs_Click);
            // 
            // dataGridViewPesquisaFichas
            // 
            this.dataGridViewPesquisaFichas.AllowUserToAddRows = false;
            this.dataGridViewPesquisaFichas.AllowUserToDeleteRows = false;
            this.dataGridViewPesquisaFichas.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewPesquisaFichas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPesquisaFichas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPesquisaFichas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesquisaFichas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PESSOA1,
            this.NOME,
            this.TELEFONE,
            this.CELULAR,
            this.TELEFONE_RECADO,
            this.CELULAR_RECADO,
            this.NOME_RECARDO2,
            this.NOME_REGIAO,
            this.CPF,
            this.RG});
            this.dataGridViewPesquisaFichas.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewPesquisaFichas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPesquisaFichas.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewPesquisaFichas.MultiSelect = false;
            this.dataGridViewPesquisaFichas.Name = "dataGridViewPesquisaFichas";
            this.dataGridViewPesquisaFichas.RowHeadersVisible = false;
            this.dataGridViewPesquisaFichas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPesquisaFichas.Size = new System.Drawing.Size(977, 347);
            this.dataGridViewPesquisaFichas.TabIndex = 141;
            this.dataGridViewPesquisaFichas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPesquisaFichas_CellDoubleClick);
            // 
            // PESSOA1
            // 
            this.PESSOA1.DataPropertyName = "PESSOA1";
            this.PESSOA1.HeaderText = "REGISTRO";
            this.PESSOA1.Name = "PESSOA1";
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "NOME";
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            // 
            // TELEFONE
            // 
            this.TELEFONE.DataPropertyName = "TELEFONE";
            this.TELEFONE.HeaderText = "TELEFONE";
            this.TELEFONE.Name = "TELEFONE";
            // 
            // CELULAR
            // 
            this.CELULAR.DataPropertyName = "CELULAR";
            dataGridViewCellStyle4.Format = "(99) 0000-0000";
            dataGridViewCellStyle4.NullValue = null;
            this.CELULAR.DefaultCellStyle = dataGridViewCellStyle4;
            this.CELULAR.HeaderText = "CELULAR";
            this.CELULAR.Name = "CELULAR";
            // 
            // TELEFONE_RECADO
            // 
            this.TELEFONE_RECADO.DataPropertyName = "TELEFONE_RECADO";
            this.TELEFONE_RECADO.HeaderText = "TELEFONE2";
            this.TELEFONE_RECADO.Name = "TELEFONE_RECADO";
            // 
            // CELULAR_RECADO
            // 
            this.CELULAR_RECADO.DataPropertyName = "CELULAR_RECADO";
            this.CELULAR_RECADO.HeaderText = "CELULAR_RECADO";
            this.CELULAR_RECADO.Name = "CELULAR_RECADO";
            // 
            // NOME_RECARDO2
            // 
            this.NOME_RECARDO2.DataPropertyName = "NOME_RECARDO2";
            this.NOME_RECARDO2.HeaderText = "NOME DE RECARDO";
            this.NOME_RECARDO2.Name = "NOME_RECARDO2";
            // 
            // NOME_REGIAO
            // 
            this.NOME_REGIAO.DataPropertyName = "NOME_REGIAO";
            this.NOME_REGIAO.HeaderText = "REGIÃO MORADIA";
            this.NOME_REGIAO.Name = "NOME_REGIAO";
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // RG
            // 
            this.RG.DataPropertyName = "RG";
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            // 
            // txtPesquisaNomePessoa
            // 
            this.txtPesquisaNomePessoa.Enabled = false;
            this.txtPesquisaNomePessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaNomePessoa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPesquisaNomePessoa.Location = new System.Drawing.Point(585, 8);
            this.txtPesquisaNomePessoa.Name = "txtPesquisaNomePessoa";
            this.txtPesquisaNomePessoa.Size = new System.Drawing.Size(217, 21);
            this.txtPesquisaNomePessoa.TabIndex = 140;
            this.txtPesquisaNomePessoa.TextChanged += new System.EventHandler(this.txtPesquisaNomePessoa_TextChanged);
            this.txtPesquisaNomePessoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaNomePessoa_KeyPress);
            // 
            // txtPesquisaRG
            // 
            this.txtPesquisaRG.Enabled = false;
            this.txtPesquisaRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaRG.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPesquisaRG.Location = new System.Drawing.Point(219, 8);
            this.txtPesquisaRG.Name = "txtPesquisaRG";
            this.txtPesquisaRG.Size = new System.Drawing.Size(103, 21);
            this.txtPesquisaRG.TabIndex = 139;
            this.txtPesquisaRG.TextChanged += new System.EventHandler(this.txtPesquisaRG_TextChanged);
            this.txtPesquisaRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaRG_KeyPress);
            // 
            // buttonPesquisaFicha
            // 
            this.buttonPesquisaFicha.Location = new System.Drawing.Point(808, 6);
            this.buttonPesquisaFicha.Name = "buttonPesquisaFicha";
            this.buttonPesquisaFicha.Size = new System.Drawing.Size(51, 23);
            this.buttonPesquisaFicha.TabIndex = 138;
            this.buttonPesquisaFicha.Text = "Busca";
            this.buttonPesquisaFicha.UseVisualStyleBackColor = true;
            this.buttonPesquisaFicha.Click += new System.EventHandler(this.buttonPesquisaFicha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 137;
            this.label1.Text = "Pesquisa ficha:";
            // 
            // radioButtonCpf
            // 
            this.radioButtonCpf.AutoSize = true;
            this.radioButtonCpf.Location = new System.Drawing.Point(328, 7);
            this.radioButtonCpf.Name = "radioButtonCpf";
            this.radioButtonCpf.Size = new System.Drawing.Size(48, 17);
            this.radioButtonCpf.TabIndex = 152;
            this.radioButtonCpf.TabStop = true;
            this.radioButtonCpf.Text = "CPF:";
            this.radioButtonCpf.UseVisualStyleBackColor = true;
            this.radioButtonCpf.CheckedChanged += new System.EventHandler(this.radioButtonCpf_CheckedChanged);
            // 
            // txtCpf
            // 
            this.txtCpf.Enabled = false;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtCpf.Location = new System.Drawing.Point(382, 8);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(131, 21);
            this.txtCpf.TabIndex = 151;
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
            // 
            // FormPesquisaFichaSolicitacaoEmprego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 406);
            this.ControlBox = false;
            this.Controls.Add(this.radioButtonCpf);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.checkBoxSituacao);
            this.Controls.Add(this.radioButtonTodos);
            this.Controls.Add(this.radioButtonPesquisarNome);
            this.Controls.Add(this.radioButtonPesquisarRG);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButtonOculto);
            this.Controls.Add(this.buttonFecharOs);
            this.Controls.Add(this.dataGridViewPesquisaFichas);
            this.Controls.Add(this.txtPesquisaNomePessoa);
            this.Controls.Add(this.txtPesquisaRG);
            this.Controls.Add(this.buttonPesquisaFicha);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPesquisaFichaSolicitacaoEmprego";
            this.Text = " Pesquisa Ficha Solicitacao Emprego";
            this.Load += new System.EventHandler(this.FormPesquisaFichaSolicitacaoEmprego_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormPesquisaFichaSolicitacaoEmprego_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisaFichas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxSituacao;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonPesquisarNome;
        private System.Windows.Forms.RadioButton radioButtonPesquisarRG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonOculto;
        private System.Windows.Forms.Button buttonFecharOs;
        private System.Windows.Forms.DataGridView dataGridViewPesquisaFichas;
        private System.Windows.Forms.TextBox txtPesquisaNomePessoa;
        private System.Windows.Forms.TextBox txtPesquisaRG;
        private System.Windows.Forms.Button buttonPesquisaFicha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonCpf;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESSOA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CELULAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE_RECADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CELULAR_RECADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_RECARDO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_REGIAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
    }
}