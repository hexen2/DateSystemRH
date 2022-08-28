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
    public partial class FormProcessoSelecaoEditar : Form
    {
        DataTable TableTodosFichas;
        DataTable TableRg;
        DataTable TableCpf;
        DataTable TableNomePessoa;

        private int ID_PROCESSO_SELETIVO = 0;
        public int IdProcessoSeletivo
        {
            get
            {
                return this.ID_PROCESSO_SELETIVO;

            }
            set
            {
                this.ID_PROCESSO_SELETIVO = value;
            }
        }
        private int VALORPESQUISA = 0;
        public int ValorPesquisa
        {
            get
            {
                return this.VALORPESQUISA;

            }
            set
            {
                this.VALORPESQUISA = value;
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
        private int ID_PROFISSAO;
        public int IdProfissao
        {
            get
            {
                return this.ID_PROFISSAO;

            }
            set
            {
                this.ID_PROFISSAO = value;
            }
        }
        private int STATUS_ATIVO;
        public int StatusAtivo
        {
            get
            {
                return this.STATUS_ATIVO;

            }
            set
            {
                this.STATUS_ATIVO = value;
            }
        }
        private int STATUS_FINALIZACAO;
        public int StatusFinalizacao
        {
            get
            {
                return this.STATUS_FINALIZACAO;

            }
            set
            {
                this.STATUS_FINALIZACAO = value;
            }
        }
        private int ID_TEMP_PROFISSAO;
        public int IdTempProfissao
        {
            get
            {
                return this.ID_TEMP_PROFISSAO;

            }
            set
            {
                this.ID_TEMP_PROFISSAO = value;
            }
        }
        private string NOME_TEMP_PROFISSAO;
        public string NomeTempProfissao
        {
            get
            {
                return this.NOME_TEMP_PROFISSAO;

            }
            set
            {
                this.NOME_TEMP_PROFISSAO = value;

            }
        }
        private int ID_ESTABILIDADE = 0;
        public int IdPEstabilidade
        {
            get
            {
                return this.ID_ESTABILIDADE;

            }
            set
            {
                this.ID_ESTABILIDADE = value;
            }
        }
        private int ID_EMPRESA_CLIENTE = 0;
        public int IdEmpresaCliente
        {
            get
            {
                return this.ID_EMPRESA_CLIENTE;

            }
            set
            {
                this.ID_EMPRESA_CLIENTE = value;
            }
        }
        private Boolean ATIVO_ALTERACAO = false;
        public Boolean AtivoAlteracao
        {
            get
            {
                return this.ATIVO_ALTERACAO;

            }
            set
            {
                this.ATIVO_ALTERACAO = value;
            }
        }
        private int PROCESSOSELECAOREDITAR = 0;
        public int ProcessoSelecaoEditar
        {
            get
            {
                return this.PROCESSOSELECAOREDITAR;

            }
            set
            {
                this.PROCESSOSELECAOREDITAR = value;
            }
        }
        private int IDLOGINUSUARIO = 0;
        public int IdLoginUsuario
        {
            get
            {
                return this.IDLOGINUSUARIO;

            }
            set
            {
                this.IDLOGINUSUARIO = value;
            }
        }
        private int ID_FICHA = 0;
        public int IdFicha
        {
            get
            {
                return this.ID_FICHA;

            }
            set
            {
                this.ID_FICHA = value;
            }
        }
        private Boolean validaNomeEmpresa(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtNomeEmpresa.Text))
            {
                errorProviderPS.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderPS.SetError(textBox, "Nome Empresa em branco!");
                return false;
            }

        }
        private int EDITAR_FICHA = 0;
        public int EditarFicha
        {
            get
            {
                return this.EDITAR_FICHA;

            }
            set
            {
                this.EDITAR_FICHA = value;
            }
        }
        private Boolean validaVagas(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtQuantVagas.Text))
            {
                errorProviderPS.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderPS.SetError(textBox, "QuantVagas em branco!");
                return false;
            }

        }
        IList<int> Id_Ficha = new List<int>();
        public FormProcessoSelecaoEditar(int IdProcessoSeletivo, int ProcessoSelecaoEditar, int IdLoginUsuario, int EditarFicha)
        {
            try
            {
                InitializeComponent();

                this.IdProcessoSeletivo = IdProcessoSeletivo;
                this.IdLoginUsuario = IdLoginUsuario;
                this.EditarFicha = EditarFicha;
                this.connetionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSRH;Persist Security Info=True;User ID=msos;Password=msos2019;";

                SqlConnection conn1 = new SqlConnection(this.connetionString);
                string sql1 = "exec RH_ConsultaProcessoSeletivoPofissaoEditarTxt " + this.IdProcessoSeletivo + ";";
                SqlDataAdapter sda1 = new SqlDataAdapter(sql1, conn1);
                DataSet ds1 = new DataSet();
                sda1.Fill(ds1);
                conn1.Open();

                txtNumeroProcessoSeletivo.Text = ds1.Tables[0].Rows[0][0].ToString();
                txtNomeEmpresa.Text = ds1.Tables[0].Rows[0][12].ToString();
                txtMsEmpresa.Text = ds1.Tables[0].Rows[0][14].ToString();
                this.StatusAtivo = int.Parse(ds1.Tables[0].Rows[0][3].ToString());
                if (this.StatusAtivo == 1) { checkBoxStatusAtivo.Checked = true; } else { checkBoxStatusAtivo.Checked = false; }
                this.StatusFinalizacao = int.Parse(ds1.Tables[0].Rows[0][4].ToString());
                if (this.StatusFinalizacao == 1) { checkBoxStatusFinalizacao.Checked = true; } else { checkBoxStatusFinalizacao.Checked = false; }
                dateTimePickerCriacaoProcesso.Text = ds1.Tables[0].Rows[0][5].ToString();
                string DataFechamento = ds1.Tables[0].Rows[0][6].ToString();
                if (DataFechamento != "") { dateTimePickerFechamentodoProcesso.Text = ds1.Tables[0].Rows[0][6].ToString(); } else { dateTimePickerFechamentodoProcesso.Value = DateTime.Now.Date; }

                txtComentarios.Text = ds1.Tables[0].Rows[0][7].ToString();
                txtQuantVagas.Text = ds1.Tables[0].Rows[0][8].ToString();

                this.IdProfissao = int.Parse(ds1.Tables[0].Rows[0][2].ToString());
                SqlConnection conn = new SqlConnection(this.connetionString);
                string Query = "SELECT * FROM P_Profissao WHERE ID_PROFISSAO = " + this.IdProfissao + ";";
                SqlDataAdapter sa = new SqlDataAdapter(Query, conn);
                DataSet ds = new DataSet();
                sa.Fill(ds);

                comboBoxProfissao.Items.Insert(0, ds.Tables[0].Rows[0][1].ToString());
                comboBoxProfissao.SelectedIndex = 0;
                conn.Close();

                SqlConnection conn2 = new SqlConnection(this.connetionString);
                string sql2 = "exec RH_ConsultaP_CandidatosPSeletivoEditarTxt " + ID_PROCESSO_SELETIVO + ";";
                SqlDataAdapter sda2 = new SqlDataAdapter(sql2, conn2);
                DataSet ds2 = new DataSet();
                sda2.Fill(ds2);
                conn2.Open();

                int valor = ds2.Tables[0].Rows.Count;
                for (int i = 0; i < valor; i++)
                {

                    string[] row = new string[] { ds2.Tables[0].Rows[i][0].ToString(), ds2.Tables[0].Rows[i][1].ToString() };
                    dataGridViewClassificados.Rows.Add(row);
                    Id_Ficha.Add(int.Parse(ds2.Tables[0].Rows[i][0].ToString()));

                }
                label4.Text = dataGridViewClassificados.RowCount.ToString();
                conn2.Close();
                if (checkBoxStatusFinalizacao.Checked == true)
                {
                    checkBoxStatusFinalizacao.Enabled = false; checkBoxStatusAtivo.Enabled = false;
                }
                if(ProcessoSelecaoEditar == 1)
                {
                    buttonEditar.Enabled = true;
                }
                string ID_PESSOA_LOGADA = ds1.Tables[0].Rows[0][9].ToString();
                if (!(ID_PESSOA_LOGADA == ""))
                {
                    SqlConnection conn3 = new SqlConnection(this.connetionString);
                    string Query3 = "SELECT USUARIO FROM U_LoginUsuario WHERE ID_LOGIN_USUARIO = " + int.Parse(ID_PESSOA_LOGADA) + ";";
                    SqlDataAdapter sa3 = new SqlDataAdapter(Query3, conn3);
                    DataSet ds3 = new DataSet();
                    sa3.Fill(ds3);
                    ID_PESSOA_LOGADA = ds3.Tables[0].Rows[0][0].ToString();
                    conn3.Close();
                }
                string ID_PESSOA_LOGADA_ALTERADA = ds1.Tables[0].Rows[0][10].ToString();
                if (!(ID_PESSOA_LOGADA_ALTERADA == ""))
                {
                    SqlConnection conn4 = new SqlConnection(this.connetionString);
                    string Query4 = "SELECT USUARIO FROM U_LoginUsuario WHERE ID_LOGIN_USUARIO = " + int.Parse(ID_PESSOA_LOGADA_ALTERADA) + ";";
                    SqlDataAdapter sa4 = new SqlDataAdapter(Query4, conn4);
                    DataSet ds4 = new DataSet();
                    sa4.Fill(ds4);
                    ID_PESSOA_LOGADA_ALTERADA = ds4.Tables[0].Rows[0][0].ToString();
                    conn4.Close();
                }
                //CRIAÇÃO E ALTERAÇÃO DA FICHA
                if ((ID_PESSOA_LOGADA != "") && (ID_PESSOA_LOGADA_ALTERADA != "")) { label145.Text = "A ficha foi criado por " + ID_PESSOA_LOGADA + " e alterada por " + ID_PESSOA_LOGADA_ALTERADA + ";"; }
                else if ((ID_PESSOA_LOGADA != "") && (ID_PESSOA_LOGADA_ALTERADA == "")) { label145.Text = "A ficha foi criado por " + ID_PESSOA_LOGADA + " e não teve alteração."; }

                Fill_listBoxTodasEstabilidade();
            }
            catch (Exception ex) { MessageBox.Show(" error" + ex.ToString()); }
        }
        public void PesquisaTodosFichasPS()
        {
            try
            {
                int Temp_Profisao = 0;
                int Usar_Regiao = 0;
                int Temp_estabilidade = 0;
                int Usar_CNH = 0;
                int CNH_A = 0;
                int CNH_B = 0;
                int CNH_C = 0;
                int CNH_D = 0;
                if (this.IdProfissao == 0) { Temp_Profisao = 0; } else { Temp_Profisao = this.IdProfissao; };
                if (radioButtonSemRegiao.Checked == false)
                {
                    if (radioButtonLeste.Checked == true) { Usar_Regiao = 1; }
                    if (radioButtonOeste.Checked == true) { Usar_Regiao = 2; }
                    if (radioButtonNorte.Checked == true) { Usar_Regiao = 3; }
                    if (radioButtonSul.Checked == true) { Usar_Regiao = 4; }
                    if (radioButtonCentro.Checked == true) { Usar_Regiao = 5; }
                    if (radioButtonABC.Checked == true) { Usar_Regiao = 6; }
                    if (radioButtonGuarulhos.Checked == true) { Usar_Regiao = 7; }
                    if (radioButtonInterior.Checked == true) { Usar_Regiao = 8; }
                }
                else { Usar_Regiao = 0; }
                if (this.IdPEstabilidade == 0) { Temp_estabilidade = 0; } else { Temp_estabilidade = this.IdPEstabilidade; }
                if (checkBoxAtivaVerifcacao.Checked == true) { Usar_CNH = 1; } else { Usar_CNH = 0; }
                if (checkBoxCMA.Checked == true) { CNH_A = 1; } else { CNH_A = 2; }
                if (checkBoxCMB.Checked == true) { CNH_B = 1; } else { CNH_B = 2; }
                if (checkBoxCMC.Checked == true) { CNH_C = 1; } else { CNH_C = 2; }
                if (checkBoxCMD.Checked == true) { CNH_D = 1; } else { CNH_D = 2; }

                SqlConnection connection = new SqlConnection(this.connetionString);
                SqlCommand command = new SqlCommand("EXEC RH_ConsultaFichaEmpregoTodosPSTxt " + Temp_Profisao + "," + Usar_Regiao + "," + Temp_estabilidade + ","
                            + Usar_CNH + "," + CNH_A + "," + CNH_B + "," + CNH_C + "," + CNH_D + ";", connection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableTodosFichas = new DataTable();
                adapter.Fill(TableTodosFichas);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableTodosFichas;
                dataGridViewFichasCadastrada.DataSource = Source;
                adapter.Update(TableTodosFichas);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        public void PesquisaRgPS()
        {
            try
            {
                int Temp_Profisao = 0;
                int Usar_Regiao = 0;
                int Temp_estabilidade = 0;
                int Usar_CNH = 0;
                int CNH_A = 0;
                int CNH_B = 0;
                int CNH_C = 0;
                int CNH_D = 0;
                if (this.IdProfissao == 0) { Temp_Profisao = 0; } else { Temp_Profisao = this.IdProfissao; };
                if (radioButtonSemRegiao.Checked == false)
                {
                    if (radioButtonLeste.Checked == true) { Usar_Regiao = 1; }
                    if (radioButtonOeste.Checked == true) { Usar_Regiao = 2; }
                    if (radioButtonNorte.Checked == true) { Usar_Regiao = 3; }
                    if (radioButtonSul.Checked == true) { Usar_Regiao = 4; }
                    if (radioButtonCentro.Checked == true) { Usar_Regiao = 5; }
                    if (radioButtonABC.Checked == true) { Usar_Regiao = 6; }
                    if (radioButtonGuarulhos.Checked == true) { Usar_Regiao = 7; }
                    if (radioButtonInterior.Checked == true) { Usar_Regiao = 8; }
                }
                else { Usar_Regiao = 0; }
                if (this.IdPEstabilidade == 0) { Temp_estabilidade = 0; } else { Temp_estabilidade = this.IdPEstabilidade; }
                if (checkBoxAtivaVerifcacao.Checked == true) { Usar_CNH = 1; } else { Usar_CNH = 0; }
                if (checkBoxCMA.Checked == true) { CNH_A = 1; } else { CNH_A = 2; }
                if (checkBoxCMB.Checked == true) { CNH_B = 1; } else { CNH_B = 2; }
                if (checkBoxCMC.Checked == true) { CNH_C = 1; } else { CNH_C = 2; }
                if (checkBoxCMD.Checked == true) { CNH_D = 1; } else { CNH_D = 2; }

                SqlConnection connection = new SqlConnection(this.connetionString);
                SqlCommand command = new SqlCommand("EXEC RH_ConsultaFichaEmpregoRgPSTxt '" + txtPesquisaRG.Text + "'," + Temp_Profisao + "," + Usar_Regiao + "," + Temp_estabilidade + ","
                        + Usar_CNH + "," + CNH_A + "," + CNH_B + "," + CNH_C + "," + CNH_D + ";", connection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableRg = new DataTable();
                adapter.Fill(TableRg);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableRg;
                dataGridViewFichasCadastrada.DataSource = Source;
                adapter.Update(TableRg);
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error" + ex.ToString());
            }
        }
        public void PesquisaCpfPS()
        {
            try
            {
                int Temp_Profisao = 0;
                int Usar_Regiao = 0;
                int Temp_estabilidade = 0;
                int Usar_CNH = 0;
                int CNH_A = 0;
                int CNH_B = 0;
                int CNH_C = 0;
                int CNH_D = 0;
                if (this.IdProfissao == 0) { Temp_Profisao = 0; } else { Temp_Profisao = this.IdProfissao; };
                if (radioButtonSemRegiao.Checked == false)
                {
                    if (radioButtonLeste.Checked == true) { Usar_Regiao = 1; }
                    if (radioButtonOeste.Checked == true) { Usar_Regiao = 2; }
                    if (radioButtonNorte.Checked == true) { Usar_Regiao = 3; }
                    if (radioButtonSul.Checked == true) { Usar_Regiao = 4; }
                    if (radioButtonCentro.Checked == true) { Usar_Regiao = 5; }
                    if (radioButtonABC.Checked == true) { Usar_Regiao = 6; }
                    if (radioButtonGuarulhos.Checked == true) { Usar_Regiao = 7; }
                    if (radioButtonInterior.Checked == true) { Usar_Regiao = 8; }
                }
                else { Usar_Regiao = 0; }
                if (this.IdPEstabilidade == 0) { Temp_estabilidade = 0; } else { Temp_estabilidade = this.IdPEstabilidade; }
                if (checkBoxAtivaVerifcacao.Checked == true) { Usar_CNH = 1; } else { Usar_CNH = 0; }
                if (checkBoxCMA.Checked == true) { CNH_A = 1; } else { CNH_A = 2; }
                if (checkBoxCMB.Checked == true) { CNH_B = 1; } else { CNH_B = 2; }
                if (checkBoxCMC.Checked == true) { CNH_C = 1; } else { CNH_C = 2; }
                if (checkBoxCMD.Checked == true) { CNH_D = 1; } else { CNH_D = 2; }

                SqlConnection connection = new SqlConnection(this.connetionString);
                SqlCommand command = new SqlCommand("EXEC RH_ConsultaFichaEmpregoCpfPSTxt '" + txtCpf.Text + "'," + Temp_Profisao + "," + Usar_Regiao + "," + Temp_estabilidade + ","
                        + Usar_CNH + "," + CNH_A + "," + CNH_B + "," + CNH_C + "," + CNH_D + ";", connection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableCpf = new DataTable();
                adapter.Fill(TableCpf);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableCpf;
                dataGridViewFichasCadastrada.DataSource = Source;
                adapter.Update(TableCpf);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }
        public void PesquisaNomePS()
        {
            try
            {
                int Temp_Profisao = 0;
                int Usar_Regiao = 0;
                int Temp_estabilidade = 0;
                int Usar_CNH = 0;
                int CNH_A = 0;
                int CNH_B = 0;
                int CNH_C = 0;
                int CNH_D = 0;
                if (this.IdProfissao == 0) { Temp_Profisao = 0; } else { Temp_Profisao = this.IdProfissao; };
                if (radioButtonSemRegiao.Checked == false)
                {
                    if (radioButtonLeste.Checked == true) { Usar_Regiao = 1; }
                    if (radioButtonOeste.Checked == true) { Usar_Regiao = 2; }
                    if (radioButtonNorte.Checked == true) { Usar_Regiao = 3; }
                    if (radioButtonSul.Checked == true) { Usar_Regiao = 4; }
                    if (radioButtonCentro.Checked == true) { Usar_Regiao = 5; }
                    if (radioButtonABC.Checked == true) { Usar_Regiao = 6; }
                    if (radioButtonGuarulhos.Checked == true) { Usar_Regiao = 7; }
                    if (radioButtonInterior.Checked == true) { Usar_Regiao = 8; }
                }
                else { Usar_Regiao = 0; }
                if (this.IdPEstabilidade == 0) { Temp_estabilidade = 0; } else { Temp_estabilidade = this.IdPEstabilidade; }
                if (checkBoxAtivaVerifcacao.Checked == true) { Usar_CNH = 1; } else { Usar_CNH = 0; }
                if (checkBoxCMA.Checked == true) { CNH_A = 1; } else { CNH_A = 2; }
                if (checkBoxCMB.Checked == true) { CNH_B = 1; } else { CNH_B = 2; }
                if (checkBoxCMC.Checked == true) { CNH_C = 1; } else { CNH_C = 2; }
                if (checkBoxCMD.Checked == true) { CNH_D = 1; } else { CNH_D = 2; }

                SqlConnection connection = new SqlConnection(this.connetionString);
                SqlCommand command = new SqlCommand("EXEC RH_ConsultaFichaEmpregoNomePSTxt '" + txtPesquisaNomePessoa.Text + "'," + Temp_Profisao + "," + Usar_Regiao + "," + Temp_estabilidade + ","
                        + Usar_CNH + "," + CNH_A + "," + CNH_B + "," + CNH_C + "," + CNH_D + ";", connection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableNomePessoa = new DataTable();
                adapter.Fill(TableNomePessoa);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableNomePessoa;
                dataGridViewFichasCadastrada.DataSource = Source;
                adapter.Update(TableNomePessoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }
        void Fill_listBoxProfissao()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC RH_ConsultaCadastroTodosProfissao;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(0);
                    comboBoxProfissao.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }
        private void FormProcessoSelecaoEditar_Load(object sender, EventArgs e)
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
        private void comboBoxProfissao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (dataGridViewClassificados.RowCount == 0)
                {
                    LimpaFichasCadastradas(0);
                    LimpaFichasCadastradas(1);

                    SqlConnection connection = new SqlConnection(this.connetionString);
                    connection.Open();
                    string Query = " SELECT ID_PROFISSAO, NOME_PROFISSAO FROM P_Profissao WHERE NOME_PROFISSAO = '" + this.comboBoxProfissao.Text + "';";

                    SqlCommand command = new SqlCommand(Query, connection);
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        this.IdProfissao = dr.GetInt32(0);
                        comboBoxProfissao.Text = dr.GetString(1);
                        this.IdTempProfissao = this.IdProfissao;
                        this.NomeTempProfissao = dr.GetString(1);
                    }
                    connection.Close();
                }

                if (dataGridViewClassificados.RowCount != 0)
                {
                    SqlConnection connection = new SqlConnection(this.connetionString);
                    connection.Open();
                    string Query = " SELECT ID_PROFISSAO, NOME_PROFISSAO FROM P_Profissao WHERE NOME_PROFISSAO = '" + this.comboBoxProfissao.Text + "';";

                    SqlCommand command = new SqlCommand(Query, connection);
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        if ((this.IdTempProfissao != dr.GetInt32(0)) && (dataGridViewClassificados.RowCount != 0))
                        {

                            DialogResult dialogResult = MessageBox.Show("Deseja troca de profissão  " + " ? ", " Aviso", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                LimpaFichasCadastradas(0);
                                LimpaFichasCadastradas(1);
                                LimpaFichasCadastradas(2);
                                LimpaFichasCadastradas(3);

                                this.IdProfissao = dr.GetInt32(0);
                                comboBoxProfissao.Text = dr.GetString(1);
                                this.IdTempProfissao = dr.GetInt32(0);
                                this.NomeTempProfissao = dr.GetString(1);

                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                this.IdProfissao = IdTempProfissao;
                                comboBoxProfissao.Text = this.NomeTempProfissao;
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LimpaFichasCadastradas(int entrada)
        {
            //string[] row = new string[] { "", "", " ", "", "","","","", "", "", "" };
            //dataGridViewFichasCadastrada.Rows.Add(row);
            //dataGridViewFichasCadastrada.Rows.Add();
            if (entrada == 0)
            {
                if (this.dataGridViewFichasCadastrada.DataSource != null)
                {
                    this.dataGridViewFichasCadastrada.DataSource = null;
                }
                else
                {
                    this.dataGridViewFichasCadastrada.Rows.Clear();

                }
            }
            if (entrada == 1)
            {
                dataGridViewFichasCadastrada.ColumnCount = 11;
                dataGridViewFichasCadastrada.Columns[0].Name = "REGISTRO";
                dataGridViewFichasCadastrada.Columns[0].DataPropertyName = "ID_REGISTRO_P";
                dataGridViewFichasCadastrada.Columns[0].Width = 100;
                dataGridViewFichasCadastrada.Columns[1].Name = "NOME_PESSOA";
                dataGridViewFichasCadastrada.Columns[1].DataPropertyName = "NOME_P";
                dataGridViewFichasCadastrada.Columns[1].Width = 160;
                dataGridViewFichasCadastrada.Columns[2].Name = "NOME PROFISSÃO";
                dataGridViewFichasCadastrada.Columns[2].DataPropertyName = "NOME_PROFISSAO_P";
                dataGridViewFichasCadastrada.Columns[2].Width = 100;
                dataGridViewFichasCadastrada.Columns[3].Name = "NOME REGIÃO";
                dataGridViewFichasCadastrada.Columns[3].DataPropertyName = "NOME_REGIAO_P";
                dataGridViewFichasCadastrada.Columns[3].Width = 100;
                dataGridViewFichasCadastrada.Columns[4].Name = "NOME ESTABILIDADE";
                dataGridViewFichasCadastrada.Columns[4].DataPropertyName = "NOME_ESTABILIDADE_P";
                dataGridViewFichasCadastrada.Columns[4].Width = 100;
                dataGridViewFichasCadastrada.Columns[5].Name = "CARTEIRA A";
                dataGridViewFichasCadastrada.Columns[5].DataPropertyName = "CARTEIRA_A_P";
                dataGridViewFichasCadastrada.Columns[5].Visible = false;
                dataGridViewFichasCadastrada.Columns[6].Name = "CARTEIRA B";
                dataGridViewFichasCadastrada.Columns[6].DataPropertyName = "CARTEIRA_B_P";
                dataGridViewFichasCadastrada.Columns[6].Visible = false;
                dataGridViewFichasCadastrada.Columns[7].Name = "CARTEIRA C";
                dataGridViewFichasCadastrada.Columns[7].DataPropertyName = "CARTEIRA_C_P";
                dataGridViewFichasCadastrada.Columns[7].Visible = false;
                dataGridViewFichasCadastrada.Columns[8].Name = "CARTEIRA D";
                dataGridViewFichasCadastrada.Columns[8].DataPropertyName = "CARTEIRA_D_P";
                dataGridViewFichasCadastrada.Columns[8].Visible = false;
                dataGridViewFichasCadastrada.Columns[9].Name = "CPF";
                dataGridViewFichasCadastrada.Columns[9].DataPropertyName = "CPF_P";
                dataGridViewFichasCadastrada.Columns[9].Width = 100;
                dataGridViewFichasCadastrada.Columns[10].Name = "RG";
                dataGridViewFichasCadastrada.Columns[10].DataPropertyName = "RG_P";
                dataGridViewFichasCadastrada.Columns[10].Width = 100;
            }
            if (entrada == 2)
            {
                if (this.dataGridViewClassificados.DataSource != null)
                {
                    this.dataGridViewClassificados.DataSource = null;
                }
                else
                {
                    this.dataGridViewClassificados.Rows.Clear();

                }
            }
            if (entrada == 3)
            {
                dataGridViewClassificados.ColumnCount = 2;
                dataGridViewClassificados.Columns[0].Name = "ID_CLASSIFICACAO";
                dataGridViewClassificados.Columns[0].HeaderText = "REGISTRO";
                dataGridViewClassificados.Columns[0].Width = 70;
                dataGridViewClassificados.Columns[1].Name = "NOME_CLASSIFICACAO";
                dataGridViewClassificados.Columns[1].HeaderText = "NOME";
                dataGridViewClassificados.Columns[1].Width = 135;

            }
        }

        private void FormProcessoSelecaoEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                FecharTodosFormulario();
            }
        }
        bool VerificarObjeto(object obj)
        {
            try
            {
                object objeto = obj;
                if (objeto == null)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return true;
            }

        }
        private void dataGridViewFichasCadastrada_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int NumeroRegistro = Convert.ToInt32(dataGridViewFichasCadastrada["REGISTRO", e.RowIndex].Value);
                string NomeRegistro = Convert.ToString(dataGridViewFichasCadastrada["NOME_PESSOA", e.RowIndex].Value);

                int Linha_Selecionada = int.Parse(dataGridViewFichasCadastrada.CurrentRow.Index.ToString());
                int contador = 0;

                if ((VerificarObjeto(dataGridViewFichasCadastrada.Rows[Linha_Selecionada].Cells[0].Value) == false))
                {
                    if (dataGridViewClassificados.RowCount > 1)
                    {
                        for (int inicio = 0; inicio < dataGridViewClassificados.RowCount; inicio++)
                        {
                            int ValorClassificados = int.Parse(dataGridViewClassificados.Rows[inicio].Cells[0].Value.ToString());

                            if (NumeroRegistro == ValorClassificados)
                            {
                                contador++;
                                inicio = dataGridViewClassificados.RowCount;
                            }
                        }
                        if (contador == 0)
                        {
                            string[] row = new string[] { Convert.ToString(NumeroRegistro), NomeRegistro };
                            dataGridViewClassificados.Rows.Add(row);
                            label4.Text = dataGridViewClassificados.RowCount.ToString();
                            AtivoAlteracao = true;
                        }
                        else { MessageBox.Show("Já consta ficha em listagem!"); }
                    }
                    else
                    {
                        string[] row = new string[] { Convert.ToString(NumeroRegistro), NomeRegistro };
                        dataGridViewClassificados.Rows.Add(row);
                        label4.Text = dataGridViewClassificados.RowCount.ToString();
                        AtivoAlteracao = true;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error" + ex.ToString()); }
        }

        private void dataGridViewClassificados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Linha_Selecionada = int.Parse(dataGridViewClassificados.CurrentRow.Index.ToString());

                if ((VerificarObjeto(dataGridViewClassificados.Rows[Linha_Selecionada].Cells[0].Value) == false))
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja Remover " + dataGridViewClassificados.Rows[Linha_Selecionada].Cells[1].Value.ToString() + " ? ", " Aviso", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridViewClassificados.Rows.RemoveAt(Linha_Selecionada);
                        label4.Text = dataGridViewClassificados.RowCount.ToString();
                        txtNome.Clear();
                        txtTelefonePessoa.Clear();
                        maskedtxtCelularPessoa.Clear();
                        AtivoAlteracao = true;
                        this.IdFicha = 0;
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
            finally
            {
                this.Refresh();
            }
        }

        private void dataGridViewClassificados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                this.IdFicha = Convert.ToInt32(dataGridViewClassificados["ID_CLASSIFICACAO", e.RowIndex].Value);
                SqlConnection conn4 = new SqlConnection(this.connetionString);
                string sql4 = "SELECT NOME,TELEFONE,CELULAR FROM P_Pessoa WHERE ID_PESSOA =  " + this.IdFicha + ";";
                SqlDataAdapter sda4 = new SqlDataAdapter(sql4, conn4);
                DataSet ds4 = new DataSet();
                sda4.Fill(ds4);
                conn4.Open();

                txtNome.Text = ds4.Tables[0].Rows[0][0].ToString();
                txtTelefonePessoa.Text = ds4.Tables[0].Rows[0][1].ToString();
                maskedtxtCelularPessoa.Text = ds4.Tables[0].Rows[0][2].ToString();

                conn4.Close();
            }
            catch (Exception ex) {// MessageBox.Show("Error" + ex.ToString()); 
            }
        }
        private void buttonSalvarProcessoSelecao_Click(object sender, EventArgs e)
        {
            if (checkBoxStatusFinalizacao.Checked == false)
            {
                if (checkBoxStatusAtivo.Checked == false)
                {
                    SalvaCadastroProcessoSeletivoDesativado();
                }
                if (checkBoxStatusAtivo.Checked == true)
                {
                    SalvaCadastroProcessoSeletivoAtivo();
                }
            }
            if (checkBoxStatusFinalizacao.Checked == true)
            {
                if (checkBoxStatusAtivo.Checked == false)
                {
                    MessageBox.Show("Processo de Seleção só é finalizado com ele ativo!");
                }
                if (checkBoxStatusAtivo.Checked == true)
                {
                    SalvaCadastroProcessoSeletivoFinalizadoAtivo();
                }
            }
        }
        public void SalvaCadastroProcessoSeletivoDesativado()
        {
            try
            {
                //Excluir Processo Fichas Selecionadas
                ProcessoSeletivo ProcessoSeletivoP = new ProcessoSeletivo();
                ProcessoSeletivoP.IdProcessoSeletivo = this.IdProcessoSeletivo;
                ProcessoSeletivoP.txtComentatario = txtComentarios.Text;
                ProcessoSeletivoP.txtQuantVagas = txtQuantVagas.Text;
                ProcessoSeletivoP.Id_PessoaLogadaAlterada = this.IdLoginUsuario;

                Conexao2 conexao3 = new Conexao2(this.connetionString);
                DALDateSystemRH da3 = new DALDateSystemRH(conexao3);
                da3.ExcluirProcessoSeletivoP(ProcessoSeletivoP);

                for (int i = 0; i < Id_Ficha.Count; i++)
                {
                    //Muda ficha de Selecionados para Liberado
                    DadosPessoas DadosPessoasP = new DadosPessoas();
                    DadosPessoasP.Id_DadosPessoas = Id_Ficha[i];
                    DadosPessoasP.StatusMercado = 1;
                    Conexao2 conexao2 = new Conexao2(this.connetionString);
                    DALDateSystemRH da2 = new DALDateSystemRH(conexao2);
                    da2.UpdateStatusPessoaFicha(DadosPessoasP);
                }
                //Update Processo de Seleção  COMENTARIOS E VAGAS
                Conexao2 conexao1 = new Conexao2(this.connetionString);
                DALDateSystemRH da1 = new DALDateSystemRH(conexao1);
                da1.UpdateProcessoSeletivoP(ProcessoSeletivoP);

                //Altera Status da Processo Seletivo
                Conexao2 conexao4 = new Conexao2(this.connetionString);
                DALDateSystemRH da4 = new DALDateSystemRH(conexao4);
                ProcessoSeletivoP.checkBoxStatusAtivo = 2;
                da4.UpdateStatusProcessoSeletivoP(ProcessoSeletivoP);

                MessageBox.Show(" Desativado Processo!");
                FecharTodosFormulario();
            }
            catch (Exception ex) { MessageBox.Show("Error" + ex.ToString()); }
        }

        public void SalvaCadastroProcessoSeletivoFinalizadoAtivo()
        {
            try
            {
                ProcessoSeletivo ProcessoSeletivoP = new ProcessoSeletivo();
                DadosPessoas DadosPessoasP = new DadosPessoas();

                ProcessoSeletivoP.IdEmpresa = this.IdEmpresaCliente;
                ProcessoSeletivoP.IdProfissaoProcessoSeletivo = this.IdProfissao;
                ProcessoSeletivoP.txtComentatario = txtComentarios.Text;
                ProcessoSeletivoP.txtQuantVagas = txtQuantVagas.Text;
                ProcessoSeletivoP.dateTimePickerDataFechamento = dateTimePickerFechamentodoProcesso.Text;
                ProcessoSeletivoP.Id_PessoaLogadaAlterada = this.IdLoginUsuario;

                if (validaNomeEmpresa(txtNomeEmpresa, errorProviderPS) == true)
                {
                    if ((dateTimePickerFechamentodoProcesso.Text.Length == 10) && (dateTimePickerFechamentodoProcesso.Text.Length == 10))
                    {
                        //Data de criação não pode se maior que data de fechamento!
                        if ((Convert.ToDateTime(dateTimePickerFechamentodoProcesso.Text).Subtract(dateTimePickerCriacaoProcesso.Value).Days >= 0))
                        {
                            if (dataGridViewClassificados.RowCount != 0)
                            {
                                if (validaVagas(txtQuantVagas, errorProviderPS) == true)
                                {
                                    if (int.Parse(txtQuantVagas.Text) == dataGridViewClassificados.RowCount)
                                    {
                                        DialogResult dialogResult = MessageBox.Show("Deseja Finalizar Processo de Seleção  " + " ? ", " Aviso", MessageBoxButtons.YesNo);
                                        if (dialogResult == DialogResult.Yes)
                                        {
                                            if (AtivoAlteracao == true)
                                            {
                                                //Excluir Processo Fichas Selecionadas
                                                ProcessoSeletivoP.IdProcessoSeletivo = this.IdProcessoSeletivo;
                                                Conexao2 conexao3 = new Conexao2(this.connetionString);
                                                DALDateSystemRH da3 = new DALDateSystemRH(conexao3);
                                                da3.ExcluirProcessoSeletivoP(ProcessoSeletivoP);

                                                for (int i = 0; i < Id_Ficha.Count; i++)
                                                {
                                                    //Muda ficha de Selecionados para Liberado
                                                    DadosPessoasP.Id_DadosPessoas = Id_Ficha[i];
                                                    DadosPessoasP.StatusMercado = 1;
                                                    Conexao2 conexao1 = new Conexao2(this.connetionString);
                                                    DALDateSystemRH da1 = new DALDateSystemRH(conexao1);
                                                    da1.UpdateStatusPessoaFicha(DadosPessoasP);
                                                }
                                                //Update Processo de Seleção COMENTARIO E VAGAS
                                                Conexao2 conexao2 = new Conexao2(this.connetionString);
                                                DALDateSystemRH da2 = new DALDateSystemRH(conexao2);
                                                da2.UpdateProcessoSeletivoP(ProcessoSeletivoP);

                                                //Update Processo de Seleção Status
                                                Conexao2 conexao6 = new Conexao2(this.connetionString);
                                                DALDateSystemRH da6 = new DALDateSystemRH(conexao6);
                                                ProcessoSeletivoP.checkBoxStatusFinalizacao = 1;
                                                da6.UpdateStatusProcessoFinalizado(ProcessoSeletivoP);

                                                //Cadastra Novas Canditados Seleção
                                                CandidatosPSeletivo CandidatosPSeletivoP = new CandidatosPSeletivo();
                                                CandidatosPSeletivoP.idProcessoSeletivo = ProcessoSeletivoP.IdProcessoSeletivo;

                                                for (int inicio = 0; inicio < dataGridViewClassificados.RowCount; inicio++)
                                                {
                                                    int IdPessoaSelecionada = int.Parse(dataGridViewClassificados.Rows[inicio].Cells[0].Value.ToString());

                                                    CandidatosPSeletivoP.IdPessoa = IdPessoaSelecionada;

                                                    Conexao2 conexao4 = new Conexao2(this.connetionString);
                                                    DALDateSystemRH da4 = new DALDateSystemRH(conexao4);
                                                    da4.IncluirCadastraCandidatosPSeletivo(CandidatosPSeletivoP);

                                                    DadosPessoasP.Id_DadosPessoas = IdPessoaSelecionada;
                                                    DadosPessoasP.StatusMercado = 3;
                                                    Conexao2 conexao5 = new Conexao2(this.connetionString);
                                                    DALDateSystemRH da5 = new DALDateSystemRH(conexao5);
                                                    da5.UpdateStatusPessoaFicha(DadosPessoasP);
                                                }
                                            }
                                            else
                                            {
                                                ProcessoSeletivoP.IdProcessoSeletivo = this.IdProcessoSeletivo;
                                                //Update Processo de Seleção Finalizacao
                                                Conexao2 conexao6 = new Conexao2(this.connetionString);
                                                DALDateSystemRH da6 = new DALDateSystemRH(conexao6);
                                                ProcessoSeletivoP.checkBoxStatusFinalizacao = 1;
                                                da6.UpdateStatusProcessoFinalizado(ProcessoSeletivoP);

                                                //Update Processo de Seleção COMENTARIO E VAGAS
                                                Conexao2 conexao2 = new Conexao2(this.connetionString);
                                                DALDateSystemRH da2 = new DALDateSystemRH(conexao2);
                                                da2.UpdateProcessoSeletivoP(ProcessoSeletivoP);

                                                for (int inicio = 0; inicio < dataGridViewClassificados.RowCount; inicio++)
                                                {
                                                    int IdPessoaSelecionada = int.Parse(dataGridViewClassificados.Rows[inicio].Cells[0].Value.ToString());

                                                    DadosPessoasP.Id_DadosPessoas = IdPessoaSelecionada;
                                                    DadosPessoasP.StatusMercado = 3;
                                                    Conexao2 conexao5 = new Conexao2(this.connetionString);
                                                    DALDateSystemRH da5 = new DALDateSystemRH(conexao5);
                                                    da5.UpdateStatusPessoaFicha(DadosPessoasP);
                                                }
                                            }
                                            MessageBox.Show(" Finalizado com exito Ativo!");
                                            FecharTodosFormulario();

                                        }
                                        else if (dialogResult == DialogResult.No)
                                        {

                                        }
                                    }
                                    else { MessageBox.Show("Número de canditatos não compatível!"); }
                                }
                                else { MessageBox.Show("Adicione Número de vagas!"); }
                            }
                            else { MessageBox.Show("Sem adicionar canditados pela vaga em classificados!"); }
                        }
                        else MessageBox.Show("Atenção a data de fechamento não pode ser menor que a data de criação!");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error" + ex.ToString()); }
        }
        public void SalvaCadastroProcessoSeletivoAtivo()
        {
            try
            {
                ProcessoSeletivo ProcessoSeletivoP = new ProcessoSeletivo();
                DadosPessoas DadosPessoasP = new DadosPessoas();

                ProcessoSeletivoP.IdEmpresa = this.IdEmpresaCliente;
                ProcessoSeletivoP.IdProfissaoProcessoSeletivo = this.IdProfissao;
                ProcessoSeletivoP.txtComentatario = txtComentarios.Text;
                ProcessoSeletivoP.txtQuantVagas = txtQuantVagas.Text;
                ProcessoSeletivoP.Id_PessoaLogadaAlterada = this.IdLoginUsuario;

                if (validaNomeEmpresa(txtNomeEmpresa, errorProviderPS) == true)
                {
                    if (dataGridViewClassificados.RowCount != 0)
                    {
                        if (validaVagas(txtQuantVagas, errorProviderPS) == true)
                        {
                            if (AtivoAlteracao == true)
                            {
                                //Excluir Processo Fichas Selecionadas

                                ProcessoSeletivoP.IdProcessoSeletivo = this.IdProcessoSeletivo;
                                Conexao2 conexao3 = new Conexao2(this.connetionString);
                                DALDateSystemRH da3 = new DALDateSystemRH(conexao3);
                                da3.ExcluirProcessoSeletivoP(ProcessoSeletivoP);

                                for (int i = 0; i < Id_Ficha.Count; i++)
                                {
                                    //Muda ficha de Selecionados para Liberado
                                    DadosPessoasP.Id_DadosPessoas = Id_Ficha[i];
                                    DadosPessoasP.StatusMercado = 1;
                                    Conexao2 conexao1 = new Conexao2(this.connetionString);
                                    DALDateSystemRH da1 = new DALDateSystemRH(conexao1);
                                    da1.UpdateStatusPessoaFicha(DadosPessoasP);
                                }
                                //Update Processo de Seleção  COMENTARIOS E VAGAS
                                Conexao2 conexao2 = new Conexao2(this.connetionString);
                                DALDateSystemRH da2 = new DALDateSystemRH(conexao2);
                                da2.UpdateProcessoSeletivoP(ProcessoSeletivoP);

                                //Cadastra Novas Canditados Seleção
                                CandidatosPSeletivo CandidatosPSeletivoP = new CandidatosPSeletivo();
                                CandidatosPSeletivoP.idProcessoSeletivo = ProcessoSeletivoP.IdProcessoSeletivo;

                                for (int inicio = 0; inicio < dataGridViewClassificados.RowCount; inicio++)
                                {
                                    int IdPessoaSelecionada = int.Parse(dataGridViewClassificados.Rows[inicio].Cells[0].Value.ToString());

                                    CandidatosPSeletivoP.IdPessoa = IdPessoaSelecionada;

                                    Conexao2 conexao4 = new Conexao2(this.connetionString);
                                    DALDateSystemRH da4 = new DALDateSystemRH(conexao4);
                                    da4.IncluirCadastraCandidatosPSeletivo(CandidatosPSeletivoP);


                                    DadosPessoasP.Id_DadosPessoas = IdPessoaSelecionada;
                                    DadosPessoasP.StatusMercado = 2;

                                    Conexao2 conexao5 = new Conexao2(this.connetionString);
                                    DALDateSystemRH da5 = new DALDateSystemRH(conexao5);
                                    da5.UpdateStatusPessoaFicha(DadosPessoasP);
                                }
                            }
                            else
                            {
                                ProcessoSeletivoP.IdProcessoSeletivo = this.IdProcessoSeletivo;
                                //Update Processo de Seleção COMENTARIO E VAGAS
                                Conexao2 conexao2 = new Conexao2(this.connetionString);
                                DALDateSystemRH da2 = new DALDateSystemRH(conexao2);
                                da2.UpdateProcessoSeletivoP(ProcessoSeletivoP);
                            }

                            MessageBox.Show(" Adicionado com exito Ativo!");
                            FecharTodosFormulario();
                        }
                        else { MessageBox.Show("Adicione Número de vagas!"); }
                    }
                    else { MessageBox.Show("Sem adicionar canditados pela vaga em classificados!"); }
                }
            }
            catch(Exception ex) { MessageBox.Show("Error" + ex.ToString()); }           
        }
        void Fill_listBoxTodasEstabilidade()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC RH_ConsultaCadastroTodosEstabilidade;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(0);
                    comboBoxEstabilidade.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBoxEstabilidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();

                string Query = " SELECT ID_ESTABILIDADE, NOME_ESTABILIDADE FROM P_Estabilidade WHERE NOME_ESTABILIDADE = '" + this.comboBoxEstabilidade.Text + "';";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {

                    this.IdPEstabilidade = dr.GetInt32(0);
                    comboBoxEstabilidade.Text = dr.GetString(1);
                    //label8.Text = dr.GetString(1);
                    //this.ComboBoxAbreviacao = dr.GetString(1);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPesquisaFicha_Click(object sender, EventArgs e)
        {
            if (this.IdProfissao == 0)
            {
                MessageBox.Show("Selecione profissão para vaga!");
            }
            else
            {
                BuscaFichaEmprego();
            }
        }
        public void BuscaFichaEmprego()
        {
            try
            {
                int Temp_Profisao = 0;
                int Usar_Regiao = 0;
                int Temp_estabilidade = 0;
                int Usar_CNH = 0;
                int CNH_A = 0;
                int CNH_B = 0;
                int CNH_C = 0;
                int CNH_D = 0;
                if (this.IdProfissao == 0) { Temp_Profisao = 0; } else { Temp_Profisao = this.IdProfissao; };
                if (radioButtonSemRegiao.Checked == false)
                {
                    if (radioButtonLeste.Checked == true) { Usar_Regiao = 1; }
                    if (radioButtonOeste.Checked == true) { Usar_Regiao = 2; }
                    if (radioButtonNorte.Checked == true) { Usar_Regiao = 3; }
                    if (radioButtonSul.Checked == true) { Usar_Regiao = 4; }
                    if (radioButtonCentro.Checked == true) { Usar_Regiao = 5; }
                    if (radioButtonABC.Checked == true) { Usar_Regiao = 6; }
                    if (radioButtonGuarulhos.Checked == true) { Usar_Regiao = 7; }
                    if (radioButtonInterior.Checked == true) { Usar_Regiao = 8; }
                }
                else { Usar_Regiao = 0; }
                if (this.IdPEstabilidade == 0) { Temp_estabilidade = 0; } else { Temp_estabilidade = this.IdPEstabilidade; }
                if (checkBoxAtivaVerifcacao.Checked == true) { Usar_CNH = 1; } else { Usar_CNH = 0; }
                if (checkBoxCMA.Checked == true) { CNH_A = 1; } else { CNH_A = 2; }
                if (checkBoxCMB.Checked == true) { CNH_B = 1; } else { CNH_B = 2; }
                if (checkBoxCMC.Checked == true) { CNH_C = 1; } else { CNH_C = 2; }
                if (checkBoxCMD.Checked == true) { CNH_D = 1; } else { CNH_D = 2; }

                SqlConnection conn = new SqlConnection(this.connetionString);

                if (radioButtonFichasTodos.Checked == true)
                {
                    dataGridViewFichasCadastrada.Refresh();
                    label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();

                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter(
                        "EXEC RH_ConsultaFichaEmpregoTodosPSTxt " + Temp_Profisao + "," + Usar_Regiao + "," + Temp_estabilidade + ","
                        + Usar_CNH + "," + CNH_A + "," + CNH_B + "," + CNH_C + "," + CNH_D + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (this.dataGridViewFichasCadastrada.DataSource != null)
                        {
                            this.dataGridViewFichasCadastrada.DataSource = null;
                        }
                        else
                        {
                            this.dataGridViewFichasCadastrada.Rows.Clear();

                        }
                        LimpaFichasCadastradas(1);
                        ValorPesquisa = 1;
                        label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                        MessageBox.Show("Nem uma Ficha foi encontrado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        ValorPesquisa = 1;
                        PesquisaTodosFichasPS();
                        label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                    }
                }
                if (radioButtonPesquisarRG.Checked == true)
                {

                    dataGridViewFichasCadastrada.Refresh();
                    label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();

                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter(
                        "EXEC RH_ConsultaFichaEmpregoRgPSTxt '" + txtPesquisaRG.Text + "'," + Temp_Profisao + "," + Usar_Regiao + "," + Temp_estabilidade + ","
                        + Usar_CNH + "," + CNH_A + "," + CNH_B + "," + CNH_C + "," + CNH_D + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (this.dataGridViewFichasCadastrada.DataSource != null)
                        {
                            this.dataGridViewFichasCadastrada.DataSource = null;
                        }
                        else
                        {
                            this.dataGridViewFichasCadastrada.Rows.Clear();

                        }
                        LimpaFichasCadastradas(1);
                        label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                        MessageBox.Show("Nem uma Ficha foi encontrado!");
                        ValorPesquisa = 2;
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        ValorPesquisa = 2;
                        PesquisaRgPS();
                        label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                    }
                }
                if (radioButtonCpf.Checked == true)
                {

                    dataGridViewFichasCadastrada.Refresh();
                    label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();

                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter(
                        "EXEC RH_ConsultaFichaEmpregoRgPSTxt '" + txtCpf.Text + "'," + Temp_Profisao + "," + Usar_Regiao + "," + Temp_estabilidade + ","
                        + Usar_CNH + "," + CNH_A + "," + CNH_B + "," + CNH_C + "," + CNH_D + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (this.dataGridViewFichasCadastrada.DataSource != null)
                        {
                            this.dataGridViewFichasCadastrada.DataSource = null;
                        }
                        else
                        {
                            this.dataGridViewFichasCadastrada.Rows.Clear();

                        }
                        LimpaFichasCadastradas(1);
                        label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                        MessageBox.Show("Nem uma Ficha foi encontrado!");
                        ValorPesquisa = 3;
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        ValorPesquisa = 3;
                        PesquisaCpfPS();
                        label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                    }
                }
                if (radioButtonNome.Checked == true)
                {

                    dataGridViewFichasCadastrada.Refresh();
                    label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();

                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter(
                        "EXEC RH_ConsultaFichaEmpregoNomePSTxt '" + txtPesquisaNomePessoa.Text + "'," + Temp_Profisao + "," + Usar_Regiao + "," + Temp_estabilidade + ","
                        + Usar_CNH + "," + CNH_A + "," + CNH_B + "," + CNH_C + "," + CNH_D + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (this.dataGridViewFichasCadastrada.DataSource != null)
                        {
                            this.dataGridViewFichasCadastrada.DataSource = null;
                        }
                        else
                        {
                            this.dataGridViewFichasCadastrada.Rows.Clear();

                        }
                        LimpaFichasCadastradas(1);
                        label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                        MessageBox.Show("Nem uma Ficha foi encontrado!");
                        ValorPesquisa = 4;
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        ValorPesquisa = 4;
                        PesquisaNomePS();
                        label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                    }
                }
                if ((radioButtonFichasTodos.Checked == false) && (radioButtonPesquisarRG.Checked == false) && (radioButtonCpf.Checked == false) &&
                    (radioButtonNome.Checked == false))
                {
                    MessageBox.Show("Selecione Todos, Rg, Cpf ou nome!");
                }
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
        }
        private void txtPesquisaMs_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtPesquisaRG_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ValorPesquisa == 2)
                {
                    DataView DV = new DataView(TableRg);
                    DV.RowFilter = string.Format("RG_P LIKE '%{0}%'", txtPesquisaRG.Text);
                    dataGridViewFichasCadastrada.DataSource = DV;
                    label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ValorPesquisa == 3)
                {
                    DataView DV = new DataView(TableCpf);
                    DV.RowFilter = string.Format("CPF_P LIKE '%{0}%'", txtCpf.Text);
                    dataGridViewFichasCadastrada.DataSource = DV;
                    label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }
        private void txtPesquisaNomePessoa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ValorPesquisa == 4)
                {
                    DataView DV = new DataView(TableNomePessoa);
                    DV.RowFilter = string.Format("NOME_P LIKE '%{0}%'", txtPesquisaNomePessoa.Text);
                    dataGridViewFichasCadastrada.DataSource = DV;
                    label17.Text = dataGridViewFichasCadastrada.RowCount.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonFechaProcessoSeletivo_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }
        public void FecharTodosFormulario()
        {
            FechaFormularios(typeof(FormFotoFicha));
            FechaFormularios(typeof(FormProcessoSelecaoEditar));
        }
        public void FecharTodosFormulario2()
        {
            FechaFormularios(typeof(FormFotoFicha));
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
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditarProcessoSeletivo();
        }
        public void EditarProcessoSeletivo()
        {
            panel2.Enabled = true;
            panel3.Enabled = true;
            panel4.Enabled = true;
            panel5.Enabled = true;
            panel6.Enabled = true;
            panel7.Enabled = true;
            buttonPesquisaFicha.Enabled = true;
            comboBoxEstabilidade.Enabled = true;
            buttonSalvarProcessoSelecao.Enabled = true;
            buttonEditar.Enabled = false;
            buttonLimpoEstabilidade.Enabled = true;


        }

        private void buttonLimpoEstabilidade_Click(object sender, EventArgs e)
        {
            LimpaEstabilidade();
        }
        public void LimpaEstabilidade()
        {
            this.IdPEstabilidade = 0;
            comboBoxEstabilidade.Items.Clear();
            Fill_listBoxTodasEstabilidade();
        }

        private void txtPesquisaRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                BuscaFichaEmprego();
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                BuscaFichaEmprego();
            }
        }

        private void txtPesquisaNomePessoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BuscaFichaEmprego();
            }
        }

        private void txtQuantVagas_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Se a tecla digitada não for número
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                {
                    //Atribui True no Handled para cancelar o evento
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonFotoCanditado_Click(object sender, EventArgs e)
        {
            FotoFicha();
        }
        public void FotoFicha()
        {
            if (IdFicha == 0)
            {
                MessageBox.Show("Clica em algum registro de processo seletivo");
            }
            else
            {
                FecharTodosFormulario2();
                FormFotoFicha FormFotoFichaF = new FormFotoFicha(this.IdFicha, this.EditarFicha, this.IdLoginUsuario);
                FormFotoFichaF.Show();
                FormFotoFichaF.Top = 200;
                FormFotoFichaF.Left = 150;
            }
        }
    }
}
