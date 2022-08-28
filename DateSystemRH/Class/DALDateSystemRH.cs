using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data;


namespace DateSystemRH
{
    class DALDateSystemRH
    {
        //public class Conexao
        //{
        //}

        private Conexao2 objConexao;
        StringBuilder errorMessages = new StringBuilder();
        public DALDateSystemRH(Conexao2 conexao2)
        {
            objConexao = conexao2;
        }
        ////Base de Dados Pessoas  RH---------------------------------------------------------------------------------------------------------------------------
        public void IncluirDadosPessoas(DadosPessoas DPessoas)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                //transacao = objConexao.ObjetoConexao.BeginTransaction("");


                cmd.CommandText = "EXEC RH_DadosPessoasInserir @CARGO,@DATA_CADASTRO,@NOME,@IDADE,@FUMANTE,@ID_REGIAO_ONDE_MORA,@PONTO_REFERENCIA," +
                                  "@RESIDE_Q_TEMPO_LOCAL,@ID_MOVEL,@TELEFONE,@CELULAR,@TELEFONE_RECADO,@CELULAR_RECADO,@NOME_RECADO," +
                                  "@RG,@DATA_EXP_ORGAO_EXP,@CPF,@CARTEIRA_TRABALHO,@CARTEIRA_SERIE,@PIS_PESSOA,@TITULO_ELEITORAL," +
                                  "@COMPROVANTE_VOTACAO,@NUMERO_RESERVISTA,@DATA_NASCIMENTO,@NATURAL_DE,@ESTADO_NATURAL,@NACIONALIDADE," +
                                  "@ALTURA,@PESO,@EMAIL,@ESTADO_CIVIL,@NOME_JUNTO,@DATA_JUNTO,@N_DEPENDENTES,@N_FILHOS,@IDADE_FILHOS," +
                                  "@NOME_PAI,@ESTADO_PAI,@DATA_PAI,@NOME_MAE,@ESTADO_MAE,@DATA_MAE,@ID_CLIENTE,@SITUACAO_CRIMINAL,@ID_PROFISSAO,@STATUS_MERCADO,@ID_PESSOA_LOGADA; select @@IDENTITY;";
                // "@ID_ESTABILIDADE,@COMENTARIO_ESTABILIDADE; select @@IDENTITY;";

