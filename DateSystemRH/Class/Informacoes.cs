using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystemRH
{
    class Informacoes
    {
        public Informacoes()
        {
            this.Id_PessoasInformacoes = 0;
            this.checkBoxCMA = 0;
            this.checkBoxCMB = 0;
            this.checkBoxCMC = 0;
            this.checkBoxCMD = 0;
            this.txtNumeroCarteiraMotorista = "";
            this.dateTimePickerDataValidadeCMotorista = "";
            this.radioButtonFATISN = 0;
            this.txtDrogasIlicitas = "";
            this.radioButtonFATMS = 0;
            this.txtTratamentoMedico = "";
            this.radioButtonPNSN = 0;
            this.radioButtonPESN = 0;
            this.radioButtonERSN = 0;
            this.radioButtonTBSN = 0;
            this.radioButtonConheceAlguemSN = 0;
            this.radioButtonParenteSN = 0;
            this.txtNomeConhecidoEmpresa = "";
            this.txtCargoConhecidoEmpresa = "";
            this.txtTrabalhoConhecidoEmpresa = "";
            this.checkBoxPlaqueira = 0;
            this.checkBoxIndicacao = 0;
            this.checkBoxEscola = 0;
            this.checkBoxJornal = 0;
            this.checkBoxOutros = 0;
            this.checkBoxConvocado = 0;

        }

        public Informacoes(int ID_PESSOA_INFORMACOES, int CHECKBOXCMA, int CHECKBOXCMB, int CHECKBOXCMC, int CHECKBOXCMD, 
            string TXTNUMEROCARTEIRAMOTORISTA,
            string DATETIMEPICKERDATAVALIDADECMOTORISTA, int RADIOBUTTONFATISN,string TXTDROGASILICITAS,
            string RADIOBUTTONFATMS, string TXTTRATAMENTOMEDICO,int RADIOBUTTONPNSN, int RADIOBUTTONPESN,
            int RADIOBUTTONERSN, int RADIOBUTTONTBSN,int RADIOBUTTONCOCNHECEALGUEMSN,int RADIOBUTTONPARENTESN,
            string TXTNOMECONHECIDOEMPRESA, string TXTCARGOCONHECIDOEMPRESA, string TXTTRABALHOCONHECIDOEMPRESA,
            int CHECKBOXPLAQUEIRA, int CHECKBOXINDICACAO, int CHECKBOXESCOLA, int CHECKBOXJORNAL, int CHECKBOXOUTROS,
            int CHECKBOXCONVOCADO)
        {
            this.Id_PessoasInformacoes = ID_PESSOA_INFORMACOES;
            this.checkBoxCMA = CHECKBOXCMA;
            this.checkBoxCMB = CHECKBOXCMB;
            this.checkBoxCMC = CHECKBOXCMC;
            this.checkBoxCMD = CHECKBOXCMD;
            this.txtNumeroCarteiraMotorista = TXTNUMEROCARTEIRAMOTORISTA;
            this.dateTimePickerDataValidadeCMotorista = DATETIMEPICKERDATAVALIDADECMOTORISTA;
            this.radioButtonFATISN = RADIOBUTTONFATISN;
            this.txtDrogasIlicitas = TXTDROGASILICITAS;
            this.txtDrogasIlicitas = RADIOBUTTONFATMS;
            this.txtTratamentoMedico = TXTTRATAMENTOMEDICO;
            this.radioButtonPNSN = RADIOBUTTONPNSN;
            this.radioButtonPESN = RADIOBUTTONPESN;
            this.radioButtonERSN = RADIOBUTTONERSN;
            this.radioButtonTBSN = RADIOBUTTONTBSN;
            this.radioButtonConheceAlguemSN = RADIOBUTTONCOCNHECEALGUEMSN;
            this.radioButtonParenteSN = RADIOBUTTONPARENTESN;
            this.txtNomeConhecidoEmpresa = TXTNOMECONHECIDOEMPRESA;
            this.txtCargoConhecidoEmpresa = TXTCARGOCONHECIDOEMPRESA;
            this.txtTrabalhoConhecidoEmpresa = TXTTRABALHOCONHECIDOEMPRESA;
            this.checkBoxPlaqueira = CHECKBOXPLAQUEIRA;
            this.checkBoxIndicacao = CHECKBOXINDICACAO;
            this.checkBoxEscola = CHECKBOXESCOLA;
            this.checkBoxJornal = CHECKBOXJORNAL;
            this.checkBoxOutros = CHECKBOXOUTROS;
            this.checkBoxConvocado = CHECKBOXCONVOCADO;
        }

        private int ID_PESSOA_INFORMACOES;
        public int Id_PessoasInformacoes
        {
            get
            {
                return this.ID_PESSOA_INFORMACOES;

            }
            set
            {
                this.ID_PESSOA_INFORMACOES = value;
            }
        }

        private int CHECKBOXCMA;
        public int checkBoxCMA
        {
            get
            {
                return this.CHECKBOXCMA;

            }
            set
            {
                this.CHECKBOXCMA = value;
            }
        }
        private int CHECKBOXCMB;
        public int checkBoxCMB
        {
            get
            {
                return this.CHECKBOXCMB;

            }
            set
            {
                this.CHECKBOXCMB = value;
            }
        }
        private int CHECKBOXCMC;
        public int checkBoxCMC
        {
            get
            {
                return this.CHECKBOXCMC;

            }
            set
            {
                this.CHECKBOXCMC = value;
            }
        }
        private int CHECKBOXCMD;
        public int checkBoxCMD
        {
            get
            {
                return this.CHECKBOXCMD;

            }
            set
            {
                this.CHECKBOXCMD = value;
            }
        }
        private String TXTNUMEROCARTEIRAMOTORISTA;
        public string txtNumeroCarteiraMotorista
        {
            get
            {
                return this.TXTNUMEROCARTEIRAMOTORISTA;

            }
            set
            {
                this.TXTNUMEROCARTEIRAMOTORISTA = value;
            }
        }
        private string DATETIMEPICKERDATAVALIDADECMOTORISTA;
        public string dateTimePickerDataValidadeCMotorista
        {
            get
            {
                return this.DATETIMEPICKERDATAVALIDADECMOTORISTA;

            }
            set
            {
                this.DATETIMEPICKERDATAVALIDADECMOTORISTA = value;
            }
        }
        private int RADIOBUTTONFATISN;
        public int radioButtonFATISN
        {
            get
            {
                return this.RADIOBUTTONFATISN;

            }
            set
            {
                this.RADIOBUTTONFATISN = value;
            }
        }

        private string TXTDROGASILICITAS;
        public string txtDrogasIlicitas
        {
            get
            {
                return this.TXTDROGASILICITAS;

            }
            set
            {
                this.TXTDROGASILICITAS = value;
            }
        }
        private int RADIOBUTTONFATMS;
        public int radioButtonFATMS
        {
            get
            {
                return this.RADIOBUTTONFATMS;

            }
            set
            {
                this.RADIOBUTTONFATMS = value;
            }
        }
        private string TXTTRATAMENTOMEDICO;
        public string txtTratamentoMedico
        {
            get
            {
                return this.TXTTRATAMENTOMEDICO;

            }
            set
            {
                this.TXTTRATAMENTOMEDICO = value;
            }
        }
        private int RADIOBUTTONPNSN;
        public int radioButtonPNSN
        {
            get
            {
                return this.RADIOBUTTONPNSN;

            }
            set
            {
                this.RADIOBUTTONPNSN = value;
            }
        }

        private int RADIOBUTTONPESN;
        public int radioButtonPESN
        {
            get
            {
                return this.RADIOBUTTONPESN;

            }
            set
            {
                this.RADIOBUTTONPESN = value;
            }
        }
        private int RADIOBUTTONERSN;
        public int radioButtonERSN
        {
            get
            {
                return this.RADIOBUTTONERSN;

            }
            set
            {
                this.RADIOBUTTONERSN = value;
            }
        }
        private int RADIOBUTTONTBSN;
        public int radioButtonTBSN
        {
            get
            {
                return this.RADIOBUTTONTBSN;

            }
            set
            {
                this.RADIOBUTTONTBSN = value;
            }
        }
        private int RADIOBUTTONCOCNHECEALGUEMSN;
        public int radioButtonConheceAlguemSN
        {
            get
            {
                return this.RADIOBUTTONCOCNHECEALGUEMSN;

            }
            set
            {
                this.RADIOBUTTONCOCNHECEALGUEMSN = value;
            }
        }
        private int RADIOBUTTONPARENTESN;
        public int radioButtonParenteSN
        {
            get
            {
                return this.RADIOBUTTONPARENTESN;

            }
            set
            {
                this.RADIOBUTTONPARENTESN = value;
            }
        }
        private string TXTNOMECONHECIDOEMPRESA;
        public string txtNomeConhecidoEmpresa
        {
            get
            {
                return this.TXTNOMECONHECIDOEMPRESA;

            }
            set
            {
                this.TXTNOMECONHECIDOEMPRESA = value;
            }
        }
        private string TXTCARGOCONHECIDOEMPRESA;
        public string txtCargoConhecidoEmpresa
        {
            get
            {
                return this.TXTCARGOCONHECIDOEMPRESA;

            }
            set
            {
                this.TXTCARGOCONHECIDOEMPRESA = value;
            }
        }
        private string TXTTRABALHOCONHECIDOEMPRESA;
        public string txtTrabalhoConhecidoEmpresa
        {
            get
            {
                return this.TXTTRABALHOCONHECIDOEMPRESA;

            }
            set
            {
                this.TXTTRABALHOCONHECIDOEMPRESA = value;
            }
        }
        private int CHECKBOXPLAQUEIRA;
        public int checkBoxPlaqueira
        {
            get
            {
                return this.CHECKBOXPLAQUEIRA;

            }
            set
            {
                this.CHECKBOXPLAQUEIRA = value;
            }
        }
        private int CHECKBOXINDICACAO;
        public int checkBoxIndicacao
        {
            get
            {
                return this.CHECKBOXINDICACAO;

            }
            set
            {
                this.CHECKBOXINDICACAO = value;
            }
        }
        private int CHECKBOXESCOLA;
        public int checkBoxEscola
        {
            get
            {
                return this.CHECKBOXESCOLA;

            }
            set
            {
                this.CHECKBOXESCOLA = value;
            }
        }
        private int CHECKBOXJORNAL;
        public int checkBoxJornal
        {
            get
            {
                return this.CHECKBOXJORNAL;

            }
            set
            {
                this.CHECKBOXJORNAL = value;
            }
        }

        private int CHECKBOXOUTROS;
        public int checkBoxOutros
        {
            get
            {
                return this.CHECKBOXOUTROS;

            }
            set
            {
                this.CHECKBOXOUTROS = value;
            }
        }
        private int CHECKBOXCONVOCADO;
        public int checkBoxConvocado
        {
            get
            {
                return this.CHECKBOXCONVOCADO;

            }
            set
            {
                this.CHECKBOXCONVOCADO = value;
            }
        }
    }
}
