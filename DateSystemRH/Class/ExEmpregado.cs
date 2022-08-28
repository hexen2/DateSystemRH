using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystemRH
{
    class ExEmpregado
    {
        public ExEmpregado()
        {
            this.Id_PessoasExEmpregado = 0;
            this.radioButtonJTEMSS = 0;
            this.txtNomeEmpregado = "";
            this.txtQualPosto = "";
            this.dateTimePickerAdmissaoEmpregado = "";
            this.dateTimePickerDemissaoEmpregado = "";
            this.txtQuemSupervisor = "";
            this.txtMotivoSaida = "";
            this.txtREEmpregado = "";
            this.txtTreinamentoInforme = "";
            this.txtRedacao = "";


        }

        public ExEmpregado(int ID_PESSOA_EXEMPREGADO, int RADIOBUTTONJTEMSS, string TXTNOMEEMPREGADO,
            string TXTQUALPOSTO, string DATETIMEPICKERADMISSAOEMPREGADO, string DATETIMEPICKERDEMISSAOEMPREGADO,
            string TXTQUEMSUPERVISOR, string TXTMOTIVOSAIDA, string TXTREEMPREGADO, string TXTREINAMENTOINFORME,
            string TXTREDACAO)
        {
            
            this.Id_PessoasExEmpregado = ID_PESSOA_EXEMPREGADO;
            this.radioButtonJTEMSS = RADIOBUTTONJTEMSS;
            this.txtNomeEmpregado = TXTNOMEEMPREGADO;
            this.txtQualPosto = TXTQUALPOSTO;
            this.dateTimePickerAdmissaoEmpregado = DATETIMEPICKERADMISSAOEMPREGADO;
            this.dateTimePickerDemissaoEmpregado = DATETIMEPICKERDEMISSAOEMPREGADO;
            this.txtQuemSupervisor = TXTQUEMSUPERVISOR;
            this.txtMotivoSaida = TXTMOTIVOSAIDA;
            this.txtREEmpregado = TXTREEMPREGADO;
            this.txtTreinamentoInforme = TXTREINAMENTOINFORME;
            this.txtRedacao = TXTREDACAO;
            


        }

        private int ID_PESSOA_EXEMPREGADO;
        public int Id_PessoasExEmpregado
        {
            get
            {
                return this.ID_PESSOA_EXEMPREGADO;

            }
            set
            {
                this.ID_PESSOA_EXEMPREGADO = value;
            }
        }
        private int RADIOBUTTONJTEMSS;
        public int radioButtonJTEMSS
        {
            get
            {
                return this.RADIOBUTTONJTEMSS;

            }
            set
            {
                this.RADIOBUTTONJTEMSS = value;
            }
        }
        private string TXTNOMEEMPREGADO;
        public string txtNomeEmpregado
        {
            get
            {
                return this.TXTNOMEEMPREGADO;

            }
            set
            {
                this.TXTNOMEEMPREGADO = value;
            }
        }
        private String TXTQUALPOSTO;
        public string txtQualPosto
        {
            get
            {
                return this.TXTQUALPOSTO;

            }
            set
            {
                this.TXTQUALPOSTO = value;
            }
        }
        private string DATETIMEPICKERADMISSAOEMPREGADO;
        public string dateTimePickerAdmissaoEmpregado
        {
            get
            {
                return this.DATETIMEPICKERADMISSAOEMPREGADO;

            }
            set
            {
                this.DATETIMEPICKERADMISSAOEMPREGADO = value;
            }
        }
        private string DATETIMEPICKERDEMISSAOEMPREGADO;
        public string dateTimePickerDemissaoEmpregado
        {
            get
            {
                return this.DATETIMEPICKERDEMISSAOEMPREGADO;

            }
            set
            {
                this.DATETIMEPICKERDEMISSAOEMPREGADO = value;
            }
        }

        private string TXTQUEMSUPERVISOR;
        public string txtQuemSupervisor
        {
            get
            {
                return this.TXTQUEMSUPERVISOR;

            }
            set
            {
                this.TXTQUEMSUPERVISOR = value;
            }
        }
        private string TXTMOTIVOSAIDA;
        public string txtMotivoSaida
        {
            get
            {
                return this.TXTMOTIVOSAIDA;

            }
            set
            {
                this.TXTMOTIVOSAIDA = value;
            }
        }
        private string TXTREEMPREGADO;
        public string txtREEmpregado
        {
            get
            {
                return this.TXTREEMPREGADO;

            }
            set
            {
                this.TXTREEMPREGADO = value;
            }
        }
        private string TXTREINAMENTOINFORME;
        public string txtTreinamentoInforme
        {
            get
            {
                return this.TXTREINAMENTOINFORME;

            }
            set
            {
                this.TXTREINAMENTOINFORME = value;
            }
        }
        private string TXTREDACAO;
        public string txtRedacao
        {
            get
            {
                return this.TXTREDACAO;

            }
            set
            {
                this.TXTREDACAO = value;
            }
        }
    }
}