                if (DPessoas.txtCargo == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CARGO", DPessoas.txtCargo).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CARGO", DPessoas.txtCargo);
                }
                if (DPessoas.txtDataCadastro == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_CADASTRO", DPessoas.txtDataCadastro).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_CADASTRO", DPessoas.txtDataCadastro);
                }
                if (DPessoas.txtNome == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME", DPessoas.txtNome).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME", DPessoas.txtNome);
                }
                if (DPessoas.txtIdade == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@IDADE", DPessoas.txtIdade).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IDADE", DPessoas.txtIdade);
                }
                if (DPessoas.radioButtonFSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@FUMANTE", DPessoas.radioButtonFSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@FUMANTE", DPessoas.radioButtonFSN);
                }
                if (DPessoas.radioButtonRegiao == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_REGIAO_ONDE_MORA", DPessoas.radioButtonRegiao).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_REGIAO_ONDE_MORA", DPessoas.radioButtonRegiao);
                }
                if (DPessoas.txtPontoReferencia == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PONTO_REFERENCIA", DPessoas.txtPontoReferencia).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PONTO_REFERENCIA", DPessoas.txtPontoReferencia);
                }
                if (DPessoas.txtResideQTLocal == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@RESIDE_Q_TEMPO_LOCAL", DPessoas.txtResideQTLocal).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@RESIDE_Q_TEMPO_LOCAL", DPessoas.txtResideQTLocal);
                }
                if (DPessoas.radioButtonMoradia == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_MOVEL", DPessoas.radioButtonMoradia).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_MOVEL", DPessoas.radioButtonMoradia);
                }
                if (DPessoas.txtTelefonePessoa == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@TELEFONE", DPessoas.txtTelefonePessoa).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TELEFONE", DPessoas.txtTelefonePessoa);
                }
                if (DPessoas.maskedtxtCelularPessoa == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CELULAR", DPessoas.maskedtxtCelularPessoa).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CELULAR", DPessoas.maskedtxtCelularPessoa);
                }
                if (DPessoas.maskedtxtTelefoneRecardo == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@TELEFONE_RECADO", DPessoas.maskedtxtTelefoneRecardo).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TELEFONE_RECADO", DPessoas.maskedtxtTelefoneRecardo);
                }
                if (DPessoas.maskedtxtCelularRecardo == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CELULAR_RECADO", DPessoas.maskedtxtCelularRecardo).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CELULAR_RECADO", DPessoas.maskedtxtCelularRecardo);
                }
                if (DPessoas.txtNomeRecardo == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_RECADO", DPessoas.txtNomeRecardo).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_RECADO", DPessoas.txtNomeRecardo);
                }
                if (DPessoas.maskedtxtRgNome == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@RG", DPessoas.maskedtxtRgNome).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@RG", DPessoas.maskedtxtRgNome);
                }
                if (DPessoas.txtDataOrgaoNome == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_EXP_ORGAO_EXP", DPessoas.txtDataOrgaoNome).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_EXP_ORGAO_EXP", DPessoas.txtDataOrgaoNome);
                }
                if (DPessoas.maskedtxtCpf == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CPF", DPessoas.maskedtxtCpf).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CPF", DPessoas.maskedtxtCpf);
                }
                if (DPessoas.txtCarteiraTrabalho == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CARTEIRA_TRABALHO", DPessoas.txtCarteiraTrabalho).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CARTEIRA_TRABALHO", DPessoas.txtCarteiraTrabalho);
                }
                if (DPessoas.txtSerieNome == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CARTEIRA_SERIE", DPessoas.txtSerieNome).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CARTEIRA_SERIE", DPessoas.txtSerieNome);
                }
                if (DPessoas.txtPisNome == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PIS_PESSOA", DPessoas.txtPisNome).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PIS_PESSOA", DPessoas.txtPisNome);
                }
                if (DPessoas.txtTituloEleitor == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@TITULO_ELEITORAL", DPessoas.txtTituloEleitor).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TITULO_ELEITORAL", DPessoas.txtTituloEleitor);
                }
                if (DPessoas.radioButtonVotacaoSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@COMPROVANTE_VOTACAO", DPessoas.radioButtonVotacaoSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@COMPROVANTE_VOTACAO", DPessoas.radioButtonVotacaoSN);
                }
                if (DPessoas.txtNReservista == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NUMERO_RESERVISTA", DPessoas.txtNReservista).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NUMERO_RESERVISTA", DPessoas.txtNReservista);
                }
                if (DPessoas.dateTimePickerDataNascimento == "")
                {
                    // passa valor nulo para a tabela SqlDateTime
                    cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", DPessoas.dateTimePickerDataNascimento).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", DPessoas.dateTimePickerDataNascimento);
                }
                if (DPessoas.txtnaturalDe == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NATURAL_DE", DPessoas.txtnaturalDe).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NATURAL_DE", DPessoas.txtnaturalDe);
                }
                if (DPessoas.txtEstadoNatural == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESTADO_NATURAL", DPessoas.txtEstadoNatural).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESTADO_NATURAL", DPessoas.txtEstadoNatural);
                }
                if (DPessoas.txtNacionalidade == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NACIONALIDADE", DPessoas.txtNacionalidade).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NACIONALIDADE", DPessoas.txtNacionalidade);
                }
                if (DPessoas.maskedtxtAltura == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ALTURA", DPessoas.maskedtxtAltura).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ALTURA", DPessoas.maskedtxtAltura);
                }
                if (DPessoas.maskedtxtPeso == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PESO", DPessoas.maskedtxtPeso).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PESO", DPessoas.maskedtxtPeso);
                }
                if (DPessoas.txtEmailNome == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@EMAIL", DPessoas.txtEmailNome).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@EMAIL", DPessoas.txtEmailNome);
                }
                if (DPessoas.txtEstadoCivil == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESTADO_CIVIL", DPessoas.txtEstadoCivil).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESTADO_CIVIL", DPessoas.txtEstadoCivil);
                }
                if (DPessoas.txtNomeJunto == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_JUNTO", DPessoas.txtNomeJunto).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_JUNTO", DPessoas.txtNomeJunto);
                }
                if (DPessoas.dateTimePickerNascimentoJunto == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_JUNTO", DPessoas.dateTimePickerNascimentoJunto).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_JUNTO", DPessoas.dateTimePickerNascimentoJunto);
                }
                if (DPessoas.txtNdependentes == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@N_DEPENDENTES", DPessoas.txtNdependentes).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@N_DEPENDENTES", DPessoas.txtNdependentes);
                }
                if (DPessoas.txtNFilhos == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@N_FILHOS", DPessoas.txtNFilhos).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@N_FILHOS", DPessoas.txtNFilhos);
                }
                if (DPessoas.txtIdadeFilhos == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@IDADE_FILHOS", DPessoas.txtIdadeFilhos).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IDADE_FILHOS", DPessoas.txtIdadeFilhos);
                }
                if (DPessoas.txtNomePai == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_PAI", DPessoas.txtNomePai).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_PAI", DPessoas.txtNomePai);
                }
                if (DPessoas.radioButtonPSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESTADO_PAI", DPessoas.radioButtonPSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESTADO_PAI", DPessoas.radioButtonPSN);
                }
                if (DPessoas.dateTimePickerNascimentoPai == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_PAI", DPessoas.dateTimePickerNascimentoPai).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_PAI", DPessoas.dateTimePickerNascimentoPai);
                }
                if (DPessoas.txtNomeMae == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_MAE", DPessoas.txtNomeMae).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_MAE", DPessoas.txtNomeMae);
                }
                if (DPessoas.radioButtonMVS == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESTADO_MAE", DPessoas.radioButtonMVS).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESTADO_MAE", DPessoas.radioButtonMVS);
                }
                if (DPessoas.dateTimePickerNascimentoMae == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_MAE", DPessoas.dateTimePickerNascimentoMae).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_MAE", DPessoas.dateTimePickerNascimentoMae);

                }
                if (DPessoas.ID_Cliente_MS == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", DPessoas.ID_Cliente_MS).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", DPessoas.ID_Cliente_MS);

                }
                if (DPessoas.SituacaoCriminal == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@SITUACAO_CRIMINAL", DPessoas.SituacaoCriminal).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SITUACAO_CRIMINAL", DPessoas.SituacaoCriminal);
                }
                if (DPessoas.SituacaoCriminal == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PROFISSAO", DPessoas.IdProfissao).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PROFISSAO", DPessoas.IdProfissao);
                }
                if (DPessoas.StatusMercado == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@STATUS_MERCADO", DPessoas.StatusMercado).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@STATUS_MERCADO", DPessoas.StatusMercado);
                }
                if (DPessoas.IdPessoaLogada == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_LOGADA", DPessoas.IdPessoaLogada).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_LOGADA", DPessoas.IdPessoaLogada);
                }
                objConexao.Conectar();
                DPessoas.Id_DadosPessoas = Convert.ToInt32(cmd.ExecuteScalar());
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
                Console.WriteLine(ex.ToString());
            }

        }
        public void IncluirCepPessoa(DadosPessoas PPessoasCep)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                /*
                cmd.CommandText = "INSERT INTO [dbo].[P_Cep]([ID_CEP],[CEP],[TIPO_LOGRADOURO],[ENDERECO],[NUMERO],[COMPLEMENTO],[BAIRRO],[CIDADE],[SIGLA_CIDADE])"
                + " VALUES(@IdCep,@Cep,@TipoLogradouro,@Endereco,@Numero,@Complemento,@Bairro,@Cidade,@SiglaCidade);select @@IDENTITY;";
                */
                cmd.CommandText = "exec RH_P_CepPessoaInserir @ID_CEP_PESSOA,@CEP,@TIPO_LOGRADOURO,@ENDERECO," +
                    "@NUMERO,@COMPLEMENTO,@BAIRRO,@CIDADE,@SIGLA,@ESTADO; ";
                if (PPessoasCep.Id_DadosPessoas == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_CEP_PESSOA", PPessoasCep.Id_DadosPessoas).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_CEP_PESSOA", PPessoasCep.Id_DadosPessoas);
                }

                if (PPessoasCep.maskedTextBoxCep == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CEP", PPessoasCep.maskedTextBoxCep).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CEP", PPessoasCep.maskedTextBoxCep);
                }
                if (PPessoasCep.txtLogradouroNome == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@TIPO_LOGRADOURO", PPessoasCep.txtLogradouroNome).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TIPO_LOGRADOURO", PPessoasCep.txtLogradouroNome);
                }
                if (PPessoasCep.txtEndereco == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ENDERECO", PPessoasCep.txtEndereco).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ENDERECO", PPessoasCep.txtEndereco);
                }
                if (PPessoasCep.txtNumero == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NUMERO", PPessoasCep.txtNumero).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NUMERO", PPessoasCep.txtNumero);
                }
                if (PPessoasCep.txtComplemento == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@COMPLEMENTO", PPessoasCep.txtComplemento).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@COMPLEMENTO", PPessoasCep.txtComplemento);
                }
                if (PPessoasCep.txtBairro == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@BAIRRO", PPessoasCep.txtBairro).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@BAIRRO", PPessoasCep.txtBairro);
                }
                if (PPessoasCep.txtCidadeNome == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CIDADE", PPessoasCep.txtCidadeNome).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CIDADE", PPessoasCep.txtCidadeNome);
                }
                if (PPessoasCep.txtSiglaNome == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@SIGLA", PPessoasCep.txtSiglaNome).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SIGLA", PPessoasCep.txtSiglaNome);
                }
                if (PPessoasCep.txtEstado == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESTADO", PPessoasCep.txtEstado).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESTADO", PPessoasCep.txtEstado);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void IncluirEscolaridade(Escolaridade PEscolaridade)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "EXEC RH_EscolaridadeInserir	@ID_PESSOA_ESCOLARIDADE,@PRIMERI_GRAU,@SEGUND_GRAU,@SUPERIOR," +
                    "@CURSO,@ESTUDA_ATUALMENTE,@ESTUDA_CURSO,@ANO_CURSANDO,@BAIRRO_CURSANDO, @HORARIO_CURSANDO;";

                if (PEscolaridade.Id_PessoasEscolaridade == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_ESCOLARIDADE", PEscolaridade.Id_PessoasEscolaridade).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_ESCOLARIDADE", PEscolaridade.Id_PessoasEscolaridade);
                }
                if (PEscolaridade.radioButton1GN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PRIMERI_GRAU", PEscolaridade.radioButton1GN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PRIMERI_GRAU", PEscolaridade.radioButton1GN);
                }
                if (PEscolaridade.radioButton2GSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@SEGUND_GRAU", PEscolaridade.radioButton2GSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SEGUND_GRAU", PEscolaridade.radioButton2GSN);
                }
                if (PEscolaridade.radioButtonSSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@SUPERIOR", PEscolaridade.radioButtonSSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SUPERIOR", PEscolaridade.radioButtonSSN);
                }
                if (PEscolaridade.txtSuperiorCurso == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CURSO", PEscolaridade.txtSuperiorCurso).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CURSO", PEscolaridade.txtSuperiorCurso);
                }
                if (PEscolaridade.radioButtonESSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESTUDA_ATUALMENTE", PEscolaridade.radioButtonESSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESTUDA_ATUALMENTE", PEscolaridade.radioButtonESSN);
                }
                if (PEscolaridade.txtEstudaAtualmente == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESTUDA_CURSO", PEscolaridade.txtEstudaAtualmente).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESTUDA_CURSO", PEscolaridade.txtEstudaAtualmente);
                }
                if (PEscolaridade.txtAnoEstaCursando == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ANO_CURSANDO", PEscolaridade.txtAnoEstaCursando).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ANO_CURSANDO", PEscolaridade.txtAnoEstaCursando);
                }
                if (PEscolaridade.txtBairroCursando == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@BAIRRO_CURSANDO", PEscolaridade.txtBairroCursando).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@BAIRRO_CURSANDO", PEscolaridade.txtBairroCursando);
                }
                if (PEscolaridade.maskedTxtHorarioCursando == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@HORARIO_CURSANDO", PEscolaridade.maskedTxtHorarioCursando).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@HORARIO_CURSANDO", PEscolaridade.maskedTxtHorarioCursando);
                }

                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }

        }
        public void IncluirProfissionais(Profissionais PProfissionais)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "EXEC RH_H_P_ProfisionalInserir @ID_PESSOA_PROFISSIONAL,@DATA_VIGILANTE,@NOME_ACADEMIA,@DATA_RECICLAGEM,@NOME_ACADEMIA_RE," +
                                                             "@CURSO_PORTARIA,@ESCOLA_PORTARIA,@COMPUTACAO,@OUTROS_CURSOS,@QUAIS_CURSOS,@RADIO_HT; ";

                if (PProfissionais.Id_PessoasProfissional == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_PROFISSIONAL", PProfissionais.Id_PessoasProfissional).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_PROFISSIONAL", PProfissionais.Id_PessoasProfissional);
                }
                if (PProfissionais.dateTimePickerFormacaoVigilante == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_VIGILANTE", PProfissionais.dateTimePickerFormacaoVigilante).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_VIGILANTE", PProfissionais.dateTimePickerFormacaoVigilante);
                }
                if (PProfissionais.txtNomeAcademiaVigilante == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_ACADEMIA", PProfissionais.txtNomeAcademiaVigilante).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_ACADEMIA", PProfissionais.txtNomeAcademiaVigilante);
                }
                if (PProfissionais.dateTimePickerReciclagem == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_RECICLAGEM", PProfissionais.dateTimePickerReciclagem).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_RECICLAGEM", PProfissionais.dateTimePickerReciclagem);
                }
                if (PProfissionais.txtNomeAcademiaReciclagem == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_ACADEMIA_RE", PProfissionais.txtNomeAcademiaReciclagem).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_ACADEMIA_RE", PProfissionais.txtNomeAcademiaReciclagem);
                }
                if (PProfissionais.txtCursoPortaria == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CURSO_PORTARIA", PProfissionais.txtCursoPortaria).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CURSO_PORTARIA", PProfissionais.txtCursoPortaria);
                }
                if (PProfissionais.txtEscolaPortaria == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESCOLA_PORTARIA", PProfissionais.txtEscolaPortaria).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESCOLA_PORTARIA", PProfissionais.txtEscolaPortaria);
                }
                if (PProfissionais.radioButtonCSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@COMPUTACAO", PProfissionais.radioButtonCSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@COMPUTACAO", PProfissionais.radioButtonCSN);
                }
                if (PProfissionais.radioButtonOCSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@OUTROS_CURSOS", PProfissionais.radioButtonOCSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@OUTROS_CURSOS", PProfissionais.radioButtonOCSN);
                }
                if (PProfissionais.txtQuaisCursos == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@QUAIS_CURSOS", PProfissionais.txtQuaisCursos).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@QUAIS_CURSOS", PProfissionais.txtQuaisCursos);
                }
                if (PProfissionais.radioButtonRHSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@RADIO_HT", PProfissionais.radioButtonRHSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@RADIO_HT", PProfissionais.radioButtonRHSN);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }

        }
        public void IncluirInformacoes(Informacoes PInformacoes)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "EXEC RH_P_InformacoesInserir @ID_PESSOA_INFORMACOES,@FAZ_USO_ILICITAS,@ILICITAS_QUAIS," +
                                             "@FAZ_TRATAMENTO_MEDICO,@TRATAMENTO_MEDICO_QUAIS,@PERIODO_NOTURNO,@PRAZO_EXPERIENCIA," +
                                             "@ESCALA_REVERSAMENTO,@TRANFERIDO_BAIRRO,@CONHECE_ALGUEM_EMPRESA,@PARENTE,@NOME_PARENTE," +
                                             "@CARGO_PARENTE,@LOCAL_TRABALHA_PARENTE;";

                if (PInformacoes.Id_PessoasInformacoes == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_INFORMACOES", PInformacoes.Id_PessoasInformacoes).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_INFORMACOES", PInformacoes.Id_PessoasInformacoes);
                }
                if (PInformacoes.radioButtonFATISN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@FAZ_USO_ILICITAS", PInformacoes.radioButtonFATISN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@FAZ_USO_ILICITAS", PInformacoes.radioButtonFATISN);
                }
                if (PInformacoes.txtDrogasIlicitas == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ILICITAS_QUAIS", PInformacoes.txtDrogasIlicitas).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ILICITAS_QUAIS", PInformacoes.txtDrogasIlicitas);
                }
                if (PInformacoes.radioButtonFATMS == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@FAZ_TRATAMENTO_MEDICO", PInformacoes.radioButtonFATMS).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@FAZ_TRATAMENTO_MEDICO", PInformacoes.radioButtonFATMS);
                }
                if (PInformacoes.txtTratamentoMedico == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@TRATAMENTO_MEDICO_QUAIS", PInformacoes.txtTratamentoMedico).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TRATAMENTO_MEDICO_QUAIS", PInformacoes.txtTratamentoMedico);
                }
                if (PInformacoes.radioButtonPNSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PERIODO_NOTURNO", PInformacoes.radioButtonPNSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PERIODO_NOTURNO", PInformacoes.radioButtonPNSN);
                }
                if (PInformacoes.radioButtonPESN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PRAZO_EXPERIENCIA", PInformacoes.radioButtonPESN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PRAZO_EXPERIENCIA", PInformacoes.radioButtonPESN);
                }
                if (PInformacoes.radioButtonERSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESCALA_REVERSAMENTO", PInformacoes.radioButtonERSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESCALA_REVERSAMENTO", PInformacoes.radioButtonERSN);
                }
                if (PInformacoes.radioButtonTBSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@TRANFERIDO_BAIRRO", PInformacoes.radioButtonTBSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TRANFERIDO_BAIRRO", PInformacoes.radioButtonTBSN);
                }
                if (PInformacoes.radioButtonConheceAlguemSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CONHECE_ALGUEM_EMPRESA", PInformacoes.radioButtonConheceAlguemSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CONHECE_ALGUEM_EMPRESA", PInformacoes.radioButtonConheceAlguemSN);
                }
                if (PInformacoes.radioButtonParenteSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PARENTE", PInformacoes.radioButtonParenteSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PARENTE", PInformacoes.radioButtonParenteSN);
                }
                if (PInformacoes.txtNomeConhecidoEmpresa == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_PARENTE", PInformacoes.txtNomeConhecidoEmpresa).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_PARENTE", PInformacoes.txtNomeConhecidoEmpresa);
                }
                if (PInformacoes.txtCargoConhecidoEmpresa == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CARGO_PARENTE", PInformacoes.txtCargoConhecidoEmpresa).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CARGO_PARENTE", PInformacoes.txtCargoConhecidoEmpresa);
                }
                if (PInformacoes.txtTrabalhoConhecidoEmpresa == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@LOCAL_TRABALHA_PARENTE", PInformacoes.txtTrabalhoConhecidoEmpresa).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@LOCAL_TRABALHA_PARENTE", PInformacoes.txtTrabalhoConhecidoEmpresa);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }

        }
        public void IncluirP_ConheceEmpresa(Informacoes PInformacoes)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "EXEC RH_P_InformacoesInserir @ID_PESSOA_CONHECE_EMPRESA,@PLAQUEIRA,@INDICACAO," +
                                        "@ESCOLA,@JORNAL,@OUTROS,@CONVOCADO;";

                if (PInformacoes.Id_PessoasInformacoes == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_CONHECE_EMPRESA", PInformacoes.Id_PessoasInformacoes).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_CONHECE_EMPRESA", PInformacoes.Id_PessoasInformacoes);
                }
                if (PInformacoes.checkBoxPlaqueira == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PLAQUEIRA", PInformacoes.checkBoxPlaqueira).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PLAQUEIRA", PInformacoes.checkBoxPlaqueira);
                }
                if (PInformacoes.checkBoxIndicacao == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@INDICACAO", PInformacoes.checkBoxIndicacao).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@INDICACAO", PInformacoes.checkBoxIndicacao);
                }
                if (PInformacoes.checkBoxEscola == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESCOLA", PInformacoes.checkBoxEscola).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESCOLA", PInformacoes.checkBoxEscola);
                }
                if (PInformacoes.checkBoxJornal == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@JORNAL", PInformacoes.checkBoxJornal).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@JORNAL", PInformacoes.checkBoxJornal);
                }
                if (PInformacoes.checkBoxOutros == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@OUTROS", PInformacoes.checkBoxOutros).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@OUTROS", PInformacoes.checkBoxOutros);
                }
                if (PInformacoes.checkBoxConvocado == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CONVOCADO", PInformacoes.checkBoxConvocado).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CONVOCADO", PInformacoes.checkBoxConvocado);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }

        public void IncluirCarteiraMotorista(Informacoes PInformacoes)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_P_CarteiraMotoristaInserir @ID_PESSOA_CARTEIRA_MOTORISTA,@N_CNH,@DATA_VALIDADE,@CARTEIRA_A," +
                    "@CARTEIRA_B, @CARTEIRA_C,@CARTEIRA_D; ";

                if (PInformacoes.Id_PessoasInformacoes == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_CARTEIRA_MOTORISTA", PInformacoes.Id_PessoasInformacoes).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_CARTEIRA_MOTORISTA", PInformacoes.Id_PessoasInformacoes);
                }
                if (PInformacoes.txtNumeroCarteiraMotorista == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@N_CNH", PInformacoes.txtNumeroCarteiraMotorista).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@N_CNH", PInformacoes.txtNumeroCarteiraMotorista);
                }
                if (PInformacoes.dateTimePickerDataValidadeCMotorista == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_VALIDADE", PInformacoes.dateTimePickerDataValidadeCMotorista).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_VALIDADE", PInformacoes.dateTimePickerDataValidadeCMotorista);
                }
                if (PInformacoes.checkBoxCMA == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CARTEIRA_A", PInformacoes.checkBoxCMA).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CARTEIRA_A", PInformacoes.checkBoxCMA);
                }
                if (PInformacoes.checkBoxCMB == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CARTEIRA_B", PInformacoes.checkBoxCMB).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CARTEIRA_B", PInformacoes.checkBoxCMB);
                }
                if (PInformacoes.checkBoxCMC == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CARTEIRA_C", PInformacoes.checkBoxCMC).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CARTEIRA_C", PInformacoes.checkBoxCMC);
                }
                if (PInformacoes.checkBoxCMD == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CARTEIRA_D", PInformacoes.checkBoxCMD).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CARTEIRA_D", PInformacoes.checkBoxCMD);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void IncluirCConheceuEmpresa(Informacoes PInformacoes)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;
                cmd.CommandText = "exec RH_P_ConheceEmpresaInserir @ID_PESSOA_CONHECE_EMPRESA,@PLAQUEIRA,@INDICACAO,@ESCOLA," +
                    "@JORNAL,@OUTROS,@CONVOCADO; ";

                if (PInformacoes.Id_PessoasInformacoes == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_CONHECE_EMPRESA", PInformacoes.Id_PessoasInformacoes).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_CONHECE_EMPRESA", PInformacoes.Id_PessoasInformacoes);
                }
                if (PInformacoes.checkBoxPlaqueira == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PLAQUEIRA", PInformacoes.checkBoxPlaqueira).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PLAQUEIRA", PInformacoes.checkBoxPlaqueira);
                }
                if (PInformacoes.checkBoxIndicacao == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@INDICACAO", PInformacoes.checkBoxIndicacao).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@INDICACAO", PInformacoes.checkBoxIndicacao);
                }
                if (PInformacoes.checkBoxEscola == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESCOLA", PInformacoes.checkBoxEscola).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESCOLA", PInformacoes.checkBoxEscola);
                }
                if (PInformacoes.checkBoxJornal == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@JORNAL", PInformacoes.checkBoxJornal).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@JORNAL", PInformacoes.checkBoxJornal);
                }
                if (PInformacoes.checkBoxOutros == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@OUTROS", PInformacoes.checkBoxOutros).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@OUTROS", PInformacoes.checkBoxOutros);
                }
                if (PInformacoes.checkBoxConvocado == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CONVOCADO", PInformacoes.checkBoxConvocado).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CONVOCADO", PInformacoes.checkBoxConvocado);
                }

                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }

        }
        public void IncluirProfissionais2(Profissional2 PProfissional2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_P_Profisional2Inserir @ID_PESSOA_PROFISSIONAL2,@ULTIMO_EMPREGO,@ULTIMO_CARGO,@ULTIMO_SALARIO," +
                    "@DATA_ENTRADA_ULTIMO,@DATA_SAIDA_ULTIMO,@NOME_FECHE_ULTIMO,@FONE_ULTIMO,@MOTIVO_ULTIMO,@PENULTIMO_EMPREGO,@PENULTIMO_CARGO," +
                    "@PENULTIMO_SALARIO,@DATA_ENTRADA_PENULTIMO,@DATA_SAIDA_PENULTIMO,@NOME_FECHE_PENULTIMO,@FONE_PENULTIMO,@MOTIVO_PENULTIMO," +
                    "@ANTEPENULTIMO_EMPREGO,@ANTEPENULTIMO_CARGO,@ANTEPENULTIMO_SALARIO,@DATA_ENTRADA_ANTEPENULTIMO,@DATA_SAIDA_ANTEPENULTIMO," +
                    "@NOME_FECHE_ANTEPENULTIMO,@FONE_ANTEPENULTIMO,@MOTIVO_ANTEPENULTIMO;";


                if (PProfissional2.Id_PessoaProfissional2 == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_PROFISSIONAL2", PProfissional2.Id_PessoaProfissional2).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_PROFISSIONAL2", PProfissional2.Id_PessoaProfissional2);
                }
                if (PProfissional2.txtUltimoEmprego == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ULTIMO_EMPREGO", PProfissional2.txtUltimoEmprego).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ULTIMO_EMPREGO", PProfissional2.txtUltimoEmprego);
                }
                if (PProfissional2.txtUltimoCargo == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ULTIMO_CARGO", PProfissional2.txtUltimoCargo).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ULTIMO_CARGO", PProfissional2.txtUltimoCargo);
                }
                if (PProfissional2.txtUltimoSalario == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ULTIMO_SALARIO", PProfissional2.txtUltimoSalario).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ULTIMO_SALARIO", PProfissional2.txtUltimoSalario);
                }
                if (PProfissional2.dateTimePickerUltimaEntrada == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_ENTRADA_ULTIMO", PProfissional2.dateTimePickerUltimaEntrada).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_ENTRADA_ULTIMO", PProfissional2.dateTimePickerUltimaEntrada);
                }
                if (PProfissional2.dateTimePickerUltimaSaida == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_SAIDA_ULTIMO", PProfissional2.dateTimePickerUltimaSaida).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_SAIDA_ULTIMO", PProfissional2.dateTimePickerUltimaSaida);
                }
                if (PProfissional2.txtNomeUltimoChefe == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_FECHE_ULTIMO", PProfissional2.txtNomeUltimoChefe).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_FECHE_ULTIMO", PProfissional2.txtNomeUltimoChefe);
                }
                if (PProfissional2.maskedtxtTelefoneUltimoEmprego == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@FONE_ULTIMO", PProfissional2.maskedtxtTelefoneUltimoEmprego).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@FONE_ULTIMO", PProfissional2.maskedtxtTelefoneUltimoEmprego);
                }
                if (PProfissional2.txtMotivoSaidaUltimoEmprego == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@MOTIVO_ULTIMO", PProfissional2.txtMotivoSaidaUltimoEmprego).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MOTIVO_ULTIMO", PProfissional2.txtMotivoSaidaUltimoEmprego);
                }
                if (PProfissional2.txtPenultimoEmprego == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PENULTIMO_EMPREGO", PProfissional2.txtPenultimoEmprego).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PENULTIMO_EMPREGO", PProfissional2.txtPenultimoEmprego);
                }
                if (PProfissional2.txtPenultimoCargo == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PENULTIMO_CARGO", PProfissional2.txtPenultimoCargo).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PENULTIMO_CARGO", PProfissional2.txtPenultimoCargo);
                }
                if (PProfissional2.txtPenultimoSalario == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PENULTIMO_SALARIO", PProfissional2.txtPenultimoSalario).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PENULTIMO_SALARIO", PProfissional2.txtPenultimoSalario);
                }
                if (PProfissional2.dateTimePickerPenultimaEntrada == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_ENTRADA_PENULTIMO", PProfissional2.dateTimePickerPenultimaEntrada).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_ENTRADA_PENULTIMO", PProfissional2.dateTimePickerPenultimaEntrada);
                }
                if (PProfissional2.dateTimePickerPenultimaSaida == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_SAIDA_PENULTIMO", PProfissional2.dateTimePickerPenultimaSaida).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_SAIDA_PENULTIMO", PProfissional2.dateTimePickerPenultimaSaida);
                }
                if (PProfissional2.txtNomePenultimoChefe == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_FECHE_PENULTIMO", PProfissional2.txtNomePenultimoChefe).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_FECHE_PENULTIMO", PProfissional2.txtNomePenultimoChefe);
                }
                if (PProfissional2.maskedtxtTelefonePenultimoEmprego == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@FONE_PENULTIMO", PProfissional2.maskedtxtTelefonePenultimoEmprego).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@FONE_PENULTIMO", PProfissional2.maskedtxtTelefonePenultimoEmprego);
                }
                if (PProfissional2.txtMotivoSaidaPenultimoEmprego == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@MOTIVO_PENULTIMO", PProfissional2.txtMotivoSaidaPenultimoEmprego).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MOTIVO_PENULTIMO", PProfissional2.txtMotivoSaidaPenultimoEmprego);
                }
                if (PProfissional2.txtAntepenultimoEmprego == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ANTEPENULTIMO_EMPREGO", PProfissional2.txtAntepenultimoEmprego).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ANTEPENULTIMO_EMPREGO", PProfissional2.txtAntepenultimoEmprego);
                }
                if (PProfissional2.txtAntepenultimoCargo == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ANTEPENULTIMO_CARGO", PProfissional2.txtAntepenultimoCargo).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ANTEPENULTIMO_CARGO", PProfissional2.txtAntepenultimoCargo);
                }
                if (PProfissional2.txtAntepenultimoSalario == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ANTEPENULTIMO_SALARIO", PProfissional2.txtAntepenultimoSalario).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ANTEPENULTIMO_SALARIO", PProfissional2.txtAntepenultimoSalario);
                }
                if (PProfissional2.dateTimePickerAntepenultimoEntrada == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_ENTRADA_ANTEPENULTIMO", PProfissional2.dateTimePickerAntepenultimoEntrada).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_ENTRADA_ANTEPENULTIMO", PProfissional2.dateTimePickerAntepenultimoEntrada);
                }
                if (PProfissional2.dateTimePickerAntepenultimoSaida == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_SAIDA_ANTEPENULTIMO", PProfissional2.dateTimePickerAntepenultimoSaida).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_SAIDA_ANTEPENULTIMO", PProfissional2.dateTimePickerAntepenultimoSaida);
                }
                if (PProfissional2.txtNomeAntepenultimoChefe == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_FECHE_ANTEPENULTIMO", PProfissional2.txtNomeAntepenultimoChefe).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_FECHE_ANTEPENULTIMO", PProfissional2.txtNomeAntepenultimoChefe);
                }
                if (PProfissional2.maskedtxtTelefoneAntepenultimoEmprego == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@FONE_ANTEPENULTIMO", PProfissional2.maskedtxtTelefoneAntepenultimoEmprego).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@FONE_ANTEPENULTIMO", PProfissional2.maskedtxtTelefoneAntepenultimoEmprego);
                }
                if (PProfissional2.txtMotivoSaidaAntepenultimoEmprego == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@MOTIVO_ANTEPENULTIMO", PProfissional2.txtMotivoSaidaAntepenultimoEmprego).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MOTIVO_ANTEPENULTIMO", PProfissional2.txtMotivoSaidaAntepenultimoEmprego);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void IncluirRecrutamentoSelecao(Profissional2 PProfissional2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_P_RecrutamentoSelecaoInserir @ID_PESSOA_RECRUTAMENTO,@NOME;";


                if (PProfissional2.Id_PessoaProfissional2 == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_RECRUTAMENTO", PProfissional2.Id_PessoaProfissional2).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_RECRUTAMENTO", PProfissional2.Id_PessoaProfissional2);
                }
                if (PProfissional2.txtRecutamentoSelecao == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME", PProfissional2.txtRecutamentoSelecao).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME", PProfissional2.txtRecutamentoSelecao);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void IncluirAvaliacaoTecnica(Avaliacao PAvaliacao)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_P_AvaliacaoTecnicaInserir @ID_PESSOA_AVALIACAO,@PARECER_APROVADO,@ENTREVISTADO_APROVADO," +
                                "@COMENTARIO_APROVADO,@PARECER_APROVEITAMENTO,@ENTREVISTADO_APROVEITAMENTO,@COMENTARIO_APROVEITAMENTO," +
                                "@DATA_AVALIACAO,@MS; ";


                if (PAvaliacao.Id_PessoasAvaliacao == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_AVALIACAO", PAvaliacao.Id_PessoasAvaliacao).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_AVALIACAO", PAvaliacao.Id_PessoasAvaliacao);
                }
                if (PAvaliacao.radioButtonPASN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PARECER_APROVADO", PAvaliacao.radioButtonPASN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PARECER_APROVADO", PAvaliacao.radioButtonPASN);
                }
                if (PAvaliacao.txtEntrevistadoAprovado == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ENTREVISTADO_APROVADO", PAvaliacao.txtEntrevistadoAprovado).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ENTREVISTADO_APROVADO", PAvaliacao.txtEntrevistadoAprovado);
                }
                if (PAvaliacao.txtComentariosAprovado == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@COMENTARIO_APROVADO", PAvaliacao.txtComentariosAprovado).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@COMENTARIO_APROVADO", PAvaliacao.txtComentariosAprovado);
                }
                if (PAvaliacao.radioButtonPFASN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PARECER_APROVEITAMENTO", PAvaliacao.radioButtonPFASN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PARECER_APROVEITAMENTO", PAvaliacao.radioButtonPFASN);
                }
                if (PAvaliacao.txtEntrevistadoAproveitamento == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ENTREVISTADO_APROVEITAMENTO", PAvaliacao.txtEntrevistadoAproveitamento).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ENTREVISTADO_APROVEITAMENTO", PAvaliacao.txtEntrevistadoAproveitamento);
                }
                if (PAvaliacao.txtComentariosEntrevistado == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@COMENTARIO_APROVEITAMENTO", PAvaliacao.txtComentariosEntrevistado).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@COMENTARIO_APROVEITAMENTO", PAvaliacao.txtComentariosEntrevistado);
                }
                if (PAvaliacao.dateTimePickerDataTreinamentoAvaliacao == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_AVALIACAO", PAvaliacao.dateTimePickerDataTreinamentoAvaliacao).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_AVALIACAO", PAvaliacao.dateTimePickerDataTreinamentoAvaliacao);
                }
                if (PAvaliacao.txtMSAvaliacao == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@MS", PAvaliacao.txtMSAvaliacao).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MS", PAvaliacao.txtMSAvaliacao);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void IncluirExEmpregado(ExEmpregado PExEmpregado)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_P_ExEmpregadoInserir @ID_PESSOA_EMPREGADO,@NOME,@EX_FUNCIONARIO,@QUAL_POSTO,@DATA_ADMISSAO," +
                    "@DATA_DEMISSAO,@SUPERVISOR,@MOTIVO_SAIDA,@RE,@TREINAMENTOINFORME;";


                if (PExEmpregado.Id_PessoasExEmpregado == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_EMPREGADO", PExEmpregado.Id_PessoasExEmpregado).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_EMPREGADO", PExEmpregado.Id_PessoasExEmpregado);
                }
                if (PExEmpregado.txtNomeEmpregado == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME", PExEmpregado.txtNomeEmpregado).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME", PExEmpregado.txtNomeEmpregado);
                }
                if (PExEmpregado.radioButtonJTEMSS == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@EX_FUNCIONARIO", PExEmpregado.radioButtonJTEMSS).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@EX_FUNCIONARIO", PExEmpregado.radioButtonJTEMSS);
                }
                if (PExEmpregado.txtQualPosto == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@QUAL_POSTO", PExEmpregado.txtQualPosto).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@QUAL_POSTO", PExEmpregado.txtQualPosto);
                }
                if (PExEmpregado.dateTimePickerAdmissaoEmpregado == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_ADMISSAO", PExEmpregado.dateTimePickerAdmissaoEmpregado).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_ADMISSAO", PExEmpregado.dateTimePickerAdmissaoEmpregado);
                }
                if (PExEmpregado.dateTimePickerDemissaoEmpregado == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_DEMISSAO", PExEmpregado.dateTimePickerDemissaoEmpregado).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_DEMISSAO", PExEmpregado.dateTimePickerDemissaoEmpregado);
                }
                if (PExEmpregado.txtQuemSupervisor == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@SUPERVISOR", PExEmpregado.txtQuemSupervisor).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SUPERVISOR", PExEmpregado.txtQuemSupervisor);
                }
                if (PExEmpregado.txtMotivoSaida == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@MOTIVO_SAIDA", PExEmpregado.txtMotivoSaida).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MOTIVO_SAIDA", PExEmpregado.txtMotivoSaida);
                }
                if (PExEmpregado.txtREEmpregado == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@RE", PExEmpregado.txtREEmpregado).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@RE", PExEmpregado.txtREEmpregado);
                }
                if (PExEmpregado.txtTreinamentoInforme == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@TREINAMENTOINFORME", PExEmpregado.txtTreinamentoInforme).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TREINAMENTOINFORME", PExEmpregado.txtTreinamentoInforme);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }

        }
        public void IncluirRedacao(ExEmpregado PExEmpregado)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_P_Redacao @ID_PESSOA_EMPREGADO,@REDACAO;";


                if (PExEmpregado.Id_PessoasExEmpregado == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_EMPREGADO", PExEmpregado.Id_PessoasExEmpregado).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_EMPREGADO", PExEmpregado.Id_PessoasExEmpregado);
                }
                if (PExEmpregado.txtRedacao == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@REDACAO", PExEmpregado.txtRedacao).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@REDACAO", PExEmpregado.txtRedacao);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void IncluirPassagemCriminal(PassagemCriminal PPassagemCriminal)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_P_PassagemCriminalInserir @ID_PASSAGEM_CRIMINAL,@COMENTARIO;";


                if (PPassagemCriminal.Id_PessoasPassagemCriminal == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PASSAGEM_CRIMINAL", PPassagemCriminal.Id_PessoasPassagemCriminal).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PASSAGEM_CRIMINAL", PPassagemCriminal.Id_PessoasPassagemCriminal);
                }
                if (PPassagemCriminal.txtComentarios == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@COMENTARIO", PPassagemCriminal.txtComentarios).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@COMENTARIO", PPassagemCriminal.txtComentarios);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void IncluirEstabilidade(DadosPessoas PPessoa)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_P_EstabilidadePessoaInserir 	@ID_ESTABILIDADE_PESSOA,@ID_ESTABILIDADE,@COMENTARIO; ";


                if (PPessoa.Id_DadosPessoas == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_ESTABILIDADE_PESSOA", PPessoa.Id_DadosPessoas).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_ESTABILIDADE_PESSOA", PPessoa.Id_DadosPessoas);
                }
                if (PPessoa.Id_Estabilidade == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_ESTABILIDADE", PPessoa.Id_Estabilidade).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_ESTABILIDADE", PPessoa.Id_Estabilidade);
                }
                if (PPessoa.ComentarioEstabilidade == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@COMENTARIO", PPessoa.ComentarioEstabilidade).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@COMENTARIO", PPessoa.ComentarioEstabilidade);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void IncluirCadastraEmpresaCliente(CadastroEmpresaCliente CadastroEmpresaClienteC)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_CadastraEmpresaClienteInserir @NOME_EMPRESA,@ENDERECO,@MS,@STATUS_ATIVO,@COMENTARIO; ";


                if (CadastroEmpresaClienteC.NomeEmpresa == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_EMPRESA", CadastroEmpresaClienteC.NomeEmpresa).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_EMPRESA", CadastroEmpresaClienteC.NomeEmpresa);
                }
                if (CadastroEmpresaClienteC.Endereco == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ENDERECO", CadastroEmpresaClienteC.Endereco).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ENDERECO", CadastroEmpresaClienteC.Endereco);
                }
                if (CadastroEmpresaClienteC.Ms == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@MS", CadastroEmpresaClienteC.Ms).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MS", CadastroEmpresaClienteC.Ms);
                }
                if (CadastroEmpresaClienteC.StatusAtivo == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@STATUS_ATIVO", CadastroEmpresaClienteC.StatusAtivo).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@STATUS_ATIVO", CadastroEmpresaClienteC.StatusAtivo);
                }
                if (CadastroEmpresaClienteC.Comentario == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@COMENTARIO", CadastroEmpresaClienteC.Comentario).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@COMENTARIO", CadastroEmpresaClienteC.Comentario);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void IncluirCadastraProcessoSelecao(ProcessoSeletivo ProcessoSeletivoP)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_CadastraProcessoSelecaoInserir @ID_EMPRESA,@ID_PROFISSAO_PROCESSO_SELETIVO,@STATUS_ATIVO,@STATUS_FINALIZADO,@DATA_CRIACAO,@DATA_FECHAMENTO,@COMENTARIO,@QUANT_VAGAS; select @@IDENTITY;";


                if (ProcessoSeletivoP.IdEmpresa == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_EMPRESA", ProcessoSeletivoP.IdEmpresa).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_EMPRESA", ProcessoSeletivoP.IdEmpresa);
                }
                if (ProcessoSeletivoP.IdProfissaoProcessoSeletivo == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PROFISSAO_PROCESSO_SELETIVO", ProcessoSeletivoP.IdProfissaoProcessoSeletivo).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PROFISSAO_PROCESSO_SELETIVO", ProcessoSeletivoP.IdProfissaoProcessoSeletivo);
                }
                if (ProcessoSeletivoP.checkBoxStatusAtivo == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@STATUS_ATIVO", ProcessoSeletivoP.checkBoxStatusAtivo).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@STATUS_ATIVO", ProcessoSeletivoP.checkBoxStatusAtivo);
                }
                if (ProcessoSeletivoP.checkBoxStatusFinalizacao == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@STATUS_FINALIZADO", ProcessoSeletivoP.checkBoxStatusFinalizacao).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@STATUS_FINALIZADO", ProcessoSeletivoP.checkBoxStatusFinalizacao);
                }
                if (ProcessoSeletivoP.dateTimePickerDataCriacao == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_CRIACAO", ProcessoSeletivoP.dateTimePickerDataCriacao).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_CRIACAO", ProcessoSeletivoP.dateTimePickerDataCriacao);
                }
                if (ProcessoSeletivoP.dateTimePickerDataFechamento == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_FECHAMENTO", ProcessoSeletivoP.dateTimePickerDataFechamento).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_FECHAMENTO", ProcessoSeletivoP.dateTimePickerDataFechamento);
                }
                if (ProcessoSeletivoP.txtComentatario == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@COMENTARIO", ProcessoSeletivoP.txtComentatario).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@COMENTARIO", ProcessoSeletivoP.txtComentatario);
                }
                if (ProcessoSeletivoP.txtQuantVagas == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@QUANT_VAGAS", ProcessoSeletivoP.txtQuantVagas).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@QUANT_VAGAS", ProcessoSeletivoP.txtQuantVagas);
                }
                objConexao.Conectar();
                ProcessoSeletivoP.IdProcessoSeletivo = Convert.ToInt32(cmd.ExecuteScalar());
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void IncluirCadastraCandidatosPSeletivo(CandidatosPSeletivo CandidatosPSeletivoP)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_CadastraCandidatosPSeletivoInserir @ID_PROCESSO_SELETIVO,@ID_PESSOA; ";


                if (CandidatosPSeletivoP.idProcessoSeletivo == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PROCESSO_SELETIVO", CandidatosPSeletivoP.idProcessoSeletivo).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PROCESSO_SELETIVO", CandidatosPSeletivoP.idProcessoSeletivo);
                }
                if (CandidatosPSeletivoP.IdPessoa == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA", CandidatosPSeletivoP.IdPessoa).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA", CandidatosPSeletivoP.IdPessoa);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        //Base de Dados Funcionario. E tambem Cep---------------------------------------------------------------------------------------------------------------------------
        public void IncluirUsuarioGeral(CadastraUsuario Usuario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;
                cmd.CommandText = "EXEC U_UsuarioGeralInserir @IdSituacao,@Nome,@SobreNome,@Abreviacao,@Telefone,@Telefone2,@Celular,@Celular2,@Email," +
                    "@Observacao,@Sexo,@Cpf,@Rg,@Data_Nascimento;select @@IDENTITY;";

                cmd.Parameters.AddWithValue("@IdSituacao", Usuario.IdSituacao);
                cmd.Parameters.AddWithValue("@Nome", Usuario.Nome);
                cmd.Parameters.AddWithValue("@SobreNome", Usuario.SobreNome);
                cmd.Parameters.AddWithValue("@Abreviacao", Usuario.Abreviacao);
                if (Usuario.Telefone == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Telefone", Usuario.Telefone).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Telefone", Usuario.Telefone);
                }
                if (Usuario.Telefone2 == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Telefone2", Usuario.Telefone2).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Telefone2", Usuario.Telefone2);
                }
                if (Usuario.Celular == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Celular", Usuario.Celular).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Celular", Usuario.Celular);
                }
                if (Usuario.Celular2 == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Celular2", Usuario.Celular2).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Celular2", Usuario.Celular2);
                }
                if (Usuario.Email == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Email", Usuario.Email).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Email", Usuario.Email);
                }
                if (Usuario.Observacao == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Observacao", Usuario.Observacao).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Observacao", Usuario.Observacao);
                }
                if (Usuario.Sexo == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Sexo", Usuario.Sexo).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Sexo", Usuario.Sexo);
                }
                if (Usuario.Cpf == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Cpf", Usuario.Cpf).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Cpf", Usuario.Cpf);
                }
                if (Usuario.Rg == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Rg", Usuario.Rg).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Rg", Usuario.Rg);
                }
                if (Usuario.Data_Nascimento == null)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Data_Nascimento", Usuario.Data_Nascimento).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Data_Nascimento", Usuario.Data_Nascimento);
                }

                objConexao.Conectar();
                Usuario.IdUsuario = Convert.ToInt32(cmd.ExecuteScalar());
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }

        //Ceu do usuario em geral Se ele precisa
        public void UsuarioGeralCepInserir(CepCadastraUsuario cep)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "exec U_UsuarioGeralCepInserir @IdCep,@Cep,@TipoLogradouro,@Endereco,@Numero,@Complemento,@Bairro,@Cidade;";

            cmd.Parameters.AddWithValue("@IdCep", cep.idCep);
            cmd.Parameters.AddWithValue("@Cep", cep.Cepc);

            if (cep.TipoLogradouro == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@TipoLogradouro", cep.TipoLogradouro).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@TipoLogradouro", cep.TipoLogradouro);
            }
            if (cep.Endereco == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Endereco", cep.Endereco).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Endereco", cep.Endereco);
            }
            if (cep.Numero == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Numero", cep.Numero).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Numero", cep.Numero);
            }
            if (cep.Complemento == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Complemento", cep.Complemento).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Complemento", cep.Complemento);
            }
            if (cep.Bairro == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Bairro", cep.Bairro).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Bairro", cep.Bairro);
            }
            if (cep.Cidade == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Cidade", cep.Cidade).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Cidade", cep.Cidade);
            }

            objConexao.Conectar();
            cmd.ExecuteScalar();
            objConexao.Desconectar();
        }
        //Base de Dados Funcionario FuncionarioRH. ---------------------------------------------------------------------------------------------------------------------------
        public void IncluirFuncionarioRh(FuncionarioRh FuncionarioRh2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "EXEC U_FuncionarioRhInserir @IdFuncionario,@IdRe,@Abreviacao,@Telefone,@Telefone2,@Celular,@Celular2,@Email;";
                cmd.Parameters.AddWithValue("@IdFuncionario", FuncionarioRh2.IdFuncionario);
                cmd.Parameters.AddWithValue("@IdRe", FuncionarioRh2.IdRe);
                if (FuncionarioRh2.Abreviacao == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Abreviacao", FuncionarioRh2.Abreviacao).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Abreviacao", FuncionarioRh2.Abreviacao);
                }
                if (FuncionarioRh2.Telefone == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Telefone", FuncionarioRh2.Telefone).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Telefone", FuncionarioRh2.Telefone);
                }
                if (FuncionarioRh2.Telefone2 == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Telefone2", FuncionarioRh2.Telefone2).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Telefone2", FuncionarioRh2.Telefone2);
                }
                if (FuncionarioRh2.Celular == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Celular", FuncionarioRh2.Celular).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Celular", FuncionarioRh2.Celular);
                }
                if (FuncionarioRh2.Celular2 == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Celular2", FuncionarioRh2.Celular2).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Celular2", FuncionarioRh2.Celular2);
                }
                if (FuncionarioRh2.Email == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Email", FuncionarioRh2.Email).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Email", FuncionarioRh2.Email);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }

        ////Criacao de login dos usuarios
        public void IncluirLoginUsuario(CadastroLoginNovo Usuario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "EXEC U_LoginUsuarioInserir @ID_LOGIN_USUARIO, @USUARIO, @SENHA, @CONFIRMACAOSENHA, @USUARIOADM, @ID_ACESSO_BASE_DADOS, @ACESSOCADASTROUSUARIO, @CRIARCADASTROUSUARIO," +
                    "@CRIARFUNCIONARIORH, @CRIARUSUARIOACESSO, @CRIARUSUAROBASEDADOS, @CRIARNIVELACESSSO, @CRIARPERMISSAOFUNCIONARIORH, @CRIARPERMISSAOUSUARIOACESSO," +
                    "@USUARIOCRIAR, @USUARIOALTERAR, @USUARIOEXCLUIR, @USUARIOPESQUISA, @USUARIOVISUALIZAR, @EMPRESACADASTRA, @EMPRESAPESQUISA, @EMPRESAVISUALIZAR," +
                    "@EMPRESAEDITAR, @EMPRESAEXCLUIR, @FICHACADASTRA, @FICHAPESQUISA, @FICHAVISUALIZAR, @FICHAEDITAR, @FICHAEXCLUIR, @PROCESSOSELECAOCADASTRA, @PROCESSOSELECAOPESQUISA," +
                    "@PROCESSOSELECAOVISUALIZAR, @PROCESSOSELECAOREDITAR, @PROCESSOSELECAOEXCLUIR, @ATUALIZACAOTELAPRINCIPAL;";


                cmd.Parameters.AddWithValue("@ID_LOGIN_USUARIO", Usuario.IdCadastroLoginNovo);
                cmd.Parameters.AddWithValue("@USUARIO", Usuario.Usuario);
                cmd.Parameters.AddWithValue("@SENHA", Usuario.Senha);
                cmd.Parameters.AddWithValue("@CONFIRMACAOSENHA", Usuario.ConfirmaSenha);
                cmd.Parameters.AddWithValue("@USUARIOADM", Usuario.UsuarioAcesso);
                cmd.Parameters.AddWithValue("@ID_ACESSO_BASE_DADOS", Usuario.IdAcessoBaseDados);

                cmd.Parameters.AddWithValue("@ACESSOCADASTROUSUARIO", Usuario.AcessoCadastroUsuario);
                cmd.Parameters.AddWithValue("@CRIARCADASTROUSUARIO", Usuario.CriarCadastroUsuario);
                cmd.Parameters.AddWithValue("@CRIARFUNCIONARIORH", Usuario.CriarFuncionarioRh);
                cmd.Parameters.AddWithValue("@CRIARUSUARIOACESSO", Usuario.CriarUsuarioAcesso);
                cmd.Parameters.AddWithValue("@CRIARUSUAROBASEDADOS", Usuario.CriarUsuarioBaseDados);
                cmd.Parameters.AddWithValue("@CRIARNIVELACESSSO", Usuario.CriarNivelAcesso);
                cmd.Parameters.AddWithValue("@CRIARPERMISSAOFUNCIONARIORH", Usuario.PermissaoFuncionarioRh);
                cmd.Parameters.AddWithValue("@CRIARPERMISSAOUSUARIOACESSO", Usuario.PermissaoUsuarioAcesso);

                cmd.Parameters.AddWithValue("@USUARIOCRIAR", Usuario.UsuarioCriar);
                cmd.Parameters.AddWithValue("@USUARIOALTERAR", Usuario.UsuarioAlterar);
                cmd.Parameters.AddWithValue("@USUARIOEXCLUIR", Usuario.UsuarioExcluir);
                cmd.Parameters.AddWithValue("@USUARIOPESQUISA", Usuario.UsuarioPesquisa);
                cmd.Parameters.AddWithValue("@USUARIOVISUALIZAR", Usuario.UsuarioVisualizar);

                cmd.Parameters.AddWithValue("@EMPRESACADASTRA", Usuario.CadastraEmpresa);
                cmd.Parameters.AddWithValue("@EMPRESAPESQUISA", Usuario.PesquisaEmpresa);
                cmd.Parameters.AddWithValue("@EMPRESAVISUALIZAR", Usuario.VisualizarEmpresa);
                cmd.Parameters.AddWithValue("@EMPRESAEDITAR", Usuario.EditarEmpresa);
                cmd.Parameters.AddWithValue("@EMPRESAEXCLUIR", Usuario.ExcluirEmpresa);

                cmd.Parameters.AddWithValue("@FICHACADASTRA", Usuario.CadastraFicha);
                cmd.Parameters.AddWithValue("@FICHAPESQUISA", Usuario.PesquisaFicha);
                cmd.Parameters.AddWithValue("@FICHAVISUALIZAR", Usuario.VisualizarFicha);
                cmd.Parameters.AddWithValue("@FICHAEDITAR", Usuario.EditarFicha);
                cmd.Parameters.AddWithValue("@FICHAEXCLUIR", Usuario.ExcluirFicha);

                cmd.Parameters.AddWithValue("@PROCESSOSELECAOCADASTRA", Usuario.CadastraProcessoSelecao);
                cmd.Parameters.AddWithValue("@PROCESSOSELECAOPESQUISA", Usuario.PesquisaProcessoSelecao);
                cmd.Parameters.AddWithValue("@PROCESSOSELECAOVISUALIZAR", Usuario.VisualizarProcessoSelecao);
                cmd.Parameters.AddWithValue("@PROCESSOSELECAOREDITAR", Usuario.EditarProcessoSelecao);
                cmd.Parameters.AddWithValue("@PROCESSOSELECAOEXCLUIR", Usuario.ExcluirProcessoSelecao);

                cmd.Parameters.AddWithValue("@ATUALIZACAOTELAPRINCIPAL", Usuario.AtualicazaoTelaPrincipal);

                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void IncluirFichaImagem(FichaImagem Ficha)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                //transacao = objConexao.ObjetoConexao.BeginTransaction("");

                cmd.CommandText = "EXEC RH_FichaImagemInserir @IdFicha,@Imagem,@IdLoginUsuario;";

                cmd.Parameters.AddWithValue("@IdFicha", Ficha.IdFicha);
                cmd.Parameters.AddWithValue("@Imagem", Ficha.Imagem);
                cmd.Parameters.AddWithValue("@IdLoginUsuario", Ficha.IdLoginUsuario);

                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }

        //Alterar Pessoa------------------------------------------------------------------------------------------------------------------------------------

        public void UpdateDadosPessoas(DadosPessoas DPessoas)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "EXEC RH_DadosPessoasUpdate @ID_DADOS_PESSOAS,@CARGO,@NOME,@IDADE,@FUMANTE,@ID_REGIAO_ONDE_MORA,@PONTO_REFERENCIA," +
                                      "@RESIDE_Q_TEMPO_LOCAL,@ID_MOVEL,@TELEFONE,@CELULAR,@TELEFONE_RECADO,@CELULAR_RECADO,@NOME_RECADO," +
                                      "@RG,@DATA_EXP_ORGAO_EXP,@CPF,@CARTEIRA_TRABALHO,@CARTEIRA_SERIE,@PIS_PESSOA,@TITULO_ELEITORAL," +
                                      "@COMPROVANTE_VOTACAO,@NUMERO_RESERVISTA,@DATA_NASCIMENTO,@NATURAL_DE,@ESTADO_NATURAL,@NACIONALIDADE," +
                                      "@ALTURA,@PESO,@EMAIL,@ESTADO_CIVIL,@NOME_JUNTO,@DATA_JUNTO,@N_DEPENDENTES,@N_FILHOS,@IDADE_FILHOS," +
                                      "@NOME_PAI,@ESTADO_PAI,@DATA_PAI,@NOME_MAE,@ESTADO_MAE,@DATA_MAE,@ID_CLIENTE,@SITUACAO_CRIMINAL,@ID_PROFISSAO,@STATUS_MERCADO,@ID_PESSOA_LOGADA;";

                if (DPessoas.Id_DadosPessoas == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_DADOS_PESSOAS", DPessoas.Id_DadosPessoas).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_DADOS_PESSOAS", DPessoas.Id_DadosPessoas);
                }
                if (DPessoas.txtCargo == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CARGO", DPessoas.txtCargo).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CARGO", DPessoas.txtCargo);
                }
                //if (DPessoas.txtDataCadastro == "")
                //{
                //    // passa valor nulo para a tabela
                //    cmd.Parameters.AddWithValue("@DATA_CADASTRO", DPessoas.txtDataCadastro).Value = SqlString.Null;
                //}
                //else
                //{
                //    cmd.Parameters.AddWithValue("@DATA_CADASTRO", DPessoas.txtDataCadastro);
                //}
                if (DPessoas.txtNome == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME", DPessoas.txtNome).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME", DPessoas.txtNome);
                }
                if (DPessoas.txtIdade == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@IDADE", DPessoas.txtIdade).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IDADE", DPessoas.txtIdade);
                }
                if (DPessoas.radioButtonFSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@FUMANTE", DPessoas.radioButtonFSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@FUMANTE", DPessoas.radioButtonFSN);
                }
                if (DPessoas.radioButtonRegiao == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_REGIAO_ONDE_MORA", DPessoas.radioButtonRegiao).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_REGIAO_ONDE_MORA", DPessoas.radioButtonRegiao);
                }
                if (DPessoas.txtPontoReferencia == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PONTO_REFERENCIA", DPessoas.txtPontoReferencia).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PONTO_REFERENCIA", DPessoas.txtPontoReferencia);
                }
                if (DPessoas.txtResideQTLocal == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@RESIDE_Q_TEMPO_LOCAL", DPessoas.txtResideQTLocal).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@RESIDE_Q_TEMPO_LOCAL", DPessoas.txtResideQTLocal);
                }
                if (DPessoas.radioButtonMoradia == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_MOVEL", DPessoas.radioButtonMoradia).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_MOVEL", DPessoas.radioButtonMoradia);
                }
                if (DPessoas.txtTelefonePessoa == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@TELEFONE", DPessoas.txtTelefonePessoa).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TELEFONE", DPessoas.txtTelefonePessoa);
                }
                if (DPessoas.maskedtxtCelularPessoa == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CELULAR", DPessoas.maskedtxtCelularPessoa).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CELULAR", DPessoas.maskedtxtCelularPessoa);
                }
                if (DPessoas.maskedtxtTelefoneRecardo == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@TELEFONE_RECADO", DPessoas.maskedtxtTelefoneRecardo).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TELEFONE_RECADO", DPessoas.maskedtxtTelefoneRecardo);
                }
                if (DPessoas.maskedtxtCelularRecardo == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CELULAR_RECADO", DPessoas.maskedtxtCelularRecardo).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CELULAR_RECADO", DPessoas.maskedtxtCelularRecardo);
                }
                if (DPessoas.txtNomeRecardo == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_RECADO", DPessoas.txtNomeRecardo).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_RECADO", DPessoas.txtNomeRecardo);
                }
                if (DPessoas.maskedtxtRgNome == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@RG", DPessoas.maskedtxtRgNome).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@RG", DPessoas.maskedtxtRgNome);
                }
                if (DPessoas.txtDataOrgaoNome == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_EXP_ORGAO_EXP", DPessoas.txtDataOrgaoNome).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_EXP_ORGAO_EXP", DPessoas.txtDataOrgaoNome);
                }
                if (DPessoas.maskedtxtCpf == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CPF", DPessoas.maskedtxtCpf).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CPF", DPessoas.maskedtxtCpf);
                }
                if (DPessoas.txtCarteiraTrabalho == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CARTEIRA_TRABALHO", DPessoas.txtCarteiraTrabalho).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CARTEIRA_TRABALHO", DPessoas.txtCarteiraTrabalho);
                }
                if (DPessoas.txtSerieNome == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CARTEIRA_SERIE", DPessoas.txtSerieNome).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CARTEIRA_SERIE", DPessoas.txtSerieNome);
                }
                if (DPessoas.txtPisNome == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PIS_PESSOA", DPessoas.txtPisNome).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PIS_PESSOA", DPessoas.txtPisNome);
                }
                if (DPessoas.txtTituloEleitor == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@TITULO_ELEITORAL", DPessoas.txtTituloEleitor).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TITULO_ELEITORAL", DPessoas.txtTituloEleitor);
                }
                if (DPessoas.radioButtonVotacaoSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@COMPROVANTE_VOTACAO", DPessoas.radioButtonVotacaoSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@COMPROVANTE_VOTACAO", DPessoas.radioButtonVotacaoSN);
                }
                if (DPessoas.txtNReservista == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NUMERO_RESERVISTA", DPessoas.txtNReservista).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NUMERO_RESERVISTA", DPessoas.txtNReservista);
                }
                if (DPessoas.dateTimePickerDataNascimento == "")
                {
                    // passa valor nulo para a tabela SqlDateTime
                    cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", DPessoas.dateTimePickerDataNascimento).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", DPessoas.dateTimePickerDataNascimento);
                }
                if (DPessoas.txtnaturalDe == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NATURAL_DE", DPessoas.txtnaturalDe).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NATURAL_DE", DPessoas.txtnaturalDe);
                }
                if (DPessoas.txtEstadoNatural == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESTADO_NATURAL", DPessoas.txtEstadoNatural).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESTADO_NATURAL", DPessoas.txtEstadoNatural);
                }
                if (DPessoas.txtNacionalidade == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NACIONALIDADE", DPessoas.txtNacionalidade).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NACIONALIDADE", DPessoas.txtNacionalidade);
                }
                if (DPessoas.maskedtxtAltura == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ALTURA", DPessoas.maskedtxtAltura).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ALTURA", DPessoas.maskedtxtAltura);
                }
                if (DPessoas.maskedtxtPeso == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PESO", DPessoas.maskedtxtPeso).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PESO", DPessoas.maskedtxtPeso);
                }
                if (DPessoas.txtEmailNome == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@EMAIL", DPessoas.txtEmailNome).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@EMAIL", DPessoas.txtEmailNome);
                }
                if (DPessoas.txtEstadoCivil == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESTADO_CIVIL", DPessoas.txtEstadoCivil).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESTADO_CIVIL", DPessoas.txtEstadoCivil);
                }
                if (DPessoas.txtNomeJunto == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_JUNTO", DPessoas.txtNomeJunto).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_JUNTO", DPessoas.txtNomeJunto);
                }
                if (DPessoas.dateTimePickerNascimentoJunto == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_JUNTO", DPessoas.dateTimePickerNascimentoJunto).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_JUNTO", DPessoas.dateTimePickerNascimentoJunto);
                }
                if (DPessoas.txtNdependentes == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@N_DEPENDENTES", DPessoas.txtNdependentes).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@N_DEPENDENTES", DPessoas.txtNdependentes);
                }
                if (DPessoas.txtNFilhos == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@N_FILHOS", DPessoas.txtNFilhos).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@N_FILHOS", DPessoas.txtNFilhos);
                }
                if (DPessoas.txtIdadeFilhos == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@IDADE_FILHOS", DPessoas.txtIdadeFilhos).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IDADE_FILHOS", DPessoas.txtIdadeFilhos);
                }
                if (DPessoas.txtNomePai == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_PAI", DPessoas.txtNomePai).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_PAI", DPessoas.txtNomePai);
                }
                if (DPessoas.radioButtonPSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESTADO_PAI", DPessoas.radioButtonPSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESTADO_PAI", DPessoas.radioButtonPSN);
                }
                if (DPessoas.dateTimePickerNascimentoPai == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_PAI", DPessoas.dateTimePickerNascimentoPai).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_PAI", DPessoas.dateTimePickerNascimentoPai);
                }
                if (DPessoas.txtNomeMae == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_MAE", DPessoas.txtNomeMae).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_MAE", DPessoas.txtNomeMae);
                }
                if (DPessoas.radioButtonMVS == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESTADO_MAE", DPessoas.radioButtonMVS).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESTADO_MAE", DPessoas.radioButtonMVS);
                }
                if (DPessoas.dateTimePickerNascimentoMae == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_MAE", DPessoas.dateTimePickerNascimentoMae).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_MAE", DPessoas.dateTimePickerNascimentoMae);

                }
                if (DPessoas.ID_Cliente_MS == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", DPessoas.ID_Cliente_MS).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", DPessoas.ID_Cliente_MS);

                }
                if (DPessoas.SituacaoCriminal == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@SITUACAO_CRIMINAL", DPessoas.SituacaoCriminal).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SITUACAO_CRIMINAL", DPessoas.SituacaoCriminal);
                }
                if (DPessoas.IdProfissao == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PROFISSAO", DPessoas.IdProfissao).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PROFISSAO", DPessoas.IdProfissao);
                }
                if (DPessoas.StatusMercado == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@STATUS_MERCADO", DPessoas.StatusMercado).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@STATUS_MERCADO", DPessoas.StatusMercado);
                }
                if (DPessoas.IdPessoaLogada == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_LOGADA", DPessoas.IdPessoaLogada).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_LOGADA", DPessoas.IdPessoaLogada);
                }

                objConexao.Conectar();
                cmd.ExecuteNonQuery();
                objConexao.Desconectar();

            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void UpdateCepPessoa(DadosPessoas PPessoasCep)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;
                cmd.CommandText = "exec RH_P_CepPessoaUpdate @ID_CEP_PESSOA,@CEP,@TIPO_LOGRADOURO,@ENDERECO," +
                    "@NUMERO,@COMPLEMENTO,@BAIRRO,@CIDADE,@SIGLA,@ESTADO; ";
                if (PPessoasCep.Id_DadosPessoas == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_CEP_PESSOA", PPessoasCep.Id_DadosPessoas).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_CEP_PESSOA", PPessoasCep.Id_DadosPessoas);
                }

                if (PPessoasCep.maskedTextBoxCep == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CEP", PPessoasCep.maskedTextBoxCep).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CEP", PPessoasCep.maskedTextBoxCep);
                }
                if (PPessoasCep.txtLogradouroNome == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@TIPO_LOGRADOURO", PPessoasCep.txtLogradouroNome).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TIPO_LOGRADOURO", PPessoasCep.txtLogradouroNome);
                }
                if (PPessoasCep.txtEndereco == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ENDERECO", PPessoasCep.txtEndereco).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ENDERECO", PPessoasCep.txtEndereco);
                }
                if (PPessoasCep.txtNumero == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NUMERO", PPessoasCep.txtNumero).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NUMERO", PPessoasCep.txtNumero);
                }
                if (PPessoasCep.txtComplemento == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@COMPLEMENTO", PPessoasCep.txtComplemento).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@COMPLEMENTO", PPessoasCep.txtComplemento);
                }
                if (PPessoasCep.txtBairro == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@BAIRRO", PPessoasCep.txtBairro).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@BAIRRO", PPessoasCep.txtBairro);
                }
                if (PPessoasCep.txtCidadeNome == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CIDADE", PPessoasCep.txtCidadeNome).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CIDADE", PPessoasCep.txtCidadeNome);
                }
                if (PPessoasCep.txtSiglaNome == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@SIGLA", PPessoasCep.txtSiglaNome).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SIGLA", PPessoasCep.txtSiglaNome);
                }
                if (PPessoasCep.txtEstado == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESTADO", PPessoasCep.txtEstado).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESTADO", PPessoasCep.txtEstado);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void UpdateEscolaridade(Escolaridade PEscolaridade)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "EXEC RH_EscolaridadeUpdate	@ID_PESSOA_ESCOLARIDADE,@PRIMERI_GRAU,@SEGUND_GRAU,@SUPERIOR," +
                    "@CURSO,@ESTUDA_ATUALMENTE,@ESTUDA_CURSO,@ANO_CURSANDO,@BAIRRO_CURSANDO, @HORARIO_CURSANDO;";

                if (PEscolaridade.Id_PessoasEscolaridade == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_ESCOLARIDADE", PEscolaridade.Id_PessoasEscolaridade).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_ESCOLARIDADE", PEscolaridade.Id_PessoasEscolaridade);
                }
                if (PEscolaridade.radioButton1GN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PRIMERI_GRAU", PEscolaridade.radioButton1GN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PRIMERI_GRAU", PEscolaridade.radioButton1GN);
                }
                if (PEscolaridade.radioButton2GSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@SEGUND_GRAU", PEscolaridade.radioButton2GSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SEGUND_GRAU", PEscolaridade.radioButton2GSN);
                }
                if (PEscolaridade.radioButtonSSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@SUPERIOR", PEscolaridade.radioButtonSSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SUPERIOR", PEscolaridade.radioButtonSSN);
                }
                if (PEscolaridade.txtSuperiorCurso == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CURSO", PEscolaridade.txtSuperiorCurso).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CURSO", PEscolaridade.txtSuperiorCurso);
                }
                if (PEscolaridade.radioButtonESSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESTUDA_ATUALMENTE", PEscolaridade.radioButtonESSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESTUDA_ATUALMENTE", PEscolaridade.radioButtonESSN);
                }
                if (PEscolaridade.txtEstudaAtualmente == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESTUDA_CURSO", PEscolaridade.txtEstudaAtualmente).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESTUDA_CURSO", PEscolaridade.txtEstudaAtualmente);
                }
                if (PEscolaridade.txtAnoEstaCursando == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ANO_CURSANDO", PEscolaridade.txtAnoEstaCursando).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ANO_CURSANDO", PEscolaridade.txtAnoEstaCursando);
                }
                if (PEscolaridade.txtBairroCursando == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@BAIRRO_CURSANDO", PEscolaridade.txtBairroCursando).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@BAIRRO_CURSANDO", PEscolaridade.txtBairroCursando);
                }
                if (PEscolaridade.maskedTxtHorarioCursando == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@HORARIO_CURSANDO", PEscolaridade.maskedTxtHorarioCursando).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@HORARIO_CURSANDO", PEscolaridade.maskedTxtHorarioCursando);
                }

                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void UpdateProfissionais(Profissionais PProfissionais)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "EXEC RH_H_P_ProfisionalUpdate @ID_PESSOA_PROFISSIONAL,@DATA_VIGILANTE,@NOME_ACADEMIA,@DATA_RECICLAGEM,@NOME_ACADEMIA_RE," +
                                                             "@CURSO_PORTARIA,@ESCOLA_PORTARIA,@COMPUTACAO,@OUTROS_CURSOS,@QUAIS_CURSOS,@RADIO_HT; ";

                if (PProfissionais.Id_PessoasProfissional == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_PROFISSIONAL", PProfissionais.Id_PessoasProfissional).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_PROFISSIONAL", PProfissionais.Id_PessoasProfissional);
                }
                if (PProfissionais.dateTimePickerFormacaoVigilante == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_VIGILANTE", PProfissionais.dateTimePickerFormacaoVigilante).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_VIGILANTE", PProfissionais.dateTimePickerFormacaoVigilante);
                }
                if (PProfissionais.txtNomeAcademiaVigilante == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_ACADEMIA", PProfissionais.txtNomeAcademiaVigilante).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_ACADEMIA", PProfissionais.txtNomeAcademiaVigilante);
                }
                if (PProfissionais.dateTimePickerReciclagem == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_RECICLAGEM", PProfissionais.dateTimePickerReciclagem).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_RECICLAGEM", PProfissionais.dateTimePickerReciclagem);
                }
                if (PProfissionais.txtNomeAcademiaReciclagem == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_ACADEMIA_RE", PProfissionais.txtNomeAcademiaReciclagem).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_ACADEMIA_RE", PProfissionais.txtNomeAcademiaReciclagem);
                }
                if (PProfissionais.txtCursoPortaria == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CURSO_PORTARIA", PProfissionais.txtCursoPortaria).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CURSO_PORTARIA", PProfissionais.txtCursoPortaria);
                }
                if (PProfissionais.txtEscolaPortaria == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESCOLA_PORTARIA", PProfissionais.txtEscolaPortaria).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESCOLA_PORTARIA", PProfissionais.txtEscolaPortaria);
                }
                if (PProfissionais.radioButtonCSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@COMPUTACAO", PProfissionais.radioButtonCSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@COMPUTACAO", PProfissionais.radioButtonCSN);
                }
                if (PProfissionais.radioButtonOCSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@OUTROS_CURSOS", PProfissionais.radioButtonOCSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@OUTROS_CURSOS", PProfissionais.radioButtonOCSN);
                }
                if (PProfissionais.txtQuaisCursos == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@QUAIS_CURSOS", PProfissionais.txtQuaisCursos).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@QUAIS_CURSOS", PProfissionais.txtQuaisCursos);
                }
                if (PProfissionais.radioButtonRHSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@RADIO_HT", PProfissionais.radioButtonRHSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@RADIO_HT", PProfissionais.radioButtonRHSN);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void UpdateInformacoes(Informacoes PInformacoes)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "EXEC RH_P_InformacoesUpdate @ID_PESSOA_INFORMACOES,@FAZ_USO_ILICITAS,@ILICITAS_QUAIS," +
                                             "@FAZ_TRATAMENTO_MEDICO,@TRATAMENTO_MEDICO_QUAIS,@PERIODO_NOTURNO,@PRAZO_EXPERIENCIA," +
                                             "@ESCALA_REVERSAMENTO,@TRANFERIDO_BAIRRO,@CONHECE_ALGUEM_EMPRESA,@PARENTE,@NOME_PARENTE," +
                                             "@CARGO_PARENTE,@LOCAL_TRABALHA_PARENTE;";

                if (PInformacoes.Id_PessoasInformacoes == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_INFORMACOES", PInformacoes.Id_PessoasInformacoes).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_INFORMACOES", PInformacoes.Id_PessoasInformacoes);
                }
                if (PInformacoes.radioButtonFATISN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@FAZ_USO_ILICITAS", PInformacoes.radioButtonFATISN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@FAZ_USO_ILICITAS", PInformacoes.radioButtonFATISN);
                }
                if (PInformacoes.txtDrogasIlicitas == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ILICITAS_QUAIS", PInformacoes.txtDrogasIlicitas).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ILICITAS_QUAIS", PInformacoes.txtDrogasIlicitas);
                }
                if (PInformacoes.radioButtonFATMS == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@FAZ_TRATAMENTO_MEDICO", PInformacoes.radioButtonFATMS).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@FAZ_TRATAMENTO_MEDICO", PInformacoes.radioButtonFATMS);
                }
                if (PInformacoes.txtTratamentoMedico == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@TRATAMENTO_MEDICO_QUAIS", PInformacoes.txtTratamentoMedico).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TRATAMENTO_MEDICO_QUAIS", PInformacoes.txtTratamentoMedico);
                }
                if (PInformacoes.radioButtonPNSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PERIODO_NOTURNO", PInformacoes.radioButtonPNSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PERIODO_NOTURNO", PInformacoes.radioButtonPNSN);
                }
                if (PInformacoes.radioButtonPESN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PRAZO_EXPERIENCIA", PInformacoes.radioButtonPESN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PRAZO_EXPERIENCIA", PInformacoes.radioButtonPESN);
                }
                if (PInformacoes.radioButtonERSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESCALA_REVERSAMENTO", PInformacoes.radioButtonERSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESCALA_REVERSAMENTO", PInformacoes.radioButtonERSN);
                }
                if (PInformacoes.radioButtonTBSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@TRANFERIDO_BAIRRO", PInformacoes.radioButtonTBSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TRANFERIDO_BAIRRO", PInformacoes.radioButtonTBSN);
                }
                if (PInformacoes.radioButtonConheceAlguemSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CONHECE_ALGUEM_EMPRESA", PInformacoes.radioButtonConheceAlguemSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CONHECE_ALGUEM_EMPRESA", PInformacoes.radioButtonConheceAlguemSN);
                }
                if (PInformacoes.radioButtonParenteSN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PARENTE", PInformacoes.radioButtonParenteSN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PARENTE", PInformacoes.radioButtonParenteSN);
                }
                if (PInformacoes.txtNomeConhecidoEmpresa == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_PARENTE", PInformacoes.txtNomeConhecidoEmpresa).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_PARENTE", PInformacoes.txtNomeConhecidoEmpresa);
                }
                if (PInformacoes.txtCargoConhecidoEmpresa == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CARGO_PARENTE", PInformacoes.txtCargoConhecidoEmpresa).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CARGO_PARENTE", PInformacoes.txtCargoConhecidoEmpresa);
                }
                if (PInformacoes.txtTrabalhoConhecidoEmpresa == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@LOCAL_TRABALHA_PARENTE", PInformacoes.txtTrabalhoConhecidoEmpresa).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@LOCAL_TRABALHA_PARENTE", PInformacoes.txtTrabalhoConhecidoEmpresa);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void UpdateCConheceuEmpresa(Informacoes PInformacoes)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "EXEC RH_P_ConheceEmpresaUpdate @ID_PESSOA_CONHECE_EMPRESA,@PLAQUEIRA,@INDICACAO," +
                                        "@ESCOLA,@JORNAL,@OUTROS,@CONVOCADO;";

                if (PInformacoes.Id_PessoasInformacoes == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_CONHECE_EMPRESA", PInformacoes.Id_PessoasInformacoes).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_CONHECE_EMPRESA", PInformacoes.Id_PessoasInformacoes);
                }
                if (PInformacoes.checkBoxPlaqueira == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PLAQUEIRA", PInformacoes.checkBoxPlaqueira).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PLAQUEIRA", PInformacoes.checkBoxPlaqueira);
                }
                if (PInformacoes.checkBoxIndicacao == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@INDICACAO", PInformacoes.checkBoxIndicacao).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@INDICACAO", PInformacoes.checkBoxIndicacao);
                }
                if (PInformacoes.checkBoxEscola == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ESCOLA", PInformacoes.checkBoxEscola).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ESCOLA", PInformacoes.checkBoxEscola);
                }
                if (PInformacoes.checkBoxJornal == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@JORNAL", PInformacoes.checkBoxJornal).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@JORNAL", PInformacoes.checkBoxJornal);
                }
                if (PInformacoes.checkBoxOutros == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@OUTROS", PInformacoes.checkBoxOutros).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@OUTROS", PInformacoes.checkBoxOutros);
                }
                if (PInformacoes.checkBoxConvocado == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CONVOCADO", PInformacoes.checkBoxConvocado).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CONVOCADO", PInformacoes.checkBoxConvocado);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }

        public void UdpateCarteiraMotorista(Informacoes PInformacoes)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_P_CarteiraMotoristaUpdate @ID_PESSOA_CARTEIRA_MOTORISTA,@N_CNH,@DATA_VALIDADE,@CARTEIRA_A," +
                    "@CARTEIRA_B, @CARTEIRA_C,@CARTEIRA_D; ";

                if (PInformacoes.Id_PessoasInformacoes == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_CARTEIRA_MOTORISTA", PInformacoes.Id_PessoasInformacoes).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_CARTEIRA_MOTORISTA", PInformacoes.Id_PessoasInformacoes);
                }
                if (PInformacoes.txtNumeroCarteiraMotorista == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@N_CNH", PInformacoes.txtNumeroCarteiraMotorista).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@N_CNH", PInformacoes.txtNumeroCarteiraMotorista);
                }
                if (PInformacoes.dateTimePickerDataValidadeCMotorista == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_VALIDADE", PInformacoes.dateTimePickerDataValidadeCMotorista).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_VALIDADE", PInformacoes.dateTimePickerDataValidadeCMotorista);
                }
                if (PInformacoes.checkBoxCMA == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CARTEIRA_A", PInformacoes.checkBoxCMA).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CARTEIRA_A", PInformacoes.checkBoxCMA);
                }
                if (PInformacoes.checkBoxCMB == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CARTEIRA_B", PInformacoes.checkBoxCMB).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CARTEIRA_B", PInformacoes.checkBoxCMB);
                }
                if (PInformacoes.checkBoxCMC == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CARTEIRA_C", PInformacoes.checkBoxCMC).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CARTEIRA_C", PInformacoes.checkBoxCMC);
                }
                if (PInformacoes.checkBoxCMD == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CARTEIRA_D", PInformacoes.checkBoxCMD).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CARTEIRA_D", PInformacoes.checkBoxCMD);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        //public void UpdateCConheceuEmpresa(Informacoes PInformacoes)
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = objConexao.ObjetoConexao;
        //        cmd.CommandText = "exec RH_P_ConheceEmpresaInserir @ID_PESSOA_CONHECE_EMPRESA,@PLAQUEIRA,@INDICACAO,@ESCOLA," +
        //            "@JORNAL,@OUTROS,@CONVOCADO; ";

        //        if (PInformacoes.Id_PessoasInformacoes == 0)
        //        {
        //            // passa valor nulo para a tabela
        //            cmd.Parameters.AddWithValue("@ID_PESSOA_CONHECE_EMPRESA", PInformacoes.Id_PessoasInformacoes).Value = SqlBinary.Null;
        //        }
        //        else
        //        {
        //            cmd.Parameters.AddWithValue("@ID_PESSOA_CONHECE_EMPRESA", PInformacoes.Id_PessoasInformacoes);
        //        }
        //        if (PInformacoes.checkBoxPlaqueira == 0)
        //        {
        //            // passa valor nulo para a tabela
        //            cmd.Parameters.AddWithValue("@PLAQUEIRA", PInformacoes.checkBoxPlaqueira).Value = SqlBinary.Null;
        //        }
        //        else
        //        {
        //            cmd.Parameters.AddWithValue("@PLAQUEIRA", PInformacoes.checkBoxPlaqueira);
        //        }
        //        if (PInformacoes.checkBoxIndicacao == 0)
        //        {
        //            // passa valor nulo para a tabela
        //            cmd.Parameters.AddWithValue("@INDICACAO", PInformacoes.checkBoxIndicacao).Value = SqlBinary.Null;
        //        }
        //        else
        //        {
        //            cmd.Parameters.AddWithValue("@INDICACAO", PInformacoes.checkBoxIndicacao);
        //        }
        //        if (PInformacoes.checkBoxEscola == 0)
        //        {
        //            // passa valor nulo para a tabela
        //            cmd.Parameters.AddWithValue("@ESCOLA", PInformacoes.checkBoxEscola).Value = SqlBinary.Null;
        //        }
        //        else
        //        {
        //            cmd.Parameters.AddWithValue("@ESCOLA", PInformacoes.checkBoxEscola);
        //        }
        //        if (PInformacoes.checkBoxJornal == 0)
        //        {
        //            // passa valor nulo para a tabela
        //            cmd.Parameters.AddWithValue("@JORNAL", PInformacoes.checkBoxJornal).Value = SqlBinary.Null;
        //        }
        //        else
        //        {
        //            cmd.Parameters.AddWithValue("@JORNAL", PInformacoes.checkBoxJornal);
        //        }
        //        if (PInformacoes.checkBoxOutros == 0)
        //        {
        //            // passa valor nulo para a tabela
        //            cmd.Parameters.AddWithValue("@OUTROS", PInformacoes.checkBoxOutros).Value = SqlBinary.Null;
        //        }
        //        else
        //        {
        //            cmd.Parameters.AddWithValue("@OUTROS", PInformacoes.checkBoxOutros);
        //        }
        //        if (PInformacoes.checkBoxConvocado == 0)
        //        {
        //            // passa valor nulo para a tabela
        //            cmd.Parameters.AddWithValue("@CONVOCADO", PInformacoes.checkBoxConvocado).Value = SqlBinary.Null;
        //        }
        //        else
        //        {
        //            cmd.Parameters.AddWithValue("@CONVOCADO", PInformacoes.checkBoxConvocado);
        //        }

        //        objConexao.Conectar();
        //        cmd.ExecuteScalar();
        //        objConexao.Desconectar();
        //    }
        //    catch (SqlException ex)
        //    {
        //        for (int i = 0; i < ex.Errors.Count; i++)
        //        {
        //            errorMessages.Append("Index #" + i + "\n" +
        //                "Message: " + ex.Errors[i].Message + "\n" +
        //                "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
        //                "Source: " + ex.Errors[i].Source + "\n" +
        //                "Procedure: " + ex.Errors[i].Procedure + "\n");
        //        }
        //        Console.WriteLine(errorMessages.ToString());
        //    }

        //}
        public void UpdateProfissionais2(Profissional2 PProfissional2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_P_Profisional2Udpate @ID_PESSOA_PROFISSIONAL2,@ULTIMO_EMPREGO,@ULTIMO_CARGO,@ULTIMO_SALARIO," +
                    "@DATA_ENTRADA_ULTIMO,@DATA_SAIDA_ULTIMO,@NOME_FECHE_ULTIMO,@FONE_ULTIMO,@MOTIVO_ULTIMO,@PENULTIMO_EMPREGO,@PENULTIMO_CARGO," +
                    "@PENULTIMO_SALARIO,@DATA_ENTRADA_PENULTIMO,@DATA_SAIDA_PENULTIMO,@NOME_FECHE_PENULTIMO,@FONE_PENULTIMO,@MOTIVO_PENULTIMO," +
                    "@ANTEPENULTIMO_EMPREGO,@ANTEPENULTIMO_CARGO,@ANTEPENULTIMO_SALARIO,@DATA_ENTRADA_ANTEPENULTIMO,@DATA_SAIDA_ANTEPENULTIMO," +
                    "@NOME_FECHE_ANTEPENULTIMO,@FONE_ANTEPENULTIMO,@MOTIVO_ANTEPENULTIMO;";


                if (PProfissional2.Id_PessoaProfissional2 == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_PROFISSIONAL2", PProfissional2.Id_PessoaProfissional2).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_PROFISSIONAL2", PProfissional2.Id_PessoaProfissional2);
                }
                if (PProfissional2.txtUltimoEmprego == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ULTIMO_EMPREGO", PProfissional2.txtUltimoEmprego).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ULTIMO_EMPREGO", PProfissional2.txtUltimoEmprego);
                }
                if (PProfissional2.txtUltimoCargo == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ULTIMO_CARGO", PProfissional2.txtUltimoCargo).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ULTIMO_CARGO", PProfissional2.txtUltimoCargo);
                }
                if (PProfissional2.txtUltimoSalario == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ULTIMO_SALARIO", PProfissional2.txtUltimoSalario).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ULTIMO_SALARIO", PProfissional2.txtUltimoSalario);
                }
                if (PProfissional2.dateTimePickerUltimaEntrada == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_ENTRADA_ULTIMO", PProfissional2.dateTimePickerUltimaEntrada).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_ENTRADA_ULTIMO", PProfissional2.dateTimePickerUltimaEntrada);
                }
                if (PProfissional2.dateTimePickerUltimaSaida == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_SAIDA_ULTIMO", PProfissional2.dateTimePickerUltimaSaida).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_SAIDA_ULTIMO", PProfissional2.dateTimePickerUltimaSaida);
                }
                if (PProfissional2.txtNomeUltimoChefe == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_FECHE_ULTIMO", PProfissional2.txtNomeUltimoChefe).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_FECHE_ULTIMO", PProfissional2.txtNomeUltimoChefe);
                }
                if (PProfissional2.maskedtxtTelefoneUltimoEmprego == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@FONE_ULTIMO", PProfissional2.maskedtxtTelefoneUltimoEmprego).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@FONE_ULTIMO", PProfissional2.maskedtxtTelefoneUltimoEmprego);
                }
                if (PProfissional2.txtMotivoSaidaUltimoEmprego == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@MOTIVO_ULTIMO", PProfissional2.txtMotivoSaidaUltimoEmprego).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MOTIVO_ULTIMO", PProfissional2.txtMotivoSaidaUltimoEmprego);
                }
                if (PProfissional2.txtPenultimoEmprego == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PENULTIMO_EMPREGO", PProfissional2.txtPenultimoEmprego).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PENULTIMO_EMPREGO", PProfissional2.txtPenultimoEmprego);
                }
                if (PProfissional2.txtPenultimoCargo == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PENULTIMO_CARGO", PProfissional2.txtPenultimoCargo).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PENULTIMO_CARGO", PProfissional2.txtPenultimoCargo);
                }
                if (PProfissional2.txtPenultimoSalario == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PENULTIMO_SALARIO", PProfissional2.txtPenultimoSalario).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PENULTIMO_SALARIO", PProfissional2.txtPenultimoSalario);
                }
                if (PProfissional2.dateTimePickerPenultimaEntrada == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_ENTRADA_PENULTIMO", PProfissional2.dateTimePickerPenultimaEntrada).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_ENTRADA_PENULTIMO", PProfissional2.dateTimePickerPenultimaEntrada);
                }
                if (PProfissional2.dateTimePickerPenultimaSaida == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_SAIDA_PENULTIMO", PProfissional2.dateTimePickerPenultimaSaida).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_SAIDA_PENULTIMO", PProfissional2.dateTimePickerPenultimaSaida);
                }
                if (PProfissional2.txtNomePenultimoChefe == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_FECHE_PENULTIMO", PProfissional2.txtNomePenultimoChefe).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_FECHE_PENULTIMO", PProfissional2.txtNomePenultimoChefe);
                }
                if (PProfissional2.maskedtxtTelefonePenultimoEmprego == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@FONE_PENULTIMO", PProfissional2.maskedtxtTelefonePenultimoEmprego).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@FONE_PENULTIMO", PProfissional2.maskedtxtTelefonePenultimoEmprego);
                }
                if (PProfissional2.txtMotivoSaidaPenultimoEmprego == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@MOTIVO_PENULTIMO", PProfissional2.txtMotivoSaidaPenultimoEmprego).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MOTIVO_PENULTIMO", PProfissional2.txtMotivoSaidaPenultimoEmprego);
                }
                if (PProfissional2.txtAntepenultimoEmprego == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ANTEPENULTIMO_EMPREGO", PProfissional2.txtAntepenultimoEmprego).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ANTEPENULTIMO_EMPREGO", PProfissional2.txtAntepenultimoEmprego);
                }
                if (PProfissional2.txtAntepenultimoCargo == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ANTEPENULTIMO_CARGO", PProfissional2.txtAntepenultimoCargo).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ANTEPENULTIMO_CARGO", PProfissional2.txtAntepenultimoCargo);
                }
                if (PProfissional2.txtAntepenultimoSalario == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ANTEPENULTIMO_SALARIO", PProfissional2.txtAntepenultimoSalario).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ANTEPENULTIMO_SALARIO", PProfissional2.txtAntepenultimoSalario);
                }
                if (PProfissional2.dateTimePickerAntepenultimoEntrada == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_ENTRADA_ANTEPENULTIMO", PProfissional2.dateTimePickerAntepenultimoEntrada).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_ENTRADA_ANTEPENULTIMO", PProfissional2.dateTimePickerAntepenultimoEntrada);
                }
                if (PProfissional2.dateTimePickerAntepenultimoSaida == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_SAIDA_ANTEPENULTIMO", PProfissional2.dateTimePickerAntepenultimoSaida).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_SAIDA_ANTEPENULTIMO", PProfissional2.dateTimePickerAntepenultimoSaida);
                }
                if (PProfissional2.txtNomeAntepenultimoChefe == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME_FECHE_ANTEPENULTIMO", PProfissional2.txtNomeAntepenultimoChefe).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_FECHE_ANTEPENULTIMO", PProfissional2.txtNomeAntepenultimoChefe);
                }
                if (PProfissional2.maskedtxtTelefoneAntepenultimoEmprego == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@FONE_ANTEPENULTIMO", PProfissional2.maskedtxtTelefoneAntepenultimoEmprego).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@FONE_ANTEPENULTIMO", PProfissional2.maskedtxtTelefoneAntepenultimoEmprego);
                }
                if (PProfissional2.txtMotivoSaidaAntepenultimoEmprego == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@MOTIVO_ANTEPENULTIMO", PProfissional2.txtMotivoSaidaAntepenultimoEmprego).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MOTIVO_ANTEPENULTIMO", PProfissional2.txtMotivoSaidaAntepenultimoEmprego);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void UpdateRecrutamentoSelecao(Profissional2 PProfissional2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_P_RecrutamentoSelecaoUpdate @ID_PESSOA_RECRUTAMENTO,@NOME;";


                if (PProfissional2.Id_PessoaProfissional2 == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_RECRUTAMENTO", PProfissional2.Id_PessoaProfissional2).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_RECRUTAMENTO", PProfissional2.Id_PessoaProfissional2);
                }
                if (PProfissional2.txtRecutamentoSelecao == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME", PProfissional2.txtRecutamentoSelecao).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME", PProfissional2.txtRecutamentoSelecao);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void UpdateAvaliacaoTecnica(Avaliacao PAvaliacao)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_P_AvaliacaoTecnicaUpdate @ID_PESSOA_AVALIACAO,@PARECER_APROVADO,@ENTREVISTADO_APROVADO," +
                                "@COMENTARIO_APROVADO,@PARECER_APROVEITAMENTO,@ENTREVISTADO_APROVEITAMENTO,@COMENTARIO_APROVEITAMENTO," +
                                "@DATA_AVALIACAO,@MS; ";


                if (PAvaliacao.Id_PessoasAvaliacao == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_AVALIACAO", PAvaliacao.Id_PessoasAvaliacao).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_AVALIACAO", PAvaliacao.Id_PessoasAvaliacao);
                }
                if (PAvaliacao.radioButtonPASN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PARECER_APROVADO", PAvaliacao.radioButtonPASN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PARECER_APROVADO", PAvaliacao.radioButtonPASN);
                }
                if (PAvaliacao.txtEntrevistadoAprovado == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ENTREVISTADO_APROVADO", PAvaliacao.txtEntrevistadoAprovado).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ENTREVISTADO_APROVADO", PAvaliacao.txtEntrevistadoAprovado);
                }
                if (PAvaliacao.txtComentariosAprovado == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@COMENTARIO_APROVADO", PAvaliacao.txtComentariosAprovado).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@COMENTARIO_APROVADO", PAvaliacao.txtComentariosAprovado);
                }
                if (PAvaliacao.radioButtonPFASN == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PARECER_APROVEITAMENTO", PAvaliacao.radioButtonPFASN).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PARECER_APROVEITAMENTO", PAvaliacao.radioButtonPFASN);
                }
                if (PAvaliacao.txtEntrevistadoAproveitamento == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ENTREVISTADO_APROVEITAMENTO", PAvaliacao.txtEntrevistadoAproveitamento).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ENTREVISTADO_APROVEITAMENTO", PAvaliacao.txtEntrevistadoAproveitamento);
                }
                if (PAvaliacao.txtComentariosEntrevistado == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@COMENTARIO_APROVEITAMENTO", PAvaliacao.txtComentariosEntrevistado).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@COMENTARIO_APROVEITAMENTO", PAvaliacao.txtComentariosEntrevistado);
                }
                if (PAvaliacao.dateTimePickerDataTreinamentoAvaliacao == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_AVALIACAO", PAvaliacao.dateTimePickerDataTreinamentoAvaliacao).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_AVALIACAO", PAvaliacao.dateTimePickerDataTreinamentoAvaliacao);
                }
                if (PAvaliacao.txtMSAvaliacao == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@MS", PAvaliacao.txtMSAvaliacao).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MS", PAvaliacao.txtMSAvaliacao);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void UpdateExEmpregado(ExEmpregado PExEmpregado)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_P_ExEmpregadoUpdate @ID_PESSOA_EMPREGADO,@NOME,@EX_FUNCIONARIO,@QUAL_POSTO,@DATA_ADMISSAO," +
                    "@DATA_DEMISSAO,@SUPERVISOR,@MOTIVO_SAIDA,@RE,@TREINAMENTOINFORME;";


                if (PExEmpregado.Id_PessoasExEmpregado == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_EMPREGADO", PExEmpregado.Id_PessoasExEmpregado).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_EMPREGADO", PExEmpregado.Id_PessoasExEmpregado);
                }
                if (PExEmpregado.txtNomeEmpregado == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@NOME", PExEmpregado.txtNomeEmpregado).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME", PExEmpregado.txtNomeEmpregado);
                }
                if (PExEmpregado.radioButtonJTEMSS == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@EX_FUNCIONARIO", PExEmpregado.radioButtonJTEMSS).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@EX_FUNCIONARIO", PExEmpregado.radioButtonJTEMSS);
                }
                if (PExEmpregado.txtQualPosto == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@QUAL_POSTO", PExEmpregado.txtQualPosto).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@QUAL_POSTO", PExEmpregado.txtQualPosto);
                }
                if (PExEmpregado.dateTimePickerAdmissaoEmpregado == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_ADMISSAO", PExEmpregado.dateTimePickerAdmissaoEmpregado).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_ADMISSAO", PExEmpregado.dateTimePickerAdmissaoEmpregado);
                }
                if (PExEmpregado.dateTimePickerDemissaoEmpregado == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DATA_DEMISSAO", PExEmpregado.dateTimePickerDemissaoEmpregado).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DATA_DEMISSAO", PExEmpregado.dateTimePickerDemissaoEmpregado);
                }
                if (PExEmpregado.txtQuemSupervisor == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@SUPERVISOR", PExEmpregado.txtQuemSupervisor).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SUPERVISOR", PExEmpregado.txtQuemSupervisor);
                }
                if (PExEmpregado.txtMotivoSaida == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@MOTIVO_SAIDA", PExEmpregado.txtMotivoSaida).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MOTIVO_SAIDA", PExEmpregado.txtMotivoSaida);
                }
                if (PExEmpregado.txtREEmpregado == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@RE", PExEmpregado.txtREEmpregado).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@RE", PExEmpregado.txtREEmpregado);
                }
                if (PExEmpregado.txtTreinamentoInforme == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@TREINAMENTOINFORME", PExEmpregado.txtTreinamentoInforme).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TREINAMENTOINFORME", PExEmpregado.txtTreinamentoInforme);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }

        }
        public void UpdateRedacao(ExEmpregado PExEmpregado)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_P_RedacaoUpdate @ID_PESSOA_EMPREGADO,@REDACAO;";


                if (PExEmpregado.Id_PessoasExEmpregado == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_EMPREGADO", PExEmpregado.Id_PessoasExEmpregado).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_EMPREGADO", PExEmpregado.Id_PessoasExEmpregado);
                }
                if (PExEmpregado.txtRedacao == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@REDACAO", PExEmpregado.txtRedacao).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@REDACAO", PExEmpregado.txtRedacao);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void UpdatePassagemCriminal(PassagemCriminal PPassagemCriminal)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_P_PassagemCriminalUpdate @ID_PASSAGEM_CRIMINAL,@COMENTARIO;";


                if (PPassagemCriminal.Id_PessoasPassagemCriminal == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PASSAGEM_CRIMINAL", PPassagemCriminal.Id_PessoasPassagemCriminal).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PASSAGEM_CRIMINAL", PPassagemCriminal.Id_PessoasPassagemCriminal);
                }
                if (PPassagemCriminal.txtComentarios == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@COMENTARIO", PPassagemCriminal.txtComentarios).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@COMENTARIO", PPassagemCriminal.txtComentarios);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void UpdateEstabilidade(DadosPessoas PPessoa)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_P_EstabilidadePessoaUpdate @ID_ESTABILIDADE_PESSOA,@ID_ESTABILIDADE,@COMENTARIO; ";


                if (PPessoa.Id_DadosPessoas == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_ESTABILIDADE_PESSOA", PPessoa.Id_DadosPessoas).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_ESTABILIDADE_PESSOA", PPessoa.Id_DadosPessoas);
                }
                if (PPessoa.Id_Estabilidade == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_ESTABILIDADE", PPessoa.Id_Estabilidade).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_ESTABILIDADE", PPessoa.Id_Estabilidade);
                }
                if (PPessoa.ComentarioEstabilidade == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@COMENTARIO", PPessoa.ComentarioEstabilidade).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@COMENTARIO", PPessoa.ComentarioEstabilidade);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void UpdateCadastraEmpresaCliente(CadastroEmpresaCliente CadastroEmpresaClienteC)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_CadastraEmpresaClienteUpdate @ID_CADASTRA_EMPRESA_CLIENTE,@NOME_EMPRESA,@ENDERECO,@MS,@STATUS_ATIVO,@COMENTARIO; ";

                if (CadastroEmpresaClienteC.IdCadastroEmpresaCliente == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_CADASTRA_EMPRESA_CLIENTE", CadastroEmpresaClienteC.IdCadastroEmpresaCliente).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_CADASTRA_EMPRESA_CLIENTE", CadastroEmpresaClienteC.IdCadastroEmpresaCliente);
                }
                if (CadastroEmpresaClienteC.NomeEmpresa == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_CADASTRA_EMPRESA_CLIENTE", CadastroEmpresaClienteC.NomeEmpresa).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME_EMPRESA", CadastroEmpresaClienteC.NomeEmpresa);
                }
                if (CadastroEmpresaClienteC.Endereco == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ENDERECO", CadastroEmpresaClienteC.Endereco).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ENDERECO", CadastroEmpresaClienteC.Endereco);
                }
                if (CadastroEmpresaClienteC.Ms == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@MS", CadastroEmpresaClienteC.Ms).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MS", CadastroEmpresaClienteC.Ms);
                }
                if (CadastroEmpresaClienteC.StatusAtivo == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@STATUS_ATIVO", CadastroEmpresaClienteC.StatusAtivo).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@STATUS_ATIVO", CadastroEmpresaClienteC.StatusAtivo);
                }
                if (CadastroEmpresaClienteC.Comentario == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@COMENTARIO", CadastroEmpresaClienteC.Comentario).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@COMENTARIO", CadastroEmpresaClienteC.Comentario);
                }
                objConexao.Conectar();
                cmd.ExecuteScalar();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void UpdateProcessoSeletivoP(ProcessoSeletivo ProcessoSeletivoP)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_P_ProcessoSeletivoPUpdate @ID_PROCESSO_SELETIVO,@COMENTARIO,@QUANT_VAGAS,@ID_PESSOA_LOGADA_ALTERADA; ";
                if (ProcessoSeletivoP.IdProcessoSeletivo == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PROCESSO_SELETIVO", ProcessoSeletivoP.IdProcessoSeletivo).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PROCESSO_SELETIVO", ProcessoSeletivoP.IdProcessoSeletivo);
                }
                if (ProcessoSeletivoP.txtComentatario == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@COMENTARIO", ProcessoSeletivoP.txtComentatario).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@COMENTARIO", ProcessoSeletivoP.txtComentatario);
                }
                if (ProcessoSeletivoP.txtQuantVagas == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@QUANT_VAGAS", ProcessoSeletivoP.txtQuantVagas).Value = SqlString.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@QUANT_VAGAS", ProcessoSeletivoP.txtQuantVagas);
                }
                if (ProcessoSeletivoP.Id_PessoaLogadaAlterada == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA_LOGADA_ALTERADA", ProcessoSeletivoP.Id_PessoaLogadaAlterada).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA_LOGADA_ALTERADA", ProcessoSeletivoP.Id_PessoaLogadaAlterada);
                }

                objConexao.Conectar();
                cmd.ExecuteNonQuery();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            { 
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void UpdateStatusProcessoSeletivoP(ProcessoSeletivo ProcessoSeletivoP)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_P_StatusProcessoSeletivoPUpdate @ID_PROCESSO_SELETIVO,@STATUS_ATIVO; ";
                if (ProcessoSeletivoP.IdProcessoSeletivo == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PROCESSO_SELETIVO", ProcessoSeletivoP.IdProcessoSeletivo).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PROCESSO_SELETIVO", ProcessoSeletivoP.IdProcessoSeletivo);
                }
                if (ProcessoSeletivoP.checkBoxStatusAtivo == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@STATUS_ATIVO", ProcessoSeletivoP.checkBoxStatusAtivo).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@STATUS_ATIVO", ProcessoSeletivoP.checkBoxStatusAtivo);
                }

                objConexao.Conectar();
                cmd.ExecuteNonQuery();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            { 
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void UpdateStatusPessoaFicha(DadosPessoas DadosPessoasP)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_StatusMercadoUpdate @ID_PESSOA,@STATUS_MERCADO;";
                if (DadosPessoasP.Id_DadosPessoas == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PESSOA", DadosPessoasP.Id_DadosPessoas).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PESSOA", DadosPessoasP.Id_DadosPessoas);
                }
                if (DadosPessoasP.StatusMercado == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@STATUS_MERCADO", DadosPessoasP.StatusMercado).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@STATUS_MERCADO", DadosPessoasP.StatusMercado);
                }

                objConexao.Conectar();
                cmd.ExecuteNonQuery();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            { 
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void UpdateStatusProcessoFinalizado(ProcessoSeletivo ProcessoSeletivoP)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_P_StatusProcessoSeletivoFinalizadoPUpdate @ID_PROCESSO_SELETIVO,@STATUS_FINALIZADO;";
                if (ProcessoSeletivoP.IdProcessoSeletivo == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PROCESSO_SELETIVO", ProcessoSeletivoP.IdProcessoSeletivo).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PROCESSO_SELETIVO", ProcessoSeletivoP.IdProcessoSeletivo);
                }
                if (ProcessoSeletivoP.checkBoxStatusFinalizacao == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@STATUS_FINALIZADO", ProcessoSeletivoP.checkBoxStatusFinalizacao).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@STATUS_FINALIZADO", ProcessoSeletivoP.checkBoxStatusFinalizacao);
                }

                objConexao.Conectar();
                cmd.ExecuteNonQuery();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            { 
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }

        //Excluir informação de ProcessoSeletivo---------------------------------------------------------------------------------------------------------------------------------
        public void ExcluirProcessoSeletivoP(ProcessoSeletivo ProcessoSeletivoP)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec RH_P_CandidatosPSeletivoRemover @ID_PROCESSO_SELETIVO; ";
                if (ProcessoSeletivoP.IdProcessoSeletivo == 0)
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ID_PROCESSO_SELETIVO", ProcessoSeletivoP.IdProcessoSeletivo).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ID_PROCESSO_SELETIVO", ProcessoSeletivoP.IdProcessoSeletivo);
                }

                objConexao.Conectar();
                cmd.ExecuteNonQuery();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            { 
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void AlterarFichaImagem(FichaImagem Imagem)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                //transacao = objConexao.ObjetoConexao.BeginTransaction("");

                cmd.CommandText = "EXEC RH_FichaImagemUpdate @IdFicha,@Imagem,@IdLoginUsuario;";

                cmd.Parameters.AddWithValue("@IdFicha", Imagem.IdFicha);
                cmd.Parameters.AddWithValue("@Imagem", Imagem.Imagem);
                cmd.Parameters.AddWithValue("@IdLoginUsuario", Imagem.IdLoginUsuario);

                objConexao.Conectar();
                cmd.ExecuteNonQuery();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
        public void TelaPrincipalNovasAtualizacoesTexto(TelaPrincipalNovaAtualizacaoTexto TPNA)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "exec U_TelaPrincipalNovasAtualizacoesTextoUpdate @idUsuario,@AtualizacaoTelaPrincipal;";
                cmd.Parameters.AddWithValue("@idUsuario", TPNA.idUsuario);
                cmd.Parameters.AddWithValue("@AtualizacaoTelaPrincipal", TPNA.AtualizacaoTelaPrincipal);

                objConexao.Conectar();
                cmd.ExecuteNonQuery();
                objConexao.Desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }
    }
}
//try
//{

