using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystemRH
{
    class Profissional2
    {
        public Profissional2()
        {
            this.Id_PessoaProfissional2 = 0;
            this.txtUltimoEmprego = "";
            this.txtUltimoCargo = "";
            this.txtUltimoSalario = "";
            this.dateTimePickerUltimaEntrada = "";
            this.dateTimePickerUltimaSaida = "";
            this.txtNomeUltimoChefe = "";
            this.maskedtxtTelefoneUltimoEmprego = "";
            this.txtMotivoSaidaUltimoEmprego = "";
            this.txtPenultimoEmprego = "";
            this.txtPenultimoCargo = "";
            this.txtPenultimoSalario = "";
            this.dateTimePickerPenultimaEntrada = "";
            this.dateTimePickerPenultimaSaida = "";
            this.txtNomePenultimoChefe = "";
            this.maskedtxtTelefonePenultimoEmprego = "";
            this.txtMotivoSaidaPenultimoEmprego = "";
            this.txtAntepenultimoEmprego = "";
            this.txtAntepenultimoCargo = "";
            this.txtAntepenultimoSalario = "";
            this.dateTimePickerAntepenultimoEntrada = "";
            this.dateTimePickerAntepenultimoSaida = "";
            this.txtNomeAntepenultimoChefe = "";
            this.maskedtxtTelefoneAntepenultimoEmprego = "";
            this.txtMotivoSaidaAntepenultimoEmprego = "";
            this.txtRecutamentoSelecao = "";

        }

        public Profissional2(int ID_PESSOA_PROFISSIONA2, string TXTULTIMOEMPREGO, string TXTULTIMOCARGO, string TXTULTIMOSALARIO,
            String DATETIMEPICKERULTIMAENTRADA, string DATETIMEPICKERULTIMASAIDA, string TXTNOMEULTIMOCHEFE, string MASKEDTELEFONEULTIMOEMPREGO,
            string TXTMOTIVOSAIDAULTIMOEMPREGO, string TXTPENULTIMOEMPREGO, string TXTPENULTIMOCARGO, string TXTPENULTIMOSALARIO
            , string DATETIMEPICKERPENULTIMAENTRADA, string DATETIMEPICKERPENULTIMASAIDA, string TXTNOMEPENULTIMOCHEFE,
            string MASKEDTELEFONEPENULTIMOEMPREGO, string TXTMOTIVOSAIDAPERNULTIMOEMPREGO, string TXTANTEPENULTIMOEMPREGO, 
            string TXTANTEPENULTIMOCARGO, string TXTANTEPENULTIMOSALARIO, string DATETIMEPICKERANTEPENULTIMOENTRADA, 
            string DATETIMEPICKERANTEPENULTIMOSAIDA,string TXTNOMEANTEPENULTIMOCHEFE, string MASKEDTELEFONEANTEPENULTIMOEMPREGO, 
            string TXTMOTIVOSAIDAANTEPENULTIMOEMPREGO,string TXTRECRUTAMENTOSELECAO)
        {

            this.Id_PessoaProfissional2 = ID_PESSOA_PROFISSIONA2;
            this.txtUltimoEmprego = TXTULTIMOEMPREGO;
            this.txtUltimoCargo = TXTULTIMOCARGO;
            this.txtUltimoSalario = TXTULTIMOSALARIO;
            this.dateTimePickerUltimaEntrada = DATETIMEPICKERULTIMAENTRADA;
            this.dateTimePickerUltimaSaida = DATETIMEPICKERULTIMASAIDA;
            this.txtNomeUltimoChefe = TXTNOMEULTIMOCHEFE;
            this.maskedtxtTelefoneUltimoEmprego = MASKEDTELEFONEULTIMOEMPREGO;
            this.txtMotivoSaidaUltimoEmprego = TXTMOTIVOSAIDAULTIMOEMPREGO;
            this.txtPenultimoEmprego = TXTPENULTIMOEMPREGO;
            this.txtPenultimoCargo = TXTPENULTIMOCARGO;
            this.txtPenultimoSalario = TXTPENULTIMOSALARIO;
            this.dateTimePickerPenultimaEntrada = DATETIMEPICKERPENULTIMAENTRADA;
            this.dateTimePickerPenultimaEntrada = DATETIMEPICKERPENULTIMASAIDA;
            this.txtNomePenultimoChefe = TXTNOMEPENULTIMOCHEFE;
            this.maskedtxtTelefonePenultimoEmprego = MASKEDTELEFONEPENULTIMOEMPREGO;
            this.txtMotivoSaidaPenultimoEmprego = TXTMOTIVOSAIDAPERNULTIMOEMPREGO;
            this.txtAntepenultimoEmprego = TXTANTEPENULTIMOEMPREGO;
            this.txtAntepenultimoCargo = TXTANTEPENULTIMOCARGO;
            this.txtAntepenultimoSalario = TXTANTEPENULTIMOSALARIO;
            this.dateTimePickerAntepenultimoEntrada = DATETIMEPICKERANTEPENULTIMOENTRADA;
            this.dateTimePickerAntepenultimoSaida = DATETIMEPICKERANTEPENULTIMOSAIDA;
            this.txtNomeAntepenultimoChefe = TXTNOMEANTEPENULTIMOCHEFE;
            this.maskedtxtTelefoneAntepenultimoEmprego = MASKEDTELEFONEANTEPENULTIMOEMPREGO;
            this.txtMotivoSaidaAntepenultimoEmprego = TXTMOTIVOSAIDAANTEPENULTIMOEMPREGO;
            this.txtRecutamentoSelecao = TXTRECRUTAMENTOSELECAO;


        }

        private int ID_PESSOA_PROFISSIONA2;
        public int Id_PessoaProfissional2
        {
            get
            {
                return this.ID_PESSOA_PROFISSIONA2;

            }
            set
            {
                this.ID_PESSOA_PROFISSIONA2 = value;
            }
        }

        private String TXTULTIMOEMPREGO;
        public String txtUltimoEmprego
        {
            get
            {
                return this.TXTULTIMOEMPREGO;

            }
            set
            {
                this.TXTULTIMOEMPREGO = value;
            }
        }
        private String TXTULTIMOCARGO;
        public String txtUltimoCargo
        {
            get
            {
                return this.TXTULTIMOCARGO;

            }
            set
            {
                this.TXTULTIMOCARGO = value;
            }
        }
        private String TXTULTIMOSALARIO;
        public String txtUltimoSalario
        {
            get
            {
                return this.TXTULTIMOSALARIO;

            }
            set
            {
                this.TXTULTIMOSALARIO = value;
            }
        }
        private string DATETIMEPICKERULTIMAENTRADA;
        public string dateTimePickerUltimaEntrada
        {
            get
            {
                return this.DATETIMEPICKERULTIMAENTRADA;

            }
            set
            {
                this.DATETIMEPICKERULTIMAENTRADA = value;
            }
        }
        private string DATETIMEPICKERULTIMASAIDA;
        public string dateTimePickerUltimaSaida
        {
            get
            {
                return this.DATETIMEPICKERULTIMASAIDA;

            }
            set
            {
                this.DATETIMEPICKERULTIMASAIDA = value;
            }
        }

        private string TXTNOMEULTIMOCHEFE;
        public string txtNomeUltimoChefe
        {
            get
            {
                return this.TXTNOMEULTIMOCHEFE;

            }
            set
            {
                this.TXTNOMEULTIMOCHEFE = value;
            }
        }
        private string MASKEDTELEFONEULTIMOEMPREGO;
        public string maskedtxtTelefoneUltimoEmprego
        {
            get
            {
                return this.MASKEDTELEFONEULTIMOEMPREGO;

            }
            set
            {
                this.MASKEDTELEFONEULTIMOEMPREGO = value;
            }
        }
        private string TXTMOTIVOSAIDAULTIMOEMPREGO;
        public string txtMotivoSaidaUltimoEmprego
        {
            get
            {
                return this.TXTMOTIVOSAIDAULTIMOEMPREGO;

            }
            set
            {
                this.TXTMOTIVOSAIDAULTIMOEMPREGO = value;
            }
        }
        private String TXTPENULTIMOEMPREGO;
        public String txtPenultimoEmprego
        {
            get
            {
                return this.TXTPENULTIMOEMPREGO;

            }
            set
            {
                this.TXTPENULTIMOEMPREGO = value;
            }
        }
        private String TXTPENULTIMOCARGO;
        public String txtPenultimoCargo
        {
            get
            {
                return this.TXTPENULTIMOCARGO;

            }
            set
            {
                this.TXTPENULTIMOCARGO = value;
            }
        }
        private String TXTPENULTIMOSALARIO;
        public String txtPenultimoSalario
        {
            get
            {
                return this.TXTPENULTIMOSALARIO;

            }
            set
            {
                this.TXTPENULTIMOSALARIO = value;
            }
        }
        private string DATETIMEPICKERPENULTIMAENTRADA;
        public string dateTimePickerPenultimaEntrada
        {
            get
            {
                return this.DATETIMEPICKERPENULTIMAENTRADA;

            }
            set
            {
                this.DATETIMEPICKERPENULTIMAENTRADA = value;
            }
        }
        private string DATETIMEPICKERPENULTIMASAIDA;
        public string dateTimePickerPenultimaSaida
        {
            get
            {
                return this.DATETIMEPICKERPENULTIMASAIDA;

            }
            set
            {
                this.DATETIMEPICKERPENULTIMASAIDA = value;
            }
        }

        private string TXTNOMEPENULTIMOCHEFE;
        public string txtNomePenultimoChefe
        {
            get
            {
                return this.TXTNOMEPENULTIMOCHEFE;

            }
            set
            {
                this.TXTNOMEPENULTIMOCHEFE = value;
            }
        }
        private string MASKEDTELEFONEPENULTIMOEMPREGO;
        public string maskedtxtTelefonePenultimoEmprego
        {
            get
            {
                return this.MASKEDTELEFONEPENULTIMOEMPREGO;

            }
            set
            {
                this.MASKEDTELEFONEPENULTIMOEMPREGO = value;
            }
        }
        private string TXTMOTIVOSAIDAPERNULTIMOEMPREGO;
        public string txtMotivoSaidaPenultimoEmprego
        {
            get
            {
                return this.TXTMOTIVOSAIDAPERNULTIMOEMPREGO;

            }
            set
            {
                this.TXTMOTIVOSAIDAPERNULTIMOEMPREGO = value;
            }
        }
        private String TXTANTEPENULTIMOEMPREGO;
        public String txtAntepenultimoEmprego
        {
            get
            {
                return this.TXTANTEPENULTIMOEMPREGO;

            }
            set
            {
                this.TXTANTEPENULTIMOEMPREGO = value;
            }
        }
        private String TXTANTEPENULTIMOCARGO;
        public String txtAntepenultimoCargo
        {
            get
            {
                return this.TXTANTEPENULTIMOCARGO;

            }
            set
            {
                this.TXTANTEPENULTIMOCARGO = value;
            }
        }
        private String TXTANTEPENULTIMOSALARIO;
        public String txtAntepenultimoSalario
        {
            get
            {
                return this.TXTANTEPENULTIMOSALARIO;

            }
            set
            {
                this.TXTANTEPENULTIMOSALARIO = value;
            }
        }
        private string DATETIMEPICKERANTEPENULTIMOENTRADA;
        public string dateTimePickerAntepenultimoEntrada
        {
            get
            {
                return this.DATETIMEPICKERANTEPENULTIMOENTRADA;

            }
            set
            {
                this.DATETIMEPICKERANTEPENULTIMOENTRADA = value;
            }
        }
        private string DATETIMEPICKERANTEPENULTIMOSAIDA;
        public string dateTimePickerAntepenultimoSaida
        {
            get
            {
                return this.DATETIMEPICKERANTEPENULTIMOSAIDA;

            }
            set
            {
                this.DATETIMEPICKERANTEPENULTIMOSAIDA = value;
            }
        }

        private string TXTNOMEANTEPENULTIMOCHEFE;
        public string txtNomeAntepenultimoChefe
        {
            get
            {
                return this.TXTNOMEANTEPENULTIMOCHEFE;

            }
            set
            {
                this.TXTNOMEANTEPENULTIMOCHEFE = value;
            }
        }
        private string MASKEDTELEFONEANTEPENULTIMOEMPREGO;
        public string maskedtxtTelefoneAntepenultimoEmprego
        {
            get
            {
                return this.MASKEDTELEFONEANTEPENULTIMOEMPREGO;

            }
            set
            {
                this.MASKEDTELEFONEANTEPENULTIMOEMPREGO = value;
            }
        }
        private string TXTMOTIVOSAIDAANTEPENULTIMOEMPREGO;
        public string txtMotivoSaidaAntepenultimoEmprego
        {
            get
            {
                return this.TXTMOTIVOSAIDAANTEPENULTIMOEMPREGO;

            }
            set
            {
                this.TXTMOTIVOSAIDAANTEPENULTIMOEMPREGO = value;
            }
        }
        private string TXTRECRUTAMENTOSELECAO;
        public string txtRecutamentoSelecao
        {
            get
            {
                return this.TXTRECRUTAMENTOSELECAO;

            }
            set
            {
                this.TXTRECRUTAMENTOSELECAO = value;
            }
        }
    }
}
