using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.IO;

namespace DateSystemRH
{
    public partial class FormFotoFicha : Form
    {
        Bitmap bmp;
        private string IMGLOCATION = "";
        public string ImgLocation
        {
            get
            {
                return this.IMGLOCATION;

            }
            set
            {
                this.IMGLOCATION = value;
            }
        }
        private Image IMAGEM = null;
        public Image Imagem
        {
            get
            {
                return this.IMAGEM;

            }
            set
            {
                this.IMAGEM = value;
            }
        }
        private int FichaEDITAR = 0;
        public int FichaEditar
        {
            get
            {
                return this.FichaEDITAR;

            }
            set
            {
                this.FichaEDITAR = value;
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
        private Boolean CONSTAIMAGEM = false;
        public Boolean ConstaImagem
        {
            get
            {
                return this.CONSTAIMAGEM;

            }
            set
            {
                this.CONSTAIMAGEM = value;
            }
        }
        private int ID_LOGIN_USUARIO = 0;
        public int IdloginUsuario
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
        public FormFotoFicha(int IdFicha,int EditarFicha, int IdLoginUsuario)
        {
            InitializeComponent();

            this.connetionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSRH;Persist Security Info=True;User ID=msos;Password=msos2019;";

            this.IdFicha = IdFicha;
            this.FichaEditar = EditarFicha;
            this.IdloginUsuario = IdLoginUsuario;

            FotoFicha();

            if(this.FichaEditar == 1)
            {
                buttonAnexo.Enabled = true;

            }

        }
        public FormFotoFicha()
        {
            InitializeComponent();

            //FotoFicha();
        }
        private void buttonAnexo_Click(object sender, EventArgs e)
        {
            AnexoFoto();
        }
        public void AnexoFoto()
        {
            openFileDialog.Filter = "JPG Files(*.jpg)|*.jpg|JPG Files(*.png)|*.png";// all files(*.*) | *.*

            DialogResult dialogResult = MessageBox.Show("Deseja Anexa uma imagem!", "Aviso", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    buttonSalvarImagem.Enabled = true;

                    openFileDialog.ShowDialog();

                    ImgLocation = openFileDialog.FileNames.ToString();

                    label15.Text = openFileDialog.FileName;

                    pictureBoxImagem.Image = Image.FromFile(openFileDialog.FileName);

                    bmp = new Bitmap(label15.Text);
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }


            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Cancelado o Anexo da Imagem!");
            }
        }

        private void FormFotoFicha_Load(object sender, EventArgs e)
        {

        }
        public void FotoFicha()
        {
            SqlConnection conn = new SqlConnection(this.connetionString);
            SqlCommand comand = new SqlCommand("RH_ConsultaFichaImagemSalva " + this.IdFicha + ";", conn);
            conn.Open();

            SqlDataReader reader = comand.ExecuteReader();

            if (reader.Read())
            {
                byte[] Foto = (byte[])reader["IMAGEM"];
                MemoryStream ms = new MemoryStream(Foto);
                Imagem = Image.FromStream(ms);
            }
            if (Imagem == null)
            {
                //MessageBox.Show("Não existir Imagem!");
            }
            if (Imagem != null)
            {
                pictureBoxImagem.Image = Imagem;
                ConstaImagem = true;
            }
        }

        private void buttonSalvarImagem_Click(object sender, EventArgs e)
        {
            SalvarImagem();
        }
        public void SalvarImagem()
        {
            Conexao2 conexao2 = new Conexao2(this.connetionString);

            //ADICIONAR IMAGEM FICHA
            FichaImagem Imagem = new FichaImagem();

            Imagem.IdFicha = this.IdFicha;
            Imagem.IdLoginUsuario = this.IdloginUsuario;

            if (bmp == null)
            {
                MessageBox.Show("Sem Anexa Imagem não poderá se salvo!");
            }
            if (bmp != null)
            {
                MemoryStream memory = new MemoryStream();

                bmp.Save(memory, ImageFormat.Bmp);

                byte[] Foto = memory.ToArray();

                Imagem.Imagem = Foto;

                //Acessa Banco de Dados e Salvar Imagem 
                if (this.ConstaImagem == true)
                {
                    DALDateSystemRH daUp = new DALDateSystemRH(conexao2);
                    daUp.AlterarFichaImagem(Imagem);
                }
                if (this.ConstaImagem == false)
                {
                    DALDateSystemRH daIn = new DALDateSystemRH(conexao2);
                    daIn.IncluirFichaImagem(Imagem);
                }
                FecharTodosFormulario();
                MessageBox.Show("Ficha Alterado com Sucesso!");
            }
        }
        public void FecharTodosFormulario()
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

        private void FormFotoFicha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void buttonFecha_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }
    }
}