//}
//catch (SqlException ex)
//{
//    for (int i = 0; i<ex.Errors.Count; i++)
//    {
//        errorMessages.Append("Index #" + i + "\n" +
//            "Message: " + ex.Errors[i].Message + "\n" +
//            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
//            "Source: " + ex.Errors[i].Source + "\n" +
//            "Procedure: " + ex.Errors[i].Procedure + "\n");
//    }
//    Console.WriteLine(errorMessages.ToString());
//}


//public void AlterarClienteFIsica(PessoaFisica Fisica)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "EXEC D_PessoaFisicaUpdate @idPessoaFisica,@Celular,@Celular2; ";
//    cmd.Parameters.AddWithValue("@idPessoaFisica", Fisica.idPessoaFisica);
//    if (Fisica.Celular == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular", Fisica.Celular).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular", Fisica.Celular);
//    }
//    if (Fisica.Celular2 == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular2", Fisica.Celular2).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular2", Fisica.Celular2);
//    }
//    objConexao.Conectar();
//    cmd.ExecuteNonQuery();
//    objConexao.Desconectar();

//}
//public void AlterarClienteJuridica(PessoaJuridica Juridica)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "EXEC D_PessoaJuridicaUpdate @idPessoaJuridica,@NomeContato; ";

