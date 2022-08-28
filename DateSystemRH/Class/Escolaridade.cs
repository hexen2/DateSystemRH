using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystemRH
{
    class Escolaridade
    {
        public Escolaridade()
        {
            this.Id_PessoasEscolaridade = 0;
            this.radioButton1GN = 0;
            this.radioButton2GSN = 0;
            this.radioButtonSSN = 0;
            this.txtSuperiorCurso = "";
            this.radioButtonESSN = 0;
            this.txtEstudaAtualmente = "";
            this.txtAnoEstaCursando = "";
            this.txtBairroCursando = "";
            this.maskedTxtHorarioCursando = "";

        }

        public Escolaridade(int ID_PESSOA_ESCOLARIDADE, int RADIOBUTTON1GN, int RADIOBUTTON2GSN, int RADIOBUTTONSSN, 
            String TXTSUPERIORSURSO, int RADIOBUTTONESSN, string TXTESTUDAATUALMENTE, string TXTANOESTACURSANDO,
            string TXTBAIRROCURSANDO, string MASKEDTXTHORARIOCURSANDO)
        {

            this.Id_PessoasEscolaridade = ID_PESSOA_ESCOLARIDADE;
            this.radioButton1GN = RADIOBUTTON1GN;
            this.radioButton2GSN = RADIOBUTTON2GSN;
            this.radioButtonSSN = RADIOBUTTONSSN;
            this.txtSuperiorCurso = TXTSUPERIORSURSO;
            this.radioButtonESSN = RADIOBUTTONESSN;
            this.txtEstudaAtualmente = TXTESTUDAATUALMENTE;
            this.txtAnoEstaCursando = TXTANOESTACURSANDO;
            this.txtBairroCursando = TXTBAIRROCURSANDO;
            this.maskedTxtHorarioCursando = MASKEDTXTHORARIOCURSANDO;

        }

        private int ID_PESSOA_ESCOLARIDADE;
        public int Id_PessoasEscolaridade
        {
            get
            {
                return this.ID_PESSOA_ESCOLARIDADE;

            }
            set
            {
                this.ID_PESSOA_ESCOLARIDADE = value;
            }
        }

        private int RADIOBUTTON1GN;
        public int radioButton1GN
        {
            get
            {
                return this.RADIOBUTTON1GN;

            }
            set
            {
                this.RADIOBUTTON1GN = value;
            }
        }
        private int RADIOBUTTON2GSN;
        public int radioButton2GSN
        {
            get
            {
                return this.RADIOBUTTON2GSN;

            }
            set
            {
                this.RADIOBUTTON2GSN = value;
            }
        }
        private int RADIOBUTTONSSN;
        public int radioButtonSSN
        {
            get
            {
                return this.RADIOBUTTONSSN;

            }
            set
            {
                this.RADIOBUTTONSSN = value;
            }
        }
        private string TXTSUPERIORSURSO;
        public string txtSuperiorCurso
        {
            get
            {
                return this.TXTSUPERIORSURSO;

            }
            set
            {
                this.TXTSUPERIORSURSO = value;
            }
        }

        private int RADIOBUTTONESSN;
        public int radioButtonESSN
        {
            get
            {
                return this.RADIOBUTTONESSN;

            }
            set
            {
                this.RADIOBUTTONESSN = value;
            }
        }
        private string TXTESTUDAATUALMENTE;
        public string txtEstudaAtualmente
        {
            get
            {
                return this.TXTESTUDAATUALMENTE;

            }
            set
            {
                this.TXTESTUDAATUALMENTE = value;
            }
        }
        private string TXTANOESTACURSANDO;
        public string txtAnoEstaCursando
        {
            get
            {
                return this.TXTANOESTACURSANDO;

            }
            set
            {
                this.TXTANOESTACURSANDO = value;
            }
        }
        private string TXTBAIRROCURSANDO;
        public string txtBairroCursando
        {
            get
            {
                return this.TXTBAIRROCURSANDO;

            }
            set
            {
                this.TXTBAIRROCURSANDO = value;
            }
        }

        private string MASKEDTXTHORARIOCURSANDO;
        public string maskedTxtHorarioCursando
        {
            get
            {
                return this.MASKEDTXTHORARIOCURSANDO;

            }
            set
            {
                this.MASKEDTXTHORARIOCURSANDO = value;
            }
        }
    }
}
