using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystemRH
{
    class Profissionais
    {
        public Profissionais()
        {
            this.Id_PessoasProfissional = 0;
            this.dateTimePickerFormacaoVigilante = "";
            this.txtNomeAcademiaVigilante = "";
            this.dateTimePickerReciclagem = "";
            this.txtNomeAcademiaReciclagem = "";
            this.txtCursoPortaria = "";
            this.txtEscolaPortaria = "";
            this.radioButtonCSN = 0;
            this.radioButtonOCSN = 0;
            this.txtQuaisCursos = "";
            this.radioButtonRHSN = 0;
        }

        public Profissionais(int ID_PESSOA_PROFISSIONAL, string DATETIMEPICKERFORMACAOVIGILANTE, string TXTNOMEACADEMIAVIGILANTE,
            string DATETIMEPICKERRECICLAGEM,
            String TXTNOMEACADEMIARECICLAGEM, string TXTCURSOPORTARIA, string TXTESCOLAPORTARIA, int RADIOBUTTONCSN,
            int RADIOBUTTONOCSN, string TXTQUAISCURSOS, int RADIOBUTTONRHSN)
        {
            
            this.Id_PessoasProfissional = ID_PESSOA_PROFISSIONAL;
            this.dateTimePickerFormacaoVigilante = DATETIMEPICKERFORMACAOVIGILANTE;
            this.txtNomeAcademiaVigilante = TXTNOMEACADEMIAVIGILANTE;
            this.dateTimePickerReciclagem = DATETIMEPICKERRECICLAGEM;
            this.txtNomeAcademiaReciclagem = TXTNOMEACADEMIARECICLAGEM;
            this.txtCursoPortaria = TXTCURSOPORTARIA;
            this.txtEscolaPortaria = TXTESCOLAPORTARIA;
            this.radioButtonCSN = RADIOBUTTONCSN;
            this.radioButtonOCSN = RADIOBUTTONOCSN;
            this.txtQuaisCursos = TXTQUAISCURSOS;
            this.radioButtonRHSN = RADIOBUTTONRHSN;

        }

        private int ID_PESSOA_PROFISSIONAL;
        public int Id_PessoasProfissional
        {
            get
            {
                return this.ID_PESSOA_PROFISSIONAL;

            }
            set
            {
                this.ID_PESSOA_PROFISSIONAL = value;
            }
        }

        private string DATETIMEPICKERFORMACAOVIGILANTE;
        public string dateTimePickerFormacaoVigilante
        {
            get
            {
                return this.DATETIMEPICKERFORMACAOVIGILANTE;

            }
            set
            {
                this.DATETIMEPICKERFORMACAOVIGILANTE = value;
            }
        }
        private String TXTNOMEACADEMIAVIGILANTE;
        public string txtNomeAcademiaVigilante
        {
            get
            {
                return this.TXTNOMEACADEMIAVIGILANTE;

            }
            set
            {
                this.TXTNOMEACADEMIAVIGILANTE = value;
            }
        }
        private string DATETIMEPICKERRECICLAGEM;
        public string dateTimePickerReciclagem
        {
            get
            {
                return this.DATETIMEPICKERRECICLAGEM;

            }
            set
            {
                this.DATETIMEPICKERRECICLAGEM = value;
            }
        }
        private string TXTNOMEACADEMIARECICLAGEM;
        public string txtNomeAcademiaReciclagem
        {
            get
            {
                return this.TXTNOMEACADEMIARECICLAGEM;

            }
            set
            {
                this.TXTNOMEACADEMIARECICLAGEM = value;
            }
        }

        private string TXTCURSOPORTARIA;
        public string txtCursoPortaria
        {
            get
            {
                return this.TXTCURSOPORTARIA;

            }
            set
            {
                this.TXTCURSOPORTARIA = value;
            }
        }
        private string TXTESCOLAPORTARIA;
        public string txtEscolaPortaria
        {
            get
            {
                return this.TXTESCOLAPORTARIA;

            }
            set
            {
                this.TXTESCOLAPORTARIA = value;
            }
        }
        private int RADIOBUTTONCSN;
        public int radioButtonCSN
        {
            get
            {
                return this.RADIOBUTTONCSN;

            }
            set
            {
                this.RADIOBUTTONCSN = value;
            }
        }
        private int RADIOBUTTONOCSN;
        public int radioButtonOCSN
        {
            get
            {
                return this.RADIOBUTTONOCSN;

            }
            set
            {
                this.RADIOBUTTONOCSN = value;
            }
        }

        private string TXTQUAISCURSOS;
        public string txtQuaisCursos
        {
            get
            {
                return this.TXTQUAISCURSOS;

            }
            set
            {
                this.TXTQUAISCURSOS = value;
            }
        }
        private int RADIOBUTTONRHSN;
        public int radioButtonRHSN
        {
            get
            {
                return this.RADIOBUTTONRHSN;

            }
            set
            {
                this.RADIOBUTTONRHSN = value;
            }
        }
    }
}