//    cmd.Parameters.AddWithValue("@idPessoaJuridica", Juridica.idPessoaJuridica);
//    cmd.Parameters.AddWithValue("@NomeContato", Juridica.NomeContato);

//    objConexao.Conectar();
//    cmd.ExecuteNonQuery();
//    objConexao.Desconectar();


//}

////Excluir Informação de Cadastra Fisica e Juridica

//public void ExcluirClienteFisico(int IdCliente)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "DELETE FROM [dbo].[P_Cliente] WHERE ID_CLIENTE_PESSOA = @idPessoa;";
//    cmd.Parameters.AddWithValue("@idPessoa", IdCliente);

//    objConexao.Conectar();
//    cmd.ExecuteNonQuery();
//    objConexao.Desconectar();

//    SqlCommand cmd1 = new SqlCommand();
//    cmd1.Connection = objConexao.ObjetoConexao;

//    cmd1.CommandText = "DELETE FROM [dbo].[P_Fisica] WHERE ID_PESSOA_FISICA = @idPessoa;";

//    cmd1.Parameters.AddWithValue("@idPessoa", IdCliente);

//    objConexao.Conectar();
//    cmd1.ExecuteNonQuery();
//    objConexao.Desconectar();

//    SqlCommand cmd2 = new SqlCommand();
//    cmd2.Connection = objConexao.ObjetoConexao;

