namespace DateSystemRH
{
    partial class FormVerificadoCpfRg
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCpfRg = new System.Windows.Forms.TextBox();
            this.buttonVerificar = new System.Windows.Forms.Button();
            this.buttonFechaProcessoSeletivo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VE";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtCpfRg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 73);
            this.panel1.TabIndex = 1;
            // 
            // txtCpfRg
            // 
            this.txtCpfRg.Location = new System.Drawing.Point(8, 45);
            this.txtCpfRg.Name = "txtCpfRg";
            this.txtCpfRg.Size = new System.Drawing.Size(170, 20);
            this.txtCpfRg.TabIndex = 1;
            this.txtCpfRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpfRg_KeyPress);
            // 
            // buttonVerificar
            // 
            this.buttonVerificar.Location = new System.Drawing.Point(12, 91);
            this.buttonVerificar.Name = "buttonVerificar";
            this.buttonVerificar.Size = new System.Drawing.Size(75, 23);
            this.buttonVerificar.TabIndex = 2;
            this.buttonVerificar.Text = "Verificar";
            this.buttonVerificar.UseVisualStyleBackColor = true;
            this.buttonVerificar.Click += new System.EventHandler(this.buttonVerificar_Click);
            // 
            // buttonFechaProcessoSeletivo
            // 
            this.buttonFechaProcessoSeletivo.Location = new System.Drawing.Point(93, 91);
            this.buttonFechaProcessoSeletivo.Name = "buttonFechaProcessoSeletivo";
            this.buttonFechaProcessoSeletivo.Size = new System.Drawing.Size(41, 23);
            this.buttonFechaProcessoSeletivo.TabIndex = 268;
            this.buttonFechaProcessoSeletivo.Text = "F";
            this.buttonFechaProcessoSeletivo.UseVisualStyleBackColor = true;
            this.buttonFechaProcessoSeletivo.Click += new System.EventHandler(this.buttonFechaProcessoSeletivo_Click);
            // 
            // FormVerificadoCpfRg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 120);
            this.ControlBox = false;
            this.Controls.Add(this.buttonFechaProcessoSeletivo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonVerificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVerificadoCpfRg";
            this.Text = "VERIFICADO DE CPF E RG";
            this.Load += new System.EventHandler(this.FormVerificadoCpfRg_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormVerificadoCpfRg_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonVerificar;
        private System.Windows.Forms.TextBox txtCpfRg;
        private System.Windows.Forms.Button buttonFechaProcessoSeletivo;
    }
}