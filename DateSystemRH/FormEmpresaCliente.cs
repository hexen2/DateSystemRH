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
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace DateSystemRH
{
    public partial class FormEmpresaCliente : Form
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
        public FormEmpresaCliente()
        {
            InitializeComponent();

            txtNomeEmpresa.MaxLength = 80;
            txtEndereco.MaxLength = 40;
            txtMs.MaxLength = 10;
            txtComentario.MaxLength = 80;

            this.connetionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSRH;Persist Security Info=True;User ID=msos;Password=msos2019;";
        }
        private void FormEmpresaCliente_Load(object sender, EventArgs e)
        {
            
        }
        private void buttonSalvaCadastro_Click(object sender, EventArgs e)
        {
            CadastraEmpresa();
        }
        public void CadastraEmpresa()
        {
            try
            {
                CadastroEmpresaCliente CadastroEmpresaClienteC = new CadastroEmpresaCliente();
                CadastroEmpresaClienteC.NomeEmpresa = txtNomeEmpresa.Text;
                CadastroEmpresaClienteC.Ms = txtMs.Text;
                CadastroEmpresaClienteC.Endereco = txtEndereco.Text;
                CadastroEmpresaClienteC.Comentario = txtComentario.Text;
                if (checkBoxStatusEmpresa.Checked == true) { CadastroEmpresaClienteC.StatusAtivo = 1; } else { CadastroEmpresaClienteC.StatusAtivo = 2; }

                if ((txtNomeEmpresa.Text != "") && (txtMs.Text != ""))
                {
                    SqlConnection conn = new SqlConnection(this.connetionString);

                    SqlDataAdapter da3 = new SqlDataAdapter("SELECT * FROM P_Empresa WHERE MS = " + txtMs.Text + ";", conn);

                    DataSet ds3 = new DataSet();
                    da3.Fill(ds3);

                    conn.Open();

                    if (ds3.Tables[0].Rows.Count > 0)

                    {
                        MessageBox.Show("O Ms consta no sistema não pode ser Inserido!");
                    }
                    if (!(ds3.Tables[0].Rows.Count > 0))
                    {    
                        //DADOS PESSOAS
                        Conexao2 conexao2 = new Conexao2(this.connetionString);
                        DALDateSystemRH dal = new DALDateSystemRH(conexao2); //cadastra Pessoa
                        dal.IncluirCadastraEmpresaCliente(CadastroEmpresaClienteC);
                        FecharTodosFormulario();
                        MessageBox.Show("Empresa Cadastrada!");
                    
                        DialogResult dialogResult = MessageBox.Show("Deseja Cadastra nova Empresa " + " ? ", " Aviso", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            FormEmpresaCliente FormEmpresaClienteE = new FormEmpresaCliente();
                            FormEmpresaClienteE.MdiParent = FormEmpresaCliente.ActiveForm;
                            FormEmpresaClienteE.Show();
                            FormEmpresaClienteE.Top = 200;
                            FormEmpresaClienteE.Left = 150;
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                    
                        }
                    }
                }
                else MessageBox.Show("Nome e MS não podem está em branco");
            }
            catch(Exception ex) { MessageBox.Show("Error:" + ex.ToString()); }
        }


        private void txtMs_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void FormEmpresaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        public void FecharTodosFormulario()
        {
            FechatodosFormularios(typeof(FormEmpresaCliente));
        }
        public static void FechatodosFormularios(Type frmType)
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

        private void buttonFecharEmpresa_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }
    }
}