//    cmd2.CommandText = "DELETE FROM [dbo].[P_Pessoa] WHERE ID_PESSOA = @idPessoa;";

//    cmd2.Parameters.AddWithValue("@idPessoa", IdCliente);

//    objConexao.Conectar();
//    cmd2.ExecuteNonQuery();
//}
//public void ExcluirClienteJuridica(int Juridica)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "DELETE FROM [dbo].[P_Cliente] WHERE ID_CLIENTE_PESSOA = @idPessoa;";
//    cmd.Parameters.AddWithValue("@idPessoa", Juridica);

//    objConexao.Conectar();
//    cmd.ExecuteNonQuery();
//    objConexao.Desconectar();

//    SqlCommand cmd1 = new SqlCommand();
//    cmd1.Connection = objConexao.ObjetoConexao;

//    cmd1.CommandText = "DELETE FROM [dbo].[P_Juridica] WHERE ID_PESSOA_JURIDICA = @idPessoa;";

//    cmd1.Parameters.AddWithValue("@idPessoa", Juridica);

//    objConexao.Conectar();
//    cmd1.ExecuteNonQuery();
//    objConexao.Desconectar();

//    SqlCommand cmd2 = new SqlCommand();
//    cmd2.Connection = objConexao.ObjetoConexao;

//    cmd2.CommandText = "DELETE FROM [dbo].[P_Pessoa] WHERE ID_PESSOA = @idPessoa;";

