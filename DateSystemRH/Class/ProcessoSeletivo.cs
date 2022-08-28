using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystemRH
{
    class ProcessoSeletivo
    {
        public ProcessoSeletivo()
        {
            this.IdProcessoSeletivo = 0;
            this.IdEmpresa = 0;
            this.IdProfissaoProcessoSeletivo = 0;
            this.checkBoxStatusAtivo = 0;
            this.checkBoxStatusFinalizacao = 0;
            this.dateTimePickerDataCriacao = "";
            this.dateTimePickerDataFechamento = "";
            this.txtComentatario = "";
            this.txtQuantVagas = "";
            this.IdPessoaLogada = 0;
            this.Id_PessoaLogadaAlterada = 0;
        }

        public ProcessoSeletivo(int ID_PESSOA_PROCESSO_SELETIVO, int ID_EMPRESA, int ID_PROFISSAO_PROCESSO_SELETIVO, int CHECKBOXSTATUS_ATIVO,
            int CHECKBOXSTATUS_FINALIZACAO, string DATA_CRIACAO, string DATA_FECHAMENTO, string COMENTARIO, string QUANT_VAGAS,
            int ID_PESSOA_LOGADA, int ID_PESSOA_LOGADA_ALTERADA)
        {
            this.IdProcessoSeletivo = ID_PESSOA_PROCESSO_SELETIVO;
            this.IdEmpresa = ID_EMPRESA;
            this.IdProfissaoProcessoSeletivo = ID_PROFISSAO_PROCESSO_SELETIVO;
            this.checkBoxStatusAtivo = CHECKBOXSTATUS_ATIVO;
            this.checkBoxStatusFinalizacao = CHECKBOXSTATUS_FINALIZACAO;
            this.dateTimePickerDataCriacao = DATA_CRIACAO;
            this.dateTimePickerDataFechamento = DATA_FECHAMENTO;
            this.txtComentatario = COMENTARIO;
            this.txtQuantVagas = QUANT_VAGAS;
            this.IdPessoaLogada = ID_PESSOA_LOGADA;
            this.Id_PessoaLogadaAlterada = ID_PESSOA_LOGADA;

        }

        private int ID_PESSOA_PROCESSO_SELETIVO;
        public int IdProcessoSeletivo
        {
            get
            {
                return this.ID_PESSOA_PROCESSO_SELETIVO;

            }
            set
            {
                this.ID_PESSOA_PROCESSO_SELETIVO = value;
            }
        }
        private int ID_EMPRESA; 
        public int IdEmpresa
        {
            get
            {
                return this.ID_EMPRESA;

            }
            set
            {
                this.ID_EMPRESA = value;
            }
        }
        private int ID_PROFISSAO_PROCESSO_SELETIVO;
        public int IdProfissaoProcessoSeletivo
        {
            get
            {
                return this.ID_PROFISSAO_PROCESSO_SELETIVO;

            }
            set
            {
                this.ID_PROFISSAO_PROCESSO_SELETIVO = value;
            }
        }
        private int CHECKBOXSTATUS_ATIVO;
        public int checkBoxStatusAtivo
        {
            get
            {
                return this.CHECKBOXSTATUS_ATIVO;

            }
            set
            {
                this.CHECKBOXSTATUS_ATIVO = value;
            }
        }
        private int CHECKBOXSTATUS_FINALIZACAO;
        public int checkBoxStatusFinalizacao
        {
            get
            {
                return this.CHECKBOXSTATUS_FINALIZACAO;

            }
            set
            {
                this.CHECKBOXSTATUS_FINALIZACAO = value;
            }
        }
        
        private String DATA_CRIACAO;
        public string dateTimePickerDataCriacao
        {
            get
            {
                return this.DATA_CRIACAO;

            }
            set
            {
                this.DATA_CRIACAO = value;
            }
        }

        private string DATA_FECHAMENTO;
        public string dateTimePickerDataFechamento
        {
            get
            {
                return this.DATA_FECHAMENTO;

            }
            set
            {
                this.DATA_FECHAMENTO = value;
            }
        }

        private string COMENTARIO;
        public string txtComentatario
        {
            get
            {
                return this.COMENTARIO;

            }
            set
            {
                this.COMENTARIO = value;
            }
        }
        private string QUANT_VAGAS;
        public string txtQuantVagas
        {
            get
            {
                return this.QUANT_VAGAS;

            }
            set
            {
                this.QUANT_VAGAS = value;
            }
        }
        private int ID_PESSOA_LOGADA;
        public int IdPessoaLogada
        {
            get
            {
                return this.ID_PESSOA_LOGADA;

            }
            set
            {
                this.ID_PESSOA_LOGADA = value;
            }
        }
        private int ID_PESSOA_LOGADA_ALTERADA;
        public int Id_PessoaLogadaAlterada
        {
            get
            {
                return this.ID_PESSOA_LOGADA_ALTERADA;

            }
            set
            {
                this.ID_PESSOA_LOGADA_ALTERADA = value;
            }
        }
    }
}
