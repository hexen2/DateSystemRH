using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystemRH
{
    class CadastroLoginNovo
    {
        public CadastroLoginNovo()
        {
            //PERMISSAO USUARIO
            this.IdCadastroLoginNovo = 0;
            this.NOME = "";
            this.USUARIO = "";
            this.SENHA = "";
            this.CONFIRMASENHA = "";
            this.OBSERVACACAO = "";
            this.SITUACAO = 0;
            this.USUARIOACESSSO = 0;
            this.ID_ACESSO_BASE_DADOS = 0;

            this.USUARIOCRIAR = 0;
            this.USUARIOALTERAR = 0;
            this.USUARIOEXCLUIR = 0;
            this.USUARIOPESQUISA = 0;
            this.USUARIOVISUALIZAR = 0;
            //PERMISSA EMPRESA
            this.CadastraEmpresa = 0;
            this.PesquisaEmpresa = 0;
            this.VisualizarEmpresa = 0;
            this.EditarEmpresa = 0;
            this.ExcluirEmpresa = 0;

            //PERMISSAO FICHA
            this.CadastraFicha = 0;
            this.PesquisaFicha = 0;
            this.VisualizarFicha = 0;
            this.EditarFicha = 0;
            this.ExcluirFicha = 0;
            //PERMISSA PROCESSO SELEÇÃO
            this.CadastraProcessoSelecao = 0;
            this.PesquisaProcessoSelecao = 0;
            this.VisualizarProcessoSelecao = 0;
            this.EditarProcessoSelecao = 0;
            this.ExcluirProcessoSelecao = 0;
            //PERMISSAO NIVEIS
            this.PermissaoBasedados = 0;
            this.PermissaoNivelaAcesso = 0;
            this.PermissaoFuncionarioRh = 0;
            this.PermissaoUsuarioAcesso = 0;
            //CRIAR CONTAS
            this.CriarCadastroUsuario = 0;
            this.CriarFuncionarioRh = 0;
            this.CriarUsuarioAcesso = 0;
            this.AcessoCadastroUsuario = 0;
            this.CriarUsuarioBaseDados = 0;
            this.CriarNivelAcesso = 0;

            //ATUALIZACAO TELA PRINCIPAL
            this.AtualicazaoTelaPrincipal = 0;

        }
        public CadastroLoginNovo(int IDCADASTROLOGINNOVO, string NOME, string ABREVIACAO, string USUARIO, string SENHA, string CONFIRMACAOSENHA, string OBSERVACAO, int SITUACAO, int USUARIOACESSO, int ID_ACESSO_BASE_DADOS,
            int USUARIOCRIAR, int USUARIOALTERAR, int USUARIOEXCLUIR, int USUARIOPESQUISA, int USUARIOVISUALIZAR,

            int CADASTRAEMPRESA, int PESQUISAEMPRESA, int VISUALIZAREMPRESA, int EDITAREMPRESA, int EXCLUIREMPRESA,
            int CLIENTECCADASTRA, int CLIENTECPESQUISA, int CLIENTECVISUALIZAR, int CLIENTECEDITAR, int CLIENTECEXCLUIR,
            int CADASTRAFICHA, int PESQUISAFICHA, int VISUALIZARFICHA, int EDITARFICHA, int EXCLUIRFICHA,
            int CADASTRAPROCESSOSELECAO, int PESQUISAPROCESSOSELECAO, int VISUALIZARPROCESSOSELECAO, int EDITARPROCESSOSELECAO, int EXCLUIRPROCESSOSELECAO,
            int PERMISSAOBASEDADOS, int PERMISSAONIVELACESSO, int PERMISSAOFUNCIONARIORH,int PERMISSAOUSUARIOACESSO, int CRIARCADASTROUSUARIO, int CRIARFUNCIONARIORH, 
            int CRIARUSUARIOACESSO,int ACESSOCADASTROUSUARIO, int CRIARUSUARIOBASEDADOS,int CRIARNIVELACESSO,
            int ATUALIZACAOTELAPRINCIPAL)
        {
            //PERMISSAO USUARIO
            IdCadastroLoginNovo = IDCADASTROLOGINNOVO;
            Nome = NOME;
            Senha = SENHA;
            ConfirmaSenha = CONFIRMACAOSENHA;
            Observacao = OBSERVACACAO;
            Situacao = SITUACAO;
            UsuarioAcesso = USUARIOACESSO;
            IdAcessoBaseDados = ID_ACESSO_BASE_DADOS;

            UsuarioCriar = USUARIOCRIAR;
            UsuarioAlterar = USUARIOALTERAR;
            UsuarioExcluir = USUARIOEXCLUIR;
            UsuarioPesquisa = USUARIOPESQUISA;
            UsuarioVisualizar = USUARIOVISUALIZAR;

            //PERMISSA EMPRESA
            CadastraEmpresa = CADASTRAEMPRESA;
            PesquisaEmpresa = PESQUISAEMPRESA;
            VisualizarEmpresa = VISUALIZAREMPRESA;
            EditarEmpresa = EDITAREMPRESA;
            ExcluirEmpresa = EXCLUIREMPRESA;
            //PERMISSAO FICHA
            CadastraFicha = CADASTRAFICHA;
            PesquisaFicha = PESQUISAFICHA;
            VisualizarFicha = VISUALIZARFICHA;
            EditarFicha = EDITARFICHA;
            ExcluirFicha = EXCLUIRFICHA;
            //PERMISSA PROCESSO SELECAO
            CadastraProcessoSelecao = CADASTRAPROCESSOSELECAO;
            PesquisaProcessoSelecao = PESQUISAPROCESSOSELECAO;
            VisualizarProcessoSelecao = VISUALIZARPROCESSOSELECAO;
            EditarProcessoSelecao = EDITARPROCESSOSELECAO;
            ExcluirProcessoSelecao = EXCLUIRPROCESSOSELECAO;
            //PERMISSAO NIVEIS
            PermissaoBasedados = PERMISSAOBASEDADOS;
            PermissaoNivelaAcesso = PERMISSAONIVELACESSO;
            PermissaoFuncionarioRh = PERMISSAOFUNCIONARIORH;
            PermissaoUsuarioAcesso = PERMISSAOUSUARIOACESSO;         
            //CRIAR CONTAS
            this.CriarCadastroUsuario = CRIARCADASTROUSUARIO;
            this.CriarFuncionarioRh = CRIARFUNCIONARIORH;
            this.CriarUsuarioAcesso = CRIARUSUARIOACESSO;
            this.AcessoCadastroUsuario = ACESSOCADASTROUSUARIO;
            this.CriarUsuarioBaseDados = CRIARUSUARIOBASEDADOS;
            this.CriarNivelAcesso = CRIARNIVELACESSO;

            //ATUALIZACAO TELA PRINCIPAL
            this.AtualicazaoTelaPrincipal = ATUALIZACAOTELAPRINCIPAL;

        }
        private int IDCADASTROLOGINNOVO;
        public int IdCadastroLoginNovo
        {
            get
            {
                return this.IDCADASTROLOGINNOVO;

            }
            set
            {
                this.IDCADASTROLOGINNOVO = value;
            }
        }
        private string NOME;
        public string Nome
        {
            get
            {
                return this.NOME;

            }
            set
            {
                this.NOME = value;
            }
        }
        private string USUARIO;
        public string Usuario
        {
            get
            {
                return this.USUARIO;

            }
            set
            {
                this.USUARIO = value;
            }
        }
        private string SENHA;
        public string Senha
        {
            get
            {
                return this.SENHA;

            }
            set
            {
                this.SENHA = value;
            }
        }
        private string CONFIRMASENHA;
        public string ConfirmaSenha
        {
            get
            {
                return this.CONFIRMASENHA;

            }
            set
            {
                this.CONFIRMASENHA = value;
            }
        }
        private string OBSERVACACAO;
        public string Observacao
        {
            get
            {
                return this.OBSERVACACAO;

            }
            set
            {
                this.OBSERVACACAO = value;
            }
        }
        private int SITUACAO;
        public int Situacao
        {
            get
            {
                return this.SITUACAO;

            }
            set
            {
                this.SITUACAO = value;
            }
        }
        private int USUARIOACESSSO;
        public int UsuarioAcesso
        {
            get
            {
                return this.USUARIOACESSSO;

            }
            set
            {
                this.USUARIOACESSSO = value;
            }
        }
        private int ID_ACESSO_BASE_DADOS;
        public int IdAcessoBaseDados
        {
            get
            {
                return this.ID_ACESSO_BASE_DADOS;

            }
            set
            {
                this.ID_ACESSO_BASE_DADOS = value;
            }
        }
        //PERMISSAO DO USUARIO----------------------------------------------------------------------------
        private int USUARIOCRIAR;
        public int UsuarioCriar
        {
            get
            {
                return this.USUARIOCRIAR;

            }
            set
            {
                this.USUARIOCRIAR = value;
            }
        }
        private int USUARIOALTERAR;
        public int UsuarioAlterar
        {
            get
            {
                return this.USUARIOALTERAR;

            }
            set
            {
                this.USUARIOALTERAR = value;
            }
        }
        private int USUARIOEXCLUIR;
        public int UsuarioExcluir
        {
            get
            {
                return this.USUARIOEXCLUIR;

            }
            set
            {
                this.USUARIOEXCLUIR = value;
            }
        }
        private int USUARIOPESQUISA;
        public int UsuarioPesquisa
        {
            get
            {
                return this.USUARIOPESQUISA;

            }
            set
            {
                this.USUARIOPESQUISA = value;
            }
        }
        private int USUARIOVISUALIZAR;
        public int UsuarioVisualizar
        {
            get
            {
                return this.USUARIOVISUALIZAR;

            }
            set
            {
                this.USUARIOVISUALIZAR = value;
            }
        }
        // PERMISSA EMPRESA---------------------------------------------
        private int CADASTRAEMPRESA;
        public int CadastraEmpresa
        {
            get
            {
                return this.CADASTRAEMPRESA;

            }
            set
            {
                this.CADASTRAEMPRESA = value;
            }
        }
        private int PESQUISAEMPRESA;
        public int PesquisaEmpresa
        {
            get
            {
                return this.PESQUISAEMPRESA;

            }
            set
            {
                this.PESQUISAEMPRESA = value;
            }
        }
        private int VISUALIZAREMPRESA;
        public int VisualizarEmpresa
        {
            get
            {
                return this.VISUALIZAREMPRESA;

            }
            set
            {
                this.VISUALIZAREMPRESA = value;
            }
        }
        private int EDITAREMPRESA;
        public int EditarEmpresa
        {
            get
            {
                return this.EDITAREMPRESA;

            }
            set
            {
                this.EDITAREMPRESA = value;
            }
        }
        private int EXCLUIREMPRESA;
        public int ExcluirEmpresa
        {
            get
            {
                return this.EXCLUIREMPRESA;

            }
            set
            {
                this.EXCLUIREMPRESA = value;
            }
        }
       //PERMISSAO FICHA
        private int CADASTRAFICHA;
        public int CadastraFicha
        {
            get
            {
                return this.CADASTRAFICHA;

            }
            set
            {
                this.CADASTRAFICHA = value;
            }
        }
        private int PESQUISAFICHA;
        public int PesquisaFicha
        {
            get
            {
                return this.PESQUISAFICHA;

            }
            set
            {
                this.PESQUISAFICHA = value;
            }
        }
        private int VISUALIZARFICHA;
        public int VisualizarFicha
        {
            get
            {
                return this.VISUALIZARFICHA;

            }
            set
            {
                this.VISUALIZARFICHA = value;
            }
        }
        private int EDITARFICHA;
        public int EditarFicha
        {
            get
            {
                return this.EDITARFICHA;

            }
            set
            {
                this.EDITARFICHA = value;
            }
        }
        private int EXCLUIRFICHA;
        public int ExcluirFicha
        {
            get
            {
                return this.EXCLUIRFICHA;

            }
            set
            {
                this.EXCLUIRFICHA = value;
            }
        }
        //PERMISSA PROCESSO SELEÇÃO
        private int CADASTRAPROCESSOSELECAO;
        public int CadastraProcessoSelecao
        {
            get
            {
                return this.CADASTRAPROCESSOSELECAO;

            }
            set
            {
                this.CADASTRAPROCESSOSELECAO = value;
            }
        }
        private int PESQUISAPROCESSOSELECAO;
        public int PesquisaProcessoSelecao
        {
            get
            {
                return this.PESQUISAPROCESSOSELECAO;

            }
            set
            {
                this.PESQUISAPROCESSOSELECAO = value;
            }
        }
        private int VISUALIZARPROCESSOSELECAO;
        public int VisualizarProcessoSelecao
        {
            get
            {
                return this.VISUALIZARPROCESSOSELECAO;

            }
            set
            {
                this.VISUALIZARPROCESSOSELECAO = value;
            }
        }
        private int EDITARPROCESSOSELECAO;
        public int EditarProcessoSelecao
        {
            get
            {
                return this.EDITARPROCESSOSELECAO;

            }
            set
            {
                this.EDITARPROCESSOSELECAO = value;
            }
        }
        private int EXCLUIRPROCESSOSELECAO;
        public int ExcluirProcessoSelecao
        {
            get
            {
                return this.EXCLUIRPROCESSOSELECAO;

            }
            set
            {
                this.EXCLUIRPROCESSOSELECAO = value;
            }
        }
        //PERMISSÃO DE CRIAR CONTAS--------------------------------------------------
        private int CRIARCADASTROUSUARIO;
        public int CriarCadastroUsuario
        {
            get
            {
                return this.CRIARCADASTROUSUARIO;

            }
            set
            {
                this.CRIARCADASTROUSUARIO = value;
            }
        }
        private int CRIARFUNCIONARIORH;
        public int CriarFuncionarioRh
        {
            get
            {
                return this.CRIARFUNCIONARIORH;

            }
            set
            {
                this.CRIARFUNCIONARIORH = value;
            }
        }
        
        private int CRIARUSUARIOACESSO;
        public int CriarUsuarioAcesso
        {
            get
            {
                return this.CRIARUSUARIOACESSO;

            }
            set
            {
                this.CRIARUSUARIOACESSO = value;
            }
        }
        private int CRIARUSUARIOBASEDADOS;
        public int CriarUsuarioBaseDados
        {
            get
            {
                return this.CRIARUSUARIOBASEDADOS;

            }
            set
            {
                this.CRIARUSUARIOBASEDADOS = value;
            }
        }
        private int ACESSOCADASTROUSUARIO;
        public int AcessoCadastroUsuario
        {
            get
            {
                return this.ACESSOCADASTROUSUARIO;

            }
            set
            {
                this.ACESSOCADASTROUSUARIO = value;
            }
        }
        private int CRIARNIVELACESSO;
        public int CriarNivelAcesso
        {
            get
            {
                return this.CRIARNIVELACESSO;

            }
            set
            {
                this.CRIARNIVELACESSO = value;
            }
        }
        private int ATUALIZACAOTELAPRINCIPAL;
        public int AtualicazaoTelaPrincipal
        {
            get
            {
                return this.ATUALIZACAOTELAPRINCIPAL;

            }
            set
            {
                this.ATUALIZACAOTELAPRINCIPAL = value;
            }
        }

        //PERMISSÃO BASE DADOS
        private int PERMISSAOBASEDADOS;
        public int PermissaoBasedados
        {
            get
            {
                return this.PERMISSAOBASEDADOS;

            }
            set
            {
                this.PERMISSAOBASEDADOS = value;
            }
        }
        private int PERMISSAONIVELACESSO;
        public int PermissaoNivelaAcesso
        {
            get
            {
                return this.PERMISSAONIVELACESSO;

            }
            set
            {
                this.PERMISSAONIVELACESSO = value;
            }
        }
        private int PERMISSOFUNCIONARIORH;
        public int PermissaoFuncionarioRh
        {
            get
            {
                return this.PERMISSOFUNCIONARIORH;

            }
            set
            {
                this.PERMISSOFUNCIONARIORH = value;
            }
        }
        private int PERMISSAOUSUARIOACESSO;
        public int PermissaoUsuarioAcesso
        {
            get
            {
                return this.PERMISSAOUSUARIOACESSO;

            }
            set
            {
                this.PERMISSAOUSUARIOACESSO = value;
            }
        }
    }
}