//    cmd2.Parameters.AddWithValue("@idPessoa", Juridica);

//    objConexao.Conectar();
//    cmd2.ExecuteNonQuery();
//}
////----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////Base de Dados Fornecedor Fisica e Juridica. E tambem Cep
//public void IncluirF(Fornecedor Fornecedor)
//{

//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "EXEC D_PessoaFornecedorInserir @IdFornecedorPessoa, @NomeContato,@CargoContato ; ";

//    cmd.Parameters.AddWithValue("@IdFornecedorPessoa", Fornecedor.idFornecedor);

//    if (Fornecedor.NomeContato == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@NomeContato", Fornecedor.NomeContato).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@NomeContato", Fornecedor.NomeContato);
//    }

//    if (Fornecedor.CargoContato == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@CargoContato", Fornecedor.CargoContato).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@CargoContato", Fornecedor.CargoContato);
//    }

//    objConexao.Conectar();

//    cmd.ExecuteScalar();
//}

//public void AlterarFornecedorFIsica(FornecedorFisica Fisica)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "EXEC D_PessoaFisicaUpdate @idPessoaFisica,@Celular,@Celular2; ";
//    cmd.Parameters.AddWithValue("@idPessoaFisica", Fisica.idFornecedorFisica);
//    if (Fisica.Celular == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular", Fisica.Celular).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular", Fisica.Celular);
//    }
//    if (Fisica.Celular2 == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular2", Fisica.Celular2).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular2", Fisica.Celular2);
//    }
//    objConexao.Conectar();
//    cmd.ExecuteNonQuery();
//    objConexao.Desconectar();

