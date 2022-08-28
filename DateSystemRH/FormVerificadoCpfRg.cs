using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
//using System.Data.Entity;
//using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DateSystemRH
{
    public partial class FormVerificadoCpfRg : Form
    {
        private string CONNECTIONSTRING = "";
        public string connetionString
        {
            get
            {
                return this.CONNECTIONSTRING;

            }
            set
            {
                this.CONNECTIONSTRING = value;
            }
        }
        private int ID_LOGIN_USUARIO = 0;
        public int IdLoginUsuario
        {
            get
            {
                return this.ID_LOGIN_USUARIO;

            }
            set
            {
                this.ID_LOGIN_USUARIO = value;
            }
        }
        public FormVerificadoCpfRg(int IdLoginUsuario)
        {
            InitializeComponent();
            this.connetionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSRH;Persist Security Info=True;User ID=msos;Password=msos2019;";
            label1.Text = "VERIFICA SE O CPF \nE RG CONSTA NO SISTEMA.";
            this.IdLoginUsuario = IdLoginUsuario;
        }

        private void FormVerificadoCpfRg_Load(object sender, EventArgs e)
        {
            
        }
        private void buttonVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificadorInformacao();
            }
            catch (Exception ex){ MessageBox.Show(ex.ToString()); }

            
        }
        public void VerificadorInformacao()
        {
            try
            {
                if (txtCpfRg.Text != "")
                {
                    int tamanho = txtCpfRg.TextLength;

                    if (tamanho == 9)
                    {
                        SqlConnection conn = new SqlConnection(this.connetionString);

                        SqlDataAdapter da3 = new SqlDataAdapter("SELECT ID_PESSOA FROM P_Pessoa WHERE RG = " + txtCpfRg.Text + ";", conn);

                        DataSet ds3 = new DataSet();
                        da3.Fill(ds3);

                        conn.Open();

                        if (ds3.Tables[0].Rows.Count > 0)
                        {                  
                            MessageBox.Show("RG JÁ CONSTA NO SISTEMA!");
                            
                        }
                        if (ds3.Tables[0].Rows.Count == 0)
                        {
                            this.Hide();
                            Form f = new FormFichaSolicitacaoEmprego(this.IdLoginUsuario, txtCpfRg.Text);
                            f.Closed += (s, args) => this.Close();
                            f.ShowDialog();
                            f.Top = 200;
                            f.Left = 150;
                        }
                        conn.Close();

                    }
                    if (tamanho == 11)
                    {
                        SqlConnection conn = new SqlConnection(this.connetionString);

                        SqlDataAdapter da3 = new SqlDataAdapter("SELECT ID_PESSOA FROM P_Pessoa WHERE CPF = " + txtCpfRg.Text + ";", conn);

                        DataSet ds3 = new DataSet();
                        da3.Fill(ds3);

                        conn.Open();

                        if (ds3.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();
                            MessageBox.Show("CPF JÁ CONSTA NO SISTEMA!");
                        }
                        if (ds3.Tables[0].Rows.Count == 0)
                        {                        
                            this.Hide();
                            Form f = new FormFichaSolicitacaoEmprego(this.IdLoginUsuario, txtCpfRg.Text);
                            f.Closed += (s, args) => this.Close();
                            f.ShowDialog();
                            f.Top = 200;
                            f.Left = 150;

                        }
                        conn.Close();
                                               
                    }
                    if( tamanho  < 9) { MessageBox.Show("Números diferente para CPF e RG "); }
                    if ( tamanho == 10) { MessageBox.Show("Números diferente para CPF e RG "); }
                    if (tamanho > 11) { MessageBox.Show("Números diferente para CPF e RG "); }
                }
                else { MessageBox.Show("Campo não pode está em branco!"); }
            }
            catch (Exception ex){ MessageBox.Show ( ex.ToString()); }
            
        }
        private void txtCpfRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && !(e.KeyChar == ','))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                VerificadorInformacao();
            }
        }

        private void FormVerificadoCpfRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        private void buttonFechaProcessoSeletivo_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }
        public void FecharTodosFormulario()
        {
            FechaFormularios(typeof(FormVerificadoCpfRg));
        }
        public static void FechaFormularios(Type frmType)
        {
            bool bolCtl = false;
            Type a = frmType;
            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                if (form.GetType().Equals(frmType))
                {

                    form.Close();

                    //MessageBox.Show("Formulario Já foi Fechado.");


                    bolCtl = true;
                    break;
                }
            }

            if (!bolCtl)
            {

            }
        }

        private void buttonDv_Click(object sender, EventArgs e)
        {

        }
    }
}
