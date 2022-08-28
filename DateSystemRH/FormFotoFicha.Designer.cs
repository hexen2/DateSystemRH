namespace DateSystemRH
{
    partial class FormFotoFicha
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
            this.pictureBoxImagem = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonAnexo = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSalvarImagem = new System.Windows.Forms.Button();
            this.buttonFecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImagem
            // 
            this.pictureBoxImagem.Location = new System.Drawing.Point(12, 32);
            this.pictureBoxImagem.Name = "pictureBoxImagem";
            this.pictureBoxImagem.Size = new System.Drawing.Size(640, 360);
            this.pictureBoxImagem.TabIndex = 0;
            this.pictureBoxImagem.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 404);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 122;
            this.label14.Text = "Caminho da Imagem:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(116, 404);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 13);
            this.label15.TabIndex = 123;
            this.label15.Text = "\\\\";
            // 
            // buttonAnexo
            // 
            this.buttonAnexo.Enabled = false;
            this.buttonAnexo.Location = new System.Drawing.Point(500, 3);
            this.buttonAnexo.Name = "buttonAnexo";
            this.buttonAnexo.Size = new System.Drawing.Size(46, 23);
            this.buttonAnexo.TabIndex = 124;
            this.buttonAnexo.Text = "Anexo";
            this.buttonAnexo.UseVisualStyleBackColor = true;
            this.buttonAnexo.Click += new System.EventHandler(this.buttonAnexo_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // buttonSalvarImagem
            // 
            this.buttonSalvarImagem.Enabled = false;
            this.buttonSalvarImagem.Location = new System.Drawing.Point(552, 3);
            this.buttonSalvarImagem.Name = "buttonSalvarImagem";
            this.buttonSalvarImagem.Size = new System.Drawing.Size(46, 23);
            this.buttonSalvarImagem.TabIndex = 125;
            this.buttonSalvarImagem.Text = "Salvar";
            this.buttonSalvarImagem.UseVisualStyleBackColor = true;
            this.buttonSalvarImagem.Click += new System.EventHandler(this.buttonSalvarImagem_Click);
            // 
            // buttonFecha
            // 
            this.buttonFecha.Location = new System.Drawing.Point(460, 4);
            this.buttonFecha.Name = "buttonFecha";
            this.buttonFecha.Size = new System.Drawing.Size(34, 23);
            this.buttonFecha.TabIndex = 126;
            this.buttonFecha.Text = "F";
            this.buttonFecha.UseVisualStyleBackColor = true;
            this.buttonFecha.Click += new System.EventHandler(this.buttonFecha_Click);
            // 
            // FormFotoFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 427);
            this.ControlBox = false;
            this.Controls.Add(this.buttonFecha);
            this.Controls.Add(this.buttonSalvarImagem);
            this.Controls.Add(this.buttonAnexo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBoxImagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFotoFicha";
            this.Text = "Foto da Ficha";
            this.Load += new System.EventHandler(this.FormFotoFicha_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormFotoFicha_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxImagem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonAnexo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSalvarImagem;
        private System.Windows.Forms.Button buttonFecha;
    }
}