//}
//public void AlterarFornecedorJuridica(FornecedorJuridica Juridica)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "EXEC D_PessoaJuridicaUpdate @idPessoaJuridica,@NomeContato; ";

//    cmd.Parameters.AddWithValue("@idPessoaJuridica", Juridica.idFornecedorJuridica);
//    cmd.Parameters.AddWithValue("@NomeContato", Juridica.NomeContato);

//    objConexao.Conectar();
//    cmd.ExecuteNonQuery();
//    objConexao.Desconectar();


//}

////Alterar Informação de Cadastra Fornecedor Fisica e Juridica------------------------------------------------------------------------------------------------------------------------------------

//public void AlterarF(Fornecedor cliente)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;
//    cmd.CommandText = "EXEC D_FornecedorUpdate @idPessoa,@NomeContato,@CargoContato " +
//    cmd.Parameters.AddWithValue("@idPessoa", cliente.idFornecedor);
//    if (cliente.NomeContato == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@NomeContato", cliente.NomeContato).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@NomeContato", cliente.NomeContato);
//    }
//    if (cliente.CargoContato == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@CargoContato", cliente.CargoContato).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@CargoContato", cliente.CargoContato);
//    }


//    objConexao.Conectar();

//    cmd.ExecuteNonQuery();

//    objConexao.Desconectar();

//}
//public void ExcluirFornecedorFisico(int Fisica)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "DELETE FROM [dbo].[P_Cliente] WHERE ID_CLIENTE_PESSOA = @idPessoa;";
//    cmd.Parameters.AddWithValue("@idPessoa", Fisica);

//    objConexao.Conectar();
//    cmd.ExecuteNonQuery();
//    objConexao.Desconectar();

//    SqlCommand cmd1 = new SqlCommand();
//    cmd1.Connection = objConexao.ObjetoConexao;

//    cmd1.CommandText = "DELETE FROM [dbo].[P_Fisica] WHERE ID_PESSOA_FISICA = @idPessoa;";

//    cmd1.Parameters.AddWithValue("@idPessoa", Fisica);

//    objConexao.Conectar();
//    cmd1.ExecuteNonQuery();
//    objConexao.Desconectar();

//    SqlCommand cmd2 = new SqlCommand();
//    cmd2.Connection = objConexao.ObjetoConexao;

//    cmd2.CommandText = "DELETE FROM [dbo].[P_Pessoa] WHERE ID_PESSOA = @idPessoa;";

//    cmd2.Parameters.AddWithValue("@idPessoa", Fisica);

//    objConexao.Conectar();
//    cmd2.ExecuteNonQuery();
//}
//public void ExcluirFornecedorJuridica(int Juridica)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "DELETE FROM [dbo].[P_Cliente] WHERE ID_CLIENTE_PESSOA = @idPessoa;";
//    cmd.Parameters.AddWithValue("@idPessoa", Juridica);

//    objConexao.Conectar();
//    cmd.ExecuteNonQuery();
//    objConexao.Desconectar();

//    SqlCommand cmd1 = new SqlCommand();
//    cmd1.Connection = objConexao.ObjetoConexao;

//    cmd1.CommandText = "DELETE FROM [dbo].[P_Juridica] WHERE ID_PESSOA_JURIDICA = @idPessoa;";

//    cmd1.Parameters.AddWithValue("@idPessoa", Juridica);

//    objConexao.Conectar();
//    cmd1.ExecuteNonQuery();
//    objConexao.Desconectar();

//    SqlCommand cmd2 = new SqlCommand();
//    cmd2.Connection = objConexao.ObjetoConexao;

//    cmd2.CommandText = "DELETE FROM [dbo].[P_Pessoa] WHERE ID_PESSOA = @idPessoa;";

//    cmd2.Parameters.AddWithValue("@idPessoa", Juridica);

//    objConexao.Conectar();
//    cmd2.ExecuteNonQuery();
//}
////Base de Dados Funcionario. E tambem Cep---------------------------------------------------------------------------------------------------------------------------
//public void IncluirUsuarioGeral(CadastraUsuario Usuario)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;
//    cmd.CommandText = "EXEC D_UsuarioGeralInserir @IdSituacao,@Nome,@SobreNome,@Abreviacao,@Telefone,@Telefone2,@Celular,@Celular2,@Email," +
//        "@Observacao,@Sexo,@Cpf,@Rg,@Data_Nascimento;select @@IDENTITY;";

//    cmd.Parameters.AddWithValue("@IdSituacao", Usuario.IdSituacao);
//    cmd.Parameters.AddWithValue("@Nome", Usuario.Nome);
//    cmd.Parameters.AddWithValue("@SobreNome", Usuario.SobreNome);
//    cmd.Parameters.AddWithValue("@Abreviacao", Usuario.Abreviacao);
//    if (Usuario.Telefone == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Telefone", Usuario.Telefone).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Telefone", Usuario.Telefone);
//    }
//    if (Usuario.Telefone2 == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Telefone2", Usuario.Telefone2).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Telefone2", Usuario.Telefone2);
//    }
//    if (Usuario.Celular == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular", Usuario.Celular).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular", Usuario.Celular);
//    }
//    if (Usuario.Celular2 == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular2", Usuario.Celular2).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular2", Usuario.Celular2);
//    }
//    if (Usuario.Email == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Email", Usuario.Email).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Email", Usuario.Email);
//    }
//    if (Usuario.Observacao == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Observacao", Usuario.Observacao).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Observacao", Usuario.Observacao);
//    }
//    if (Usuario.Sexo == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Sexo", Usuario.Sexo).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Sexo", Usuario.Sexo);
//    }
//    if (Usuario.Cpf == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Cpf", Usuario.Cpf).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Cpf", Usuario.Cpf);
//    }
//    if (Usuario.Rg == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Rg", Usuario.Rg).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Rg", Usuario.Rg);
//    }
//    if (Usuario.Data_Nascimento == null)
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Data_Nascimento", Usuario.Data_Nascimento).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Data_Nascimento", Usuario.Data_Nascimento);
//    }

//    objConexao.Conectar();

//    //cmd.ExecuteNonQuery();

//    Usuario.IdUsuario = Convert.ToInt32(cmd.ExecuteScalar());

//    objConexao.Desconectar();

//}

////Base de Dados Funcionario Os. ---------------------------------------------------------------------------------------------------------------------------
//public void IncluirFuncionarioOs(FuncionarioOS FuncionarioOs)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "EXEC D_FuncionarioOsInserir @IdFuncionario,@IdRe,@Abreviacao,@Telefone,@Telefone2,@Celular,@Celular2,@Email;";
//    cmd.Parameters.AddWithValue("@IdFuncionario", FuncionarioOs.IdFuncionario);
//    cmd.Parameters.AddWithValue("@IdRe", FuncionarioOs.IdRe);
//    if (FuncionarioOs.Abreviacao == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Abreviacao", FuncionarioOs.Abreviacao).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Abreviacao", FuncionarioOs.Abreviacao);
//    }
//    if (FuncionarioOs.Telefone == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Telefone", FuncionarioOs.Telefone).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Telefone", FuncionarioOs.Telefone);
//    }
//    if (FuncionarioOs.Telefone2 == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Telefone2", FuncionarioOs.Telefone2).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Telefone2", FuncionarioOs.Telefone2);
//    }
//    if (FuncionarioOs.Celular == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular", FuncionarioOs.Celular).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular", FuncionarioOs.Celular);
//    }
//    if (FuncionarioOs.Celular2 == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular2", FuncionarioOs.Celular2).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular2", FuncionarioOs.Celular2);
//    }
//    if (FuncionarioOs.Email == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Email", FuncionarioOs.Email).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Email", FuncionarioOs.Email);
//    }
//    objConexao.Conectar();
//    cmd.ExecuteScalar();
//    objConexao.Desconectar();
//}

////Base de Dados Funcionario Contratos. ---------------------------------------------------------------------------------------------------------------------------
//public void IncluirFuncionarioRegistro(FuncionarioRegistro FuncionarioRegistro)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "EXEC D_FuncionarioRegistroInserir @IdFuncionario,@IdRe,@Abreviacao,@Telefone,@Telefone2,@Celular,@Celular2,@Email;";
//    cmd.Parameters.AddWithValue("@IdFuncionario", FuncionarioRegistro.IdFuncionario);
//    cmd.Parameters.AddWithValue("@IdRe", FuncionarioRegistro.IdRe);
//    if (FuncionarioRegistro.Abreviacao == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Abreviacao", FuncionarioRegistro.Abreviacao).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Abreviacao", FuncionarioRegistro.Abreviacao);
//    }
//    if (FuncionarioRegistro.Telefone == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Telefone", FuncionarioRegistro.Telefone).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Telefone", FuncionarioRegistro.Telefone);
//    }
//    if (FuncionarioRegistro.Telefone2 == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Telefone2", FuncionarioRegistro.Telefone2).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Telefone2", FuncionarioRegistro.Telefone2);
//    }
//    if (FuncionarioRegistro.Celular == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular", FuncionarioRegistro.Celular).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular", FuncionarioRegistro.Celular);
//    }
//    if (FuncionarioRegistro.Celular2 == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular2", FuncionarioRegistro.Celular2).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular2", FuncionarioRegistro.Celular2);
//    }
//    if (FuncionarioRegistro.Email == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Email", FuncionarioRegistro.Email).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Email", FuncionarioRegistro.Email);
//    }
//    objConexao.Conectar();
//    cmd.ExecuteScalar();
//    objConexao.Desconectar();
//}
////Ceu do usuario em geral Se ele precisa
//public void UsuarioGeralCepInserir(CepCadastraUsuario cep)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "exec D_UsuarioGeralCepInserir @IdCep,@Cep,@TipoLogradouro,@Endereco,@Numero,@Complemento,@Bairro,@Cidade,@SiglaCidade;";

//    cmd.Parameters.AddWithValue("@IdCep", cep.idCep);
//    cmd.Parameters.AddWithValue("@Cep", cep.Cepc);

//    if (cep.TipoLogradouro == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@TipoLogradouro", cep.TipoLogradouro).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@TipoLogradouro", cep.TipoLogradouro);
//    }
//    if (cep.Endereco == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Endereco", cep.Endereco).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Endereco", cep.Endereco);
//    }
//    if (cep.Numero == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Numero", cep.Numero).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Numero", cep.Numero);
//    }
//    if (cep.Complemento == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Complemento", cep.Complemento).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Complemento", cep.Complemento);
//    }
//    if (cep.Bairro == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Bairro", cep.Bairro).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Bairro", cep.Bairro);
//    }
//    if (cep.Cidade == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Cidade", cep.Cidade).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Cidade", cep.Cidade);
//    }
//    if (cep.SiglaCidade == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@SiglaCidade", cep.SiglaCidade).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@SiglaCidade", cep.SiglaCidade);
//    }

//    objConexao.Conectar();
//    cmd.ExecuteScalar();
//    objConexao.Desconectar();
//}


//public void AlteraCepFuncionario(CepFEcs cep)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "exec D_FuncionarioCepUpdate @IdCep,@Complemento";

//    cmd.Parameters.AddWithValue("@IdCep", cep.idCep);
//    if (cep.Complemento == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Complemento", cep.Complemento).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Complemento", cep.Complemento);
//    }

//    objConexao.Conectar();
//    cmd.ExecuteScalar();
//}


////Excluir informação de Funcionario---------------------------------------------------------------------------------------------------------------------------------
//public void ExcluirFuncionario(int funcionario)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "DELETE FROM [dbo].[G_Cep] WHERE ID_CEP_PESSOA = @idPessoa;";
//    cmd.Parameters.AddWithValue("@idPessoa", funcionario);

//    objConexao.Conectar();
//    cmd.ExecuteNonQuery();
//    objConexao.Desconectar();

//    SqlCommand cmd1 = new SqlCommand();
//    cmd1.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "DELETE FROM [dbo].[G_Funcionario] WHERE ID_FUNCIONARIO = @idPessoa;";
//    cmd.Parameters.AddWithValue("@idPessoa", funcionario);

//    objConexao.Conectar();
//    cmd1.ExecuteNonQuery();
//    objConexao.Desconectar();

//}



////Fornecedores Clientes Contatos
////Base de Dados Funcionario. E tambem Cep---------------------------------------------------------------------------------------------------------------------------
//public void IncluirFContatos(FornecedorContatos cliente)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    //transacao = objConexao.ObjetoConexao.BeginTransaction("");

//    cmd.CommandText = "EXEC D_PessoaContatosInserir @idPessoa,@Situacao,@Nome,@Abreviacao, @Telefone,@Telefone2, @Celular,@Celular2,@Email,@Observacao;";

//    cmd.Parameters.AddWithValue("@idPessoa", cliente.IdFornecedor);
//    cmd.Parameters.AddWithValue("@Situacao", cliente.Situacao);
//    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
//    cmd.Parameters.AddWithValue("@Abreviacao", cliente.Abreviacao);
//    cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);

//    if (cliente.Telefone2 == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2);
//    }
//    if (cliente.Celular == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular", cliente.Celular).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
//    }
//    if (cliente.Celular2 == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular2", cliente.Celular2).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular2", cliente.Celular2);
//    }

//    cmd.Parameters.AddWithValue("@Email", cliente.Email);

//    if (cliente.Observacao == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao);
//    }

//    objConexao.Conectar();

//    cliente.IdContatof = Convert.ToInt32(cmd.ExecuteScalar());
//}



////Altera informação de Funcionario Contatos-------------------------------------------------------------------------------------------------------------------------
//public void AlterarFContatos(FornecedorContatos cliente)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "EXEC D_PessoaContatosUpdate @idPessoa,@Situacao,@Nome,@Abreviacao,@Telefone,@Telefone2,@Celular,@Celular,@Email,@Observacao; ";

//    cmd.Parameters.AddWithValue("@idPessoa", cliente.IdContatof);
//    cmd.Parameters.AddWithValue("@Situacao", cliente.Situacao);
//    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
//    cmd.Parameters.AddWithValue("@Abreviacao", cliente.Abreviacao);
//    cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);

//    if (cliente.Telefone2 == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2);
//    }
//    if (cliente.Celular == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular", cliente.Celular).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
//    }
//    if (cliente.Celular2 == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular2", cliente.Celular2).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular2", cliente.Celular2);
//    }
//    if (cliente.Email == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Email", cliente.Email).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Email", cliente.Email);
//    }
//    if (cliente.Observacao == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao);
//    }

//    objConexao.Conectar();

//    cmd.ExecuteNonQuery();

//    objConexao.Desconectar();
//}
////Excluir informação de Funcionario---------------------------------------------------------------------------------------------------------------------------------
//public void ExcluirFcontatos(int funcionario)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "DELETE FROM [dbo].[P_Contatos] WHERE ID_PESSOA_CONTATO = @idPessoa;";
//    cmd.Parameters.AddWithValue("@idPessoa", funcionario);

//    objConexao.Conectar();
//    cmd.ExecuteNonQuery();
//    objConexao.Desconectar();

//}

////Clientes Contatos
////Base de Dados Funcionario. E tambem Cep---------------------------------------------------------------------------------------------------------------------------
//public void IncluirCContatos(ClientesContatos cliente)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    //transacao = objConexao.ObjetoConexao.BeginTransaction("");

//    cmd.CommandText = "EXEC D_PessoaContatosInserir @idPessoa,@Situacao,@Nome,@Abreviacao, @Telefone,@Telefone2, @Celular,@Celular2,@Email,@Observacao;";

//    cmd.Parameters.AddWithValue("@idPessoa", cliente.IdContatof);
//    cmd.Parameters.AddWithValue("@Situacao", cliente.Situacao);
//    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
//    cmd.Parameters.AddWithValue("@Abreviacao", cliente.Abreviacao);
//    cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);

//    if (cliente.Telefone2 == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2);
//    }
//    if (cliente.Celular == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular", cliente.Celular).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
//    }
//    if (cliente.Celular2 == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular2", cliente.Celular2).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular2", cliente.Celular2);
//    }
//    if (cliente.Email == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Email", cliente.Email).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Email", cliente.Email);
//    }

//    if (cliente.Observacao == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao);
//    }


//    objConexao.Conectar();

//    cliente.IdFornecedor = Convert.ToInt32(cmd.ExecuteScalar());// numero da id Gerada Pelo sistema auto incrementa

//    //cliente.IdContatof = Convert.ToInt32(cmd.ExecuteScalar());
//}



////Altera informação de Funcionario Contatos-------------------------------------------------------------------------------------------------------------------------
//public void AlterarCContatos(ClientesContatos cliente)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "EXEC D_PessoaContatosUpdate @idPessoa,@Situacao,@Nome,@Abreviacao,@Telefone,@Telefone2,@Celular,@Celular2,@Email,@Observacao;";

//    cmd.Parameters.AddWithValue("@idPessoa", cliente.IdContatof);
//    cmd.Parameters.AddWithValue("@Situacao", cliente.Situacao);
//    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
//    cmd.Parameters.AddWithValue("@Abreviacao", cliente.Abreviacao);
//    cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);

//    if (cliente.Telefone2 == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2);
//    }
//    if (cliente.Celular == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular", cliente.Celular).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
//    }
//    if (cliente.Celular2 == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular2", cliente.Celular2).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular2", cliente.Celular2);
//    }
//    if (cliente.Email == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Email", cliente.Email).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Email", cliente.Email);
//    }
//    if (cliente.Observacao == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao);
//    }

//    objConexao.Conectar();

//    cmd.ExecuteNonQuery();

//    objConexao.Desconectar();
//}
////Excluir informação de Funcionario---------------------------------------------------------------------------------------------------------------------------------
//public void ExcluirCcontatos(int funcionario)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "DELETE FROM [dbo].[P_Contatos] WHERE ID_PESSOA_CONTATO = @idPessoa;";
//    cmd.Parameters.AddWithValue("@idPessoa", funcionario);

//    objConexao.Conectar();
//    cmd.ExecuteNonQuery();
//    objConexao.Desconectar();

//}

////Criacao de login dos usuarios

//public void IncluirLoginUsuario(CadastroLoginNovo Usuario)
//{

