namespace DateSystemRH
{
    partial class FormEmpresaCliente
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
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxStatusEmpresa = new System.Windows.Forms.CheckBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSalvaCadastro = new System.Windows.Forms.Button();
            this.buttonFecharEmpresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtEndereco.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtEndereco.Location = new System.Drawing.Point(88, 40);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(282, 21);
            this.txtEndereco.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(12, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "ENDEREÇO:";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Location = new System.Drawing.Point(133, 6);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(665, 20);
            this.txtNomeEmpresa.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "NOME DA EMPRESA:";
            // 
            // txtMs
            // 
            this.txtMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtMs.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtMs.Location = new System.Drawing.Point(842, 5);
            this.txtMs.Name = "txtMs";
            this.txtMs.Size = new System.Drawing.Size(72, 21);
            this.txtMs.TabIndex = 34;
            this.txtMs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMs_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(804, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "MS:";
            // 
            // checkBoxStatusEmpresa
            // 
            this.checkBoxStatusEmpresa.AutoSize = true;
            this.checkBoxStatusEmpresa.Checked = true;
            this.checkBoxStatusEmpresa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStatusEmpresa.Location = new System.Drawing.Point(385, 43);
            this.checkBoxStatusEmpresa.Name = "checkBoxStatusEmpresa";
            this.checkBoxStatusEmpresa.Size = new System.Drawing.Size(106, 17);
            this.checkBoxStatusEmpresa.TabIndex = 36;
            this.checkBoxStatusEmpresa.Text = ": Status Empresa";
            this.checkBoxStatusEmpresa.UseVisualStyleBackColor = true;
            // 
            // txtComentario
            // 
            this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtComentario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtComentario.Location = new System.Drawing.Point(100, 82);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(698, 189);
            this.txtComentario.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "COMENTÁRIO:";
            // 
            // buttonSalvaCadastro
            // 
            this.buttonSalvaCadastro.Location = new System.Drawing.Point(804, 82);
            this.buttonSalvaCadastro.Name = "buttonSalvaCadastro";
            this.buttonSalvaCadastro.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvaCadastro.TabIndex = 39;
            this.buttonSalvaCadastro.Text = "Salvar";
            this.buttonSalvaCadastro.UseVisualStyleBackColor = true;
            this.buttonSalvaCadastro.Click += new System.EventHandler(this.buttonSalvaCadastro_Click);
            // 
            // buttonFecharEmpresa
            // 
            this.buttonFecharEmpresa.Location = new System.Drawing.Point(804, 111);
            this.buttonFecharEmpresa.Name = "buttonFecharEmpresa";
            this.buttonFecharEmpresa.Size = new System.Drawing.Size(26, 26);
            this.buttonFecharEmpresa.TabIndex = 108;
            this.buttonFecharEmpresa.Text = "F";
            this.buttonFecharEmpresa.UseVisualStyleBackColor = true;
            this.buttonFecharEmpresa.Click += new System.EventHandler(this.buttonFecharEmpresa_Click);
            // 
            // FormEmpresaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 282);
            this.ControlBox = false;
            this.Controls.Add(this.buttonFecharEmpresa);
            this.Controls.Add(this.buttonSalvaCadastro);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxStatusEmpresa);
            this.Controls.Add(this.txtMs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEmpresaCliente";
            this.Text = "CADASTRO DA EMPRESA CLIENTE";
            this.Load += new System.EventHandler(this.FormEmpresaCliente_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormEmpresaCliente_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxStatusEmpresa;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSalvaCadastro;
        private System.Windows.Forms.Button buttonFecharEmpresa;
    }
}