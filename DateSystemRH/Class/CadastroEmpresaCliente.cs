using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystemRH
{
    class CadastroEmpresaCliente
    {
        public CadastroEmpresaCliente()
        {
            this.IdCadastroEmpresaCliente = 0;
            this.NomeEmpresa = "";
            this.Endereco = "";
            this.StatusAtivo = 0;
            this.Ms = "";
            this.Comentario = "";
        }

        public CadastroEmpresaCliente(int ID_CADASTRO_EMPRESA_CLIENTE, string NOME_EMPRESA, string ENDERECO, string MS,
            int STATUS_ATIVO, string COMENTARIO)
        {

            this.IdCadastroEmpresaCliente = ID_CADASTRO_EMPRESA_CLIENTE;
            this.NomeEmpresa = NOME_EMPRESA;
            this.Endereco = ENDERECO;
            this.StatusAtivo = STATUS_ATIVO;
            this.Ms = MS;
            this.Comentario = COMENTARIO;
        }

        private int ID_CADASTRO_EMPRESA_CLIENTE;
        public int IdCadastroEmpresaCliente
        {
            get
            {
                return this.ID_CADASTRO_EMPRESA_CLIENTE;

            }
            set
            {
                this.ID_CADASTRO_EMPRESA_CLIENTE = value;
            }
        }

        private string NOME_EMPRESA;
        public string NomeEmpresa
        {
            get
            {
                return this.NOME_EMPRESA;

            }
            set
            {
                this.NOME_EMPRESA = value;
            }
        }
        private string ENDERECO;
        public string Endereco
        {
            get
            {
                return this.ENDERECO;

            }
            set
            {
                this.ENDERECO = value;
            }
        }
        private string MS;
        public string Ms
        {
            get
            {
                return this.MS;

            }
            set
            {
                this.MS = value;
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
        private string COMENTARIO;
        public string Comentario
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
    }
}