//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "EXEC D_LoginUsuarioInserir @IdCadastroLoginNovo, @Usuario, @Senha, @ConfirmaSenha, @UsuarioAcesso, @IdAcessoBaseDados," +
//        "@CriarDadosPessoas, @CriarFuncionarioOs, @CriarFuncionarioVendas, @CriarUsuarioAcesso," +
//        "@UsuarioCriar, @UsuarioAlterar, @UsuarioExcluir, @UsuarioPesquisa, @UsuarioVisualizar," +
//        "@ClienteCadastra, @ClientePesquisa, @ClienteVisualizar, @ClienteEditar, @ClienteExcluir," +
//        "@ClienteCCadastra, @ClienteCPesquisa, @ClienteCVisualizar, @ClienteCEditar, @ClienteCExcluir," +
//        "@FornecedorCadastra, @FornecedorPesquisa, @FornecedorVisualizar, @FornecedorEditar, @FornecedorExcluir," +
//        "@FornecedorCCadastra, @FornecedorCPesquisa, @FornecedorCVisualizar, @FornecedorCEditar, @FornecedorcExcluir," +
//        "@FuncionarioCadastra, @FuncionarioPesquisa, @FuncionarioVisualizar, @FuncionarioEditar, @FuncionarioExcluir," +
//        "@OsCadastra, @OsPesquisa, @OsVisualizar, @OsEditar, @OsExcluir," +
//        "@SeniorSapiensAcesso, @SeniorSapiensPesquisa, @SeniorSapiensExcluir," +
//        "@PermissaoBasedados, @PermissaoNivelaAcesso, @PermissaoCliente, @PermissaoFornecedor, @PermissaoFuncionarioOs, @PermissaoFuncionarioVendedor," +
//        "@PermissaoUsuarioAcesso, @PermissaoOs, @PermissaoSeniorSapiens," +
//        "@VendedorCadastra, @VendedorPesquisa, @VendedorVisualizar, @VendedorEditar, @VendedorExcluir, " +
//        "@ProdutosCadastra, @ProdutosVisualizar, @ProdutosPesquisa, @ProdutosEditar, @ProdutosExcluir," +
//        "@RegistroCCadastra, @RegistroCVisualizar, @RegistroCPesquisa, @RegistroCEditar, @RegistroCExcluir, " +
//        "@CriarFuncionarioProdutos, @CriarFuncionarioRegistro, @PermissaoRegistro, @PermissaoFuncionarioProdutos," +
//        "@RegistroCCCadastra, @RegistroCCVisualizar, @RegistroCCPesquisa, @RegistroCCEditar,@RegistroCCExcluir," +
//        "@RegistroCadastra, @RegistroVisualizar, @RegistroPesquisa, @RegistroEditar, @RegistroExcluir," +
//        "@PropostaCadastra, @PropostaVisualizar, @PropostaPesquisa, @PropostaEditar, @PropostaExcluir," +
//        "@CriarProposta, @PermissaoProposta,@AtualicazaoTelaPrincipal,@VerificadorOs;";

//    cmd.Parameters.AddWithValue("@IdCadastroLoginNovo", Usuario.IdCadastroLoginNovo);//
//    cmd.Parameters.AddWithValue("@Usuario", Usuario.Usuario);//
//    cmd.Parameters.AddWithValue("@Senha", Usuario.Senha);//
//    cmd.Parameters.AddWithValue("@ConfirmaSenha", Usuario.ConfirmaSenha);//
//    cmd.Parameters.AddWithValue("@UsuarioAcesso", Usuario.UsuarioAcesso);//
//    cmd.Parameters.AddWithValue("@IdAcessoBaseDados", Usuario.IdAcessoBaseDados);//

//    cmd.Parameters.AddWithValue("@CriarDadosPessoas", Usuario.CriarDadosPessoas);
//    cmd.Parameters.AddWithValue("@CriarFuncionarioOs", Usuario.CriarFuncionarioOs);
//    cmd.Parameters.AddWithValue("@CriarFuncionarioVendas", Usuario.CriarFuncionarioVendas);
//    cmd.Parameters.AddWithValue("@CriarUsuarioAcesso", Usuario.CriarUsuarioAcesso);

//    cmd.Parameters.AddWithValue("@UsuarioCriar", Usuario.UsuarioCriar);
//    cmd.Parameters.AddWithValue("@UsuarioAlterar", Usuario.UsuarioAlterar);
//    cmd.Parameters.AddWithValue("@UsuarioExcluir", Usuario.UsuarioExcluir);
//    cmd.Parameters.AddWithValue("@UsuarioPesquisa", Usuario.UsuarioPesquisa);
//    cmd.Parameters.AddWithValue("@UsuarioVisualizar", Usuario.UsuarioVisualizar);

//    cmd.Parameters.AddWithValue("@ClienteCadastra", Usuario.ClienteCadastra);
//    cmd.Parameters.AddWithValue("@ClientePesquisa", Usuario.ClientePesquisa);
//    cmd.Parameters.AddWithValue("@ClienteVisualizar", Usuario.ClienteVisualizar);
//    cmd.Parameters.AddWithValue("@ClienteEditar", Usuario.ClienteEditar);
//    cmd.Parameters.AddWithValue("@ClienteExcluir", Usuario.ClienteExcluir);

//    cmd.Parameters.AddWithValue("@ClienteCCadastra", Usuario.ClienteCCadastra);
//    cmd.Parameters.AddWithValue("@ClienteCPesquisa", Usuario.ClienteCPesquisa);
//    cmd.Parameters.AddWithValue("@ClienteCVisualizar", Usuario.ClienteCVisualizar);
//    cmd.Parameters.AddWithValue("@ClienteCEditar", Usuario.ClienteCEditar);
//    cmd.Parameters.AddWithValue("@ClienteCExcluir", Usuario.ClienteCExcluir);

//    cmd.Parameters.AddWithValue("@FornecedorCadastra", Usuario.FornecedorCadastra);
//    cmd.Parameters.AddWithValue("@FornecedorPesquisa", Usuario.FornecedorPesquisa);
//    cmd.Parameters.AddWithValue("@FornecedorVisualizar", Usuario.FornecedorVisualizar);
//    cmd.Parameters.AddWithValue("@FornecedorEditar", Usuario.FornecedorEditar);
//    cmd.Parameters.AddWithValue("@FornecedorExcluir", Usuario.FornecedorExcluir);

//    cmd.Parameters.AddWithValue("@FornecedorCCadastra", Usuario.FornecedorCCadastra);
//    cmd.Parameters.AddWithValue("@FornecedorCPesquisa", Usuario.FornecedorCPesquisa);
//    cmd.Parameters.AddWithValue("@FornecedorCVisualizar", Usuario.FornecedorCVisualizar);
//    cmd.Parameters.AddWithValue("@FornecedorCEditar", Usuario.FornecedorCEditar);
//    cmd.Parameters.AddWithValue("@FornecedorcExcluir", Usuario.FornecedorcExcluir);
//    //
//    cmd.Parameters.AddWithValue("@FuncionarioCadastra", Usuario.FuncionarioCadastra);//NÃO USANDO
//    cmd.Parameters.AddWithValue("@FuncionarioPesquisa", Usuario.FuncionarioPesquisa);//NÃO USANDO
//    cmd.Parameters.AddWithValue("@FuncionarioVisualizar", Usuario.FuncionarioVisualizar);//NÃO USANDO
//    cmd.Parameters.AddWithValue("@FuncionarioEditar", Usuario.FuncionarioEditar);//NÃO USANDO
//    cmd.Parameters.AddWithValue("@FuncionarioExcluir", Usuario.FuncionarioExcluir);//NÃO USANDO

//    cmd.Parameters.AddWithValue("@OsCadastra", Usuario.OsCadastra);
//    cmd.Parameters.AddWithValue("@OsPesquisa", Usuario.OsPesquisa);
//    cmd.Parameters.AddWithValue("@OsVisualizar", Usuario.OsVisualizar);
//    cmd.Parameters.AddWithValue("@OsEditar", Usuario.OsEditar);
//    cmd.Parameters.AddWithValue("@OsExcluir", Usuario.OsExcluir);

//    cmd.Parameters.AddWithValue("@SeniorSapiensAcesso", Usuario.SeniorSapiensAcesso);
//    cmd.Parameters.AddWithValue("@SeniorSapiensPesquisa", Usuario.SeniorSapiensPesquisa);
//    cmd.Parameters.AddWithValue("@SeniorSapiensExcluir", Usuario.SeniorSapiensExcluir);

//    cmd.Parameters.AddWithValue("@PermissaoBasedados", Usuario.PermissaoBasedados);
//    cmd.Parameters.AddWithValue("@PermissaoNivelaAcesso", Usuario.PermissaoNivelaAcesso);
//    cmd.Parameters.AddWithValue("@PermissaoCliente", Usuario.PermissaoCliente);
//    cmd.Parameters.AddWithValue("@PermissaoFornecedor", Usuario.PermissaoFornecedor);
//    cmd.Parameters.AddWithValue("@PermissaoFuncionarioOs", Usuario.PermissaoFuncionarioOs);
//    cmd.Parameters.AddWithValue("@PermissaoFuncionarioVendedor", Usuario.PermissaoFuncionarioVendedor);

//    cmd.Parameters.AddWithValue("@PermissaoUsuarioAcesso", Usuario.PermissaoUsuarioAcesso);
//    cmd.Parameters.AddWithValue("@PermissaoOs", Usuario.PermissaoOs);/////
//    cmd.Parameters.AddWithValue("@PermissaoSeniorSapiens", Usuario.PermissaoSeniorSapiens);

//    cmd.Parameters.AddWithValue("@VendedorCadastra", Usuario.VendedorCadastra);
//    cmd.Parameters.AddWithValue("@VendedorPesquisa", Usuario.VendedorPesquisa);
//    cmd.Parameters.AddWithValue("@VendedorVisualizar", Usuario.VendedorVisualizar);
//    cmd.Parameters.AddWithValue("@VendedorEditar", Usuario.VendedorEditar);
//    cmd.Parameters.AddWithValue("@VendedorExcluir", Usuario.VendedorExcluir);

//    cmd.Parameters.AddWithValue("@ProdutosCadastra", Usuario.ProdutosCadastra);
//    cmd.Parameters.AddWithValue("@ProdutosVisualizar", Usuario.ProdutosVisualizar);
//    cmd.Parameters.AddWithValue("@ProdutosPesquisa", Usuario.ProdutosPesquisa);
//    cmd.Parameters.AddWithValue("@ProdutosEditar", Usuario.ProdutosEditar);
//    cmd.Parameters.AddWithValue("@ProdutosExcluir", Usuario.ProdutosExcluir);

//    cmd.Parameters.AddWithValue("@RegistroCCadastra", Usuario.RegistroCCadastra);
//    cmd.Parameters.AddWithValue("@RegistroCVisualizar", Usuario.RegistroCVisualizar);
//    cmd.Parameters.AddWithValue("@RegistroCPesquisa", Usuario.RegistroCPesquisa);
//    cmd.Parameters.AddWithValue("@RegistroCEditar", Usuario.RegistroCEditar);
//    cmd.Parameters.AddWithValue("@RegistroCExcluir", Usuario.RegistroCExcluir);

//    cmd.Parameters.AddWithValue("@CriarFuncionarioProdutos", Usuario.CriarFuncionarioProdutos);//CRIARCCC     
//    cmd.Parameters.AddWithValue("@CriarFuncionarioRegistro", Usuario.CriarFuncionarioRegistro);//CRIARCCC
//    cmd.Parameters.AddWithValue("@PermissaoRegistro", Usuario.PermissaoRegistro);//CRIARCCCC
//    cmd.Parameters.AddWithValue("@PermissaoFuncionarioProdutos", Usuario.PermissaoFuncionarioProdutos);

//    cmd.Parameters.AddWithValue("@RegistroCCCadastra", Usuario.RegistroCCCadastra);
//    cmd.Parameters.AddWithValue("@RegistroCCVisualizar", Usuario.RegistroCCVisualizar);
//    cmd.Parameters.AddWithValue("@RegistroCCPesquisa", Usuario.RegistroCCPesquisa);
//    cmd.Parameters.AddWithValue("@RegistroCCEditar", Usuario.RegistroCCEditar);
//    cmd.Parameters.AddWithValue("@RegistroCCExcluir", Usuario.RegistroCCExcluir);

//    cmd.Parameters.AddWithValue("@RegistroCadastra", Usuario.RegistroCadastra);
//    cmd.Parameters.AddWithValue("@RegistroVisualizar", Usuario.RegistroVisualizar);
//    cmd.Parameters.AddWithValue("@RegistroPesquisa", Usuario.RegistroPesquisa);
//    cmd.Parameters.AddWithValue("@RegistroEditar", Usuario.RegistroEditar);
//    cmd.Parameters.AddWithValue("@RegistroExcluir", Usuario.RegistroExcluir);

//    cmd.Parameters.AddWithValue("@PropostaCadastra", Usuario.PropostaCadastra);
//    cmd.Parameters.AddWithValue("@PropostaVisualizar", Usuario.PropostaVisualizar);
//    cmd.Parameters.AddWithValue("@PropostaPesquisa", Usuario.PropostaPesquisa);
//    cmd.Parameters.AddWithValue("@PropostaEditar", Usuario.PropostaEditar);
//    cmd.Parameters.AddWithValue("@PropostaExcluir", Usuario.PropostaExcluir);
//    cmd.Parameters.AddWithValue("@CriarProposta", Usuario.CriarProposta);
//    cmd.Parameters.AddWithValue("@PermissaoProposta", Usuario.PermissaoProposta);
//    cmd.Parameters.AddWithValue("@AtualicazaoTelaPrincipal", Usuario.AtualicazaoTelaPrincipal);
//    cmd.Parameters.AddWithValue("@VerificadorOs", Usuario.VerificadorOs);

//    objConexao.Conectar();
//    cmd.ExecuteScalar();
//    objConexao.Desconectar();
//}
//public void ExcluirLoginUsuario(int idUsuario)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "DELETE FROM [dbo].[LoginUsuario] WHERE ID_LOGIN_USUARIO = @idPessoa;";
//    cmd.Parameters.AddWithValue("@idPessoa", idUsuario);

//    objConexao.Conectar();
//    cmd.ExecuteNonQuery();
//    objConexao.Desconectar();

//}
//public void UpdateLoginUsuario(int Id_LoginUsuario, int Id_AcessoBaseDados)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "UPDATE [dbo].LoginUsuario SET ID_ACESSO_BASE_DADOS=@Id_AcessoBaseDados WHERE ID_LOGIN_USUARIO = @Id_LoginUsuario;";
//    cmd.Parameters.AddWithValue("@Id_LoginUsuario", Id_LoginUsuario);
//    cmd.Parameters.AddWithValue("@Id_AcessoBaseDados", Id_AcessoBaseDados);

//    objConexao.Conectar();
//    cmd.ExecuteNonQuery();
//    objConexao.Desconectar();

//}
////Usuario Acesso ao SQL Base de Dados
//public void IncluiAcessoBancoDados(AcessoBaseDados cliente)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    //transacao = objConexao.ObjetoConexao.BeginTransaction("");


//    cmd.CommandText = "EXEC D_AcessoBancoDadosInserir @Servidor,@BaseDados,@Nome,@Senha;";



//    cmd.Parameters.AddWithValue("@Servidor", cliente.Servidor);
//    cmd.Parameters.AddWithValue("@BaseDados", cliente.BaseDados);
//    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
//    cmd.Parameters.AddWithValue("@Senha", cliente.Senha);


//    objConexao.Conectar();
//    cmd.ExecuteScalar();
//}





////Incluir Funcionario Vendedor  ---------------------------------------------------------------------------------------------------------------------------
//public void IncluirFuncionarioVendedor(Vendedor Vendedor)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    //transacao = objConexao.ObjetoConexao.BeginTransaction("");

//    cmd.CommandText = "EXEC D_FuncionarioVendedorInserir @IdVendedor,@Salario,@Comissao,@Tipo,@Abreviacao,@Telefone,@Telefone2,@Celular,@Celular2,@Email,@Descricao," +
//        "@Cargo,@DataAdmissao,@DiaPAgamento;";

//    cmd.Parameters.AddWithValue("@IdVendedor", Vendedor.IdVendedor);

//    if (Vendedor.Salario == 0)//
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Salario", Vendedor.Salario).Value = SqlBinary.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Salario", Vendedor.Salario);
//    }

//    if (Vendedor.Comissao == 0)//
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Comissao", Vendedor.Comissao).Value = SqlBinary.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Comissao", Vendedor.Comissao);
//    }

//    if (Vendedor.Tipo == 0)//
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Tipo", Vendedor.Tipo).Value = SqlBinary.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Tipo", Vendedor.Tipo);
//    }
//    if (Vendedor.Abreviacao == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Abreviacao", Vendedor.Abreviacao).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Abreviacao", Vendedor.Abreviacao);
//    }
//    if (Vendedor.Telefone == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Telefone", Vendedor.Telefone).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Telefone", Vendedor.Telefone);
//    }
//    if (Vendedor.Telefone2 == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Telefone2", Vendedor.Telefone2).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Telefone2", Vendedor.Telefone2);
//    }
//    if (Vendedor.Celular == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular", Vendedor.Celular).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular", Vendedor.Celular);
//    }
//    if (Vendedor.Celular2 == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular2", Vendedor.Celular2).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular2", Vendedor.Celular2);
//    }
//    if (Vendedor.Email == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Email", Vendedor.Email).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Email", Vendedor.Email);
//    }
//    if (Vendedor.Observacao == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Descricao", Vendedor.Descricao).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Descricao", Vendedor.Descricao);
//    }
//    if (Vendedor.Cargo == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Cargo", Vendedor.Cargo).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Cargo", Vendedor.Cargo);
//    }
//    cmd.Parameters.AddWithValue("@DataAdmissao", Vendedor.DataAdmissao);

//    if (Vendedor.DiaPAgamento == 0)//
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@DiaPAgamento", Vendedor.DiaPAgamento).Value = SqlBinary.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@DiaPAgamento", Vendedor.DiaPAgamento);
//    }

//    //cmd.Parameters.AddWithValue("@Tipo", Vendedor.Tipo);

//    objConexao.Conectar();
//    cmd.ExecuteScalar();
//    objConexao.Desconectar();

//}
//public void IncluirUsuarioV(UsuarioV UsuarioVenda)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    //transacao = objConexao.ObjetoConexao.BeginTransaction("");

//    cmd.CommandText = "EXEC D_FuncionarioUsuarioVInserir @ID_UsuarioV,@Abreviacao,@Telefone,@Telefone2,@Celular,@Celular2,@Email;";

//    cmd.Parameters.AddWithValue("@ID_UsuarioV", UsuarioVenda.ID_UsuarioV);

//    if (UsuarioVenda.Abreviacao == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Abreviacao", UsuarioVenda.Abreviacao).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Abreviacao", UsuarioVenda.Abreviacao);
//    }
//    if (UsuarioVenda.Telefone == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Telefone", UsuarioVenda.Telefone).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Telefone", UsuarioVenda.Telefone);
//    }
//    if (UsuarioVenda.Telefone2 == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Telefone2", UsuarioVenda.Telefone2).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Telefone2", UsuarioVenda.Telefone2);
//    }
//    if (UsuarioVenda.Celular == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular", UsuarioVenda.Celular).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular", UsuarioVenda.Celular);
//    }
//    if (UsuarioVenda.Celular2 == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Celular2", UsuarioVenda.Celular2).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Celular2", UsuarioVenda.Celular2);
//    }
//    if (UsuarioVenda.Email == "")
//    {
//        // passa valor nulo para a tabela
//        cmd.Parameters.AddWithValue("@Email", UsuarioVenda.Email).Value = SqlDateTime.Null;
//    }
//    else
//    {
//        cmd.Parameters.AddWithValue("@Email", UsuarioVenda.Email);
//    }

//    objConexao.Conectar();
//    cmd.ExecuteScalar();
//    objConexao.Desconectar();
//}
//public void TelaPrincipalNovasAtualizacoesTexto(TelaPrincipalNovaAtualizacaoTexto TPNA)
//{
//    SqlCommand cmd = new SqlCommand();
//    cmd.Connection = objConexao.ObjetoConexao;

//    cmd.CommandText = "exec D_TelaPrincipalNovasAtualizacoesTextoUpdate @idUsuario,@AtualizacaoTelaPrincipal;";
//    cmd.Parameters.AddWithValue("@idUsuario", TPNA.idUsuario);
//    cmd.Parameters.AddWithValue("@AtualizacaoTelaPrincipal", TPNA.AtualizacaoTelaPrincipal);

//    objConexao.Conectar();
//    cmd.ExecuteNonQuery();
//    objConexao.Desconectar();
//}



