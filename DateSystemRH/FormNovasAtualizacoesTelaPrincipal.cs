using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
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
    public partial class FormNovasAtualizacoesTelaPrincipal : Form
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
        private int IDUSUARIO = 0;
        public int IdUsuario
        {
            get
            {
                return this.IDUSUARIO;

            }
            set
            {
                this.IDUSUARIO = value;
            }
        }

        public FormNovasAtualizacoesTelaPrincipal( int IdLoginUsuario)
        {
            InitializeComponent();

            this.connetionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSRH;Persist Security Info=True;User ID=msos;Password=msos2019;";
            this.IdUsuario = IdLoginUsuario;
            TextoDeAtualizacao();
        }


        public void TextoDeAtualizacao()
        {
            String S =
                "Desenvolvimento seja bem vindo ao Sistema DateSystem RH . \n" +
                "Atualizações novas no sistema . \n" +
                "1   -> Uso do verificador de RG e CPF para já fichas cadastradas. \n" +
                "2   -> Uso de cincos diferentes atalhos para facilitar as pesquisas são eles:  \n" +
                "2.1 -> [F1] Cadastrar Ficha, [F2] Verificar RG e CPF, [F3] Pesquisa Ficha,  \n" +
                "2.2 -> [F4] Pesquisa Processo de seleção e [F5] Cadastrar novo processo de seleção.  \n" +
                "3   ->Botões usados e abreviados: S = Salvar, C = Cancelar, F = Fechar, L = Limpar, E = Editar. \n" +
                "4   ->Corrigidos erro ocorrido a salvar os editadas. \n" +
                "Versão do Sistema DateSystemRH 1.0 \n";

            txtAtualizacaoTelaPrincipal.Text = S.Replace("\r\n", "\n").Replace("\n", Environment.NewLine);
        }
        private void buttonSalvarAlteracao_Click(object sender, EventArgs e)
        {
            SalvarAlteracoes();
        }

        public void SalvarAlteracoes()
        {
            try
            {
                //Tela Principal Mostra Novas Atualização no sistema.
                TelaPrincipalNovaAtualizacaoTexto TelaPrincipalNovaAtualizacaoTextoU = new TelaPrincipalNovaAtualizacaoTexto();
                TelaPrincipalNovaAtualizacaoTextoU.idUsuario = this.IdUsuario;

                if (checkBoxAtivo.Checked == true)
                {
                    TelaPrincipalNovaAtualizacaoTextoU.AtualizacaoTelaPrincipal = 0;
                }
                if (checkBoxAtivo.Checked == false)
                {
                    TelaPrincipalNovaAtualizacaoTextoU.AtualizacaoTelaPrincipal = 1;
                }

                Conexao2 conexao = new Conexao2(this.connetionString);
                DALDateSystemRH dal = new DALDateSystemRH(conexao);//cadastra Pesssoa Juridica 

                dal.TelaPrincipalNovasAtualizacoesTexto(TelaPrincipalNovaAtualizacaoTextoU);
                FecharTodosFormulario();
                MessageBox.Show("Alterações no DateSystemRH realizado com exito! \n Só fechar o Programa e Reabri-lo!");
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void buttonFecharTela_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }
        public static void CancelaCadastradoTelaPrincipal(Type frmType)
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
        public void FecharTodosFormulario()
        {
            //CHAMA O METODO CancelaCadastradoFornecedor QUE FECHA FORMULÁRIOS ABERTOS
            CancelaCadastradoTelaPrincipal(typeof(FormNovasAtualizacoesTelaPrincipal));
        }

        private void FormNovasAtualizacoesTelaPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void FormNovasAtualizacoesTelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
