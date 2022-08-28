using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystemRH
{
    class Avaliacao
    {
        public Avaliacao()
        {
            this.Id_PessoasAvaliacao = 0;
            this.radioButtonPASN = 0;
            this.txtEntrevistadoAprovado = "";
            this.txtComentariosAprovado = "";
            this.radioButtonPFASN = 0;
            this.txtEntrevistadoAproveitamento = "";
            this.txtComentariosEntrevistado = "";
            this.dateTimePickerDataTreinamentoAvaliacao = "";
            this.txtMSAvaliacao = "";



        }

        public Avaliacao(int ID_PESSOA_AVALIACAO, int RADIOBUTTONPASN, string TXTENTREVISTAAPROVADO,
            string TXTCOMENTARIOSAPROVADO, int RADIOBUTTONPFASN, string TXTCOMENTARIOSENTREVISTADO,
            string TXTENTREVISTADOAPROVEITAMENTO, string DATETIMEPICKERDATATREINAMENTOAVALIACAO, string TXTMSAVALIACAO)
        {

            this.Id_PessoasAvaliacao = ID_PESSOA_AVALIACAO;
            this.radioButtonPASN = RADIOBUTTONPASN;
            this.txtEntrevistadoAprovado = TXTENTREVISTAAPROVADO;
            this.txtComentariosAprovado = TXTCOMENTARIOSAPROVADO;
            this.radioButtonPFASN = RADIOBUTTONPFASN;
            this.txtComentariosEntrevistado = TXTCOMENTARIOSENTREVISTADO;
            this.txtEntrevistadoAproveitamento = TXTENTREVISTADOAPROVEITAMENTO;
            this.dateTimePickerDataTreinamentoAvaliacao = DATETIMEPICKERDATATREINAMENTOAVALIACAO;
            this.txtMSAvaliacao = TXTMSAVALIACAO;

        }

        private int ID_PESSOA_AVALIACAO;
        public int Id_PessoasAvaliacao
        {
            get
            {
                return this.ID_PESSOA_AVALIACAO;

            }
            set
            {
                this.ID_PESSOA_AVALIACAO = value;
            }
        }

        private int RADIOBUTTONPASN;
        public int radioButtonPASN
        {
            get
            {
                return this.RADIOBUTTONPASN;

            }
            set
            {
                this.RADIOBUTTONPASN = value;
            }
        }
        private String TXTENTREVISTAAPROVADO;
        public string txtEntrevistadoAprovado
        {
            get
            {
                return this.TXTENTREVISTAAPROVADO;

            }
            set
            {
                this.TXTENTREVISTAAPROVADO = value;
            }
        }
        private string TXTCOMENTARIOSAPROVADO;
        public string txtComentariosAprovado
        {
            get
            {
                return this.TXTCOMENTARIOSAPROVADO;

            }
            set
            {
                this.TXTCOMENTARIOSAPROVADO = value;
            }
        }
        private int RADIOBUTTONPFASN;
        public int radioButtonPFASN
        {
            get
            {
                return this.RADIOBUTTONPFASN;

            }
            set
            {
                this.RADIOBUTTONPFASN = value;
            }
        }

        private string TXTENTREVISTADOAPROVEITAMENTO;
        public string txtEntrevistadoAproveitamento
        {
            get
            {
                return this.TXTENTREVISTADOAPROVEITAMENTO;

            }
            set
            {
                this.TXTENTREVISTADOAPROVEITAMENTO = value;
            }
        }
        private string TXTCOMENTARIOSENTREVISTADO;
        public string txtComentariosEntrevistado
        {
            get
            {
                return this.TXTCOMENTARIOSENTREVISTADO;

            }
            set
            {
                this.TXTCOMENTARIOSENTREVISTADO = value;
            }
        }
        private string DATETIMEPICKERDATATREINAMENTOAVALIACAO;
        public string dateTimePickerDataTreinamentoAvaliacao
        {
            get
            {
                return this.DATETIMEPICKERDATATREINAMENTOAVALIACAO;

            }
            set
            {
                this.DATETIMEPICKERDATATREINAMENTOAVALIACAO = value;
            }
        }
        private string TXTMSAVALIACAO;
        public string txtMSAvaliacao
        {
            get
            {
                return this.TXTMSAVALIACAO;

            }
            set
            {
                this.TXTMSAVALIACAO = value;
            }
        }
    }
}
