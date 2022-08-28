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
    public partial class FormEmpresaClienteEditar : Form
    {
        private int ID_CLIENTE_CADASTRADO = 0;
        public int IdClienteCadastrado
        {
            get
            {
                return this.ID_CLIENTE_CADASTRADO;

            }
            set
            {
                this.ID_CLIENTE_CADASTRADO = value;
            }
        }
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
        private string MS_BASE_DADOS = "";
        public string MsBaseDados
        {
            get
            {
                return this.MS_BASE_DADOS;

            }
            set
            {
                this.MS_BASE_DADOS = value;
            }
        }
        private int EMPRESAEDITAR = 0;
        public int EmpresaEditar
        {
            get
            {
                return this.EMPRESAEDITAR;

            }
            set
            {
                this.EMPRESAEDITAR = value;
            }
        }
        
        public FormEmpresaClienteEditar()
        {
        }
        public FormEmpresaClienteEditar(int EmpresaEditar, int IdEmpresaCliente)
        {
            try
            {
                InitializeComponent();

                if(EmpresaEditar == 1)
                {
                    buttonEditarEmpresa.Enabled = true;
                }

                this.IdClienteCadastrado = IdEmpresaCliente;
                this.connetionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSRH;Persist Security Info=True;User ID=msos;Password=msos2019;";
                SqlConnection conn1 = new SqlConnection(this.connetionString);
                string sql1 = "SELECT * FROM P_Empresa WHERE ID_EMPRESA =  " + this.IdClienteCadastrado + ";";
                SqlDataAdapter sda1 = new SqlDataAdapter(sql1, conn1);
                DataSet ds1 = new DataSet();
                sda1.Fill(ds1);
                conn1.Open();
                //MessageBox.Show(IdPessoaP.ToString());

                txtNomeEmpresa.Text = ds1.Tables[0].Rows[0][1].ToString();
                txtEndereco.Text = ds1.Tables[0].Rows[0][2].ToString();
                txtMs.Text = ds1.Tables[0].Rows[0][3].ToString();
                MsBaseDados = ds1.Tables[0].Rows[0][3].ToString();
                string statusAtivo = ds1.Tables[0].Rows[0][4].ToString();
                if (statusAtivo.ToString() != "") { if (int.Parse(statusAtivo.ToString()) == 1) { checkBoxStatusEmpresa.Checked = true; } else { checkBoxStatusEmpresa.Checked = true; } }
                txtComentario.Text = ds1.Tables[0].Rows[0][5].ToString();
                                
                conn1.Close();
            }
            catch (Exception ex) { MessageBox.Show(" error" + ex.ToString()); }

        }

        private void FormEmpresaClienteEditar_Load(object sender, EventArgs e)
        {

        }
        public static void FechatodosOsFormularios(Type frmType)
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
        private void buttonSalvaCadastro_Click(object sender, EventArgs e)
        {
            CadastraEmpresa();
        }
        public void CadastraEmpresa()
        {
            try
            {
                CadastroEmpresaCliente CadastroEmpresaClienteC = new CadastroEmpresaCliente();
                CadastroEmpresaClienteC.IdCadastroEmpresaCliente = IdClienteCadastrado;
                CadastroEmpresaClienteC.NomeEmpresa = txtNomeEmpresa.Text;
                CadastroEmpresaClienteC.Ms = txtMs.Text;
                CadastroEmpresaClienteC.Endereco = txtEndereco.Text;
                CadastroEmpresaClienteC.Comentario = txtComentario.Text;
                if (checkBoxStatusEmpresa.Checked == true) { CadastroEmpresaClienteC.StatusAtivo = 1; } else { CadastroEmpresaClienteC.StatusAtivo = 2; }

                if ((txtNomeEmpresa.Text != "") && (txtMs.Text != ""))
                {
                    if (MsBaseDados == txtMs.Text)
                    {

                        //DADOS PESSOAS
                        Conexao2 conexao2 = new Conexao2(this.connetionString);
                        DALDateSystemRH dal = new DALDateSystemRH(conexao2); //cadastra Pessoa
                        dal.UpdateCadastraEmpresaCliente(CadastroEmpresaClienteC);
                        FecharTodosFormulario();
                        MessageBox.Show("Alterado com Sucesso!");
                    }
                    else
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
                            dal.UpdateCadastraEmpresaCliente(CadastroEmpresaClienteC);
                            FecharTodosFormulario();
                            MessageBox.Show("Alterado com Sucesso!");
                        }
                    }

                }
                else MessageBox.Show("Nome e MS não podem está em branco");
            }
            catch (Exception ex) { MessageBox.Show(" error" + ex.ToString()); }
            
        }

        private void FormEmpresaClienteEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void buttonEditarEmpresa_Click(object sender, EventArgs e)
        {
            EditarEmpresa();
        }
        public void EditarEmpresa()
        {
            panelEmpresa.Enabled = true;
            buttonSalvaCadastro.Enabled = true;
            buttonEditarEmpresa.Enabled = false;
        }
        public void FecharTodosFormulario()
        {
            FechatodosFormularios(typeof(FormEmpresaClienteEditar));
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

        private void buttonFecha_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
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
    }
}

