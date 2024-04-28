using EasyHortifruti.DML;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Policy;

namespace EasyHortifruti

{
    public class ConexaoBD
    {
        private string connectionString;

        #region Constructor
        public ConexaoBD()
        {
            connectionString = "Host=localhost;Username=Admin;Password=2125071216;Database=EasyHortifruti";
        }
        #endregion

        #region Métodos

        #region Tabelas

        #region Geral
        public DataSet ConsultarGerais() => ConsultarTabela(TabelasScript.TabelaGeral);

        public Geral ConsultarGeralPorId(int pId)
        {
            Geral iGeral = new Geral();

            iGeral.CarregarGeral(ConsultarTabelaPorId(pId, TabelasScript.TabelaGeral));

            return iGeral;
        }

        public void InserirGeral(Geral pGeral)
        {
            Telefone fone = pGeral.Telefones.First(x => x.tipoTelefone == TipoTelefone.pessoal);
            Telefone celular = pGeral.Telefones.First(x => x.tipoTelefone == TipoTelefone.celular);

            Dictionary<string, string> pCampos = new Dictionary<string, string>
            {
                { "tppessoa", pGeral.TipoPessoa == TPFJ.Fisica ? "F" : "J" },
                { "classificacao", pGeral.Classificacao.ToString() },
                { "nomefantasia", pGeral.NomeFantasia },
                { "razaosocial", pGeral.RazaoSocial },
                { "estadocivil", ((int)pGeral.EstadoCivil).ToString() },
                { "sexo", ((int)pGeral.Sexo).ToString() },
                { "contato", pGeral.Contato },
                { "dtnascaber", pGeral.DtNascFundacao.ToString("dd/MM/yyyy") },
                { "cnpj", pGeral.CNPJ },
                { "cpf", pGeral.CPF },
                { "rg", pGeral.RG },
                { "inscrestadual", pGeral.IE },
                { "inscrmunicipal", pGeral.InscricaoMunicipal },
                { "orgexpedidor", pGeral.OrgaoExpedidor },
                { "ufrgexped", pGeral.OrgaoExpedidorUF },
                { "dddfone", fone.DDD },
                { "fone", fone.Numero },
                { "dddcel", celular.DDD },
                { "celular", celular.Numero },
                { "cep", pGeral.Endereco.CEP },
                { "logradouro", pGeral.Endereco.logradouro },
                { "numero", pGeral.Endereco.Numero.ToString() },
                { "complemento", pGeral.Endereco.Complemento },
                { "bairro", pGeral.Endereco.Complemento },
                { "cidade", pGeral.Endereco.Cidade },
                { "uf", pGeral.Endereco.UF },
                { "pontoreferencia", pGeral.PontoReferencia },
                { "email", pGeral.Email },
                { "prazoPgto", pGeral.PrazoPagamento.ToString() }

            };

            ExecutarSemRetorno(TabelasScript.ScriptInsert(TabelasScript.TabelaGeral, pCampos));
        }
        public void AlterarGeral(Geral pGeral)
        {
            Telefone fone = pGeral.Telefones.First(x => x.tipoTelefone == TipoTelefone.pessoal);
            Telefone celular = pGeral.Telefones.First(x => x.tipoTelefone == TipoTelefone.celular);
            
            Dictionary<string, string> pCampos = new Dictionary<string, string>
            {
                { "tppessoa", pGeral.TipoPessoa == TPFJ.Fisica ? "F" : "J" },
                { "classificacao", ((int)pGeral.Classificacao).ToString() },
                { "nomefantasia", pGeral.NomeFantasia },
                { "razaosocial", pGeral.RazaoSocial },
                { "estadocivil", ((int)pGeral.EstadoCivil).ToString() },
                { "sexo", ((int)pGeral.Sexo).ToString() },
                { "contato", pGeral.Contato },
                { "dtnascaber", pGeral.DtNascFundacao.ToString("dd/MM/yyyy") },
                { "cnpj", pGeral.CNPJ },
                { "cpf", pGeral.CPF },
                { "rg", pGeral.RG },
                { "inscrestadual", pGeral.IE },
                { "inscrmunicipal", pGeral.InscricaoMunicipal },
                { "orgexpedidor", pGeral.OrgaoExpedidor },
                { "ufrgexped", pGeral.OrgaoExpedidorUF },
                { "dddfone", fone.DDD },
                { "fone", fone.Numero },
                { "dddcel", celular.DDD },
                { "celular", celular.Numero },
                { "cep", pGeral.Endereco.CEP },
                { "logradouro", pGeral.Endereco.logradouro },
                { "numero", pGeral.Endereco.Numero.ToString() },
                { "complemento", pGeral.Endereco.Complemento },
                { "bairro", pGeral.Endereco.Complemento },
                { "cidade", pGeral.Endereco.Cidade },
                { "uf", pGeral.Endereco.UF },
                { "pontoreferencia", pGeral.PontoReferencia },
                { "email", pGeral.Email },
                { "prazoPgto", pGeral.PrazoPagamento.ToString() }
            };

            ExecutarSemRetorno(TabelasScript.ScriptUpdate(TabelasScript.TabelaGeral, pGeral.ID, pCampos));
        }

        public void ExcluirGeral(int pId) => ExcluirRegistro(pId, TabelasScript.TabelaGeral);

        #endregion

        #endregion

        #region Unidades

        public DataSet ConsultarUnidades() => ConsultarTabela(TabelasScript.TabelaUnidades);
        
        public DataSet ConsultarUnidadePorId(int pId) => ConsultarTabelaPorId(pId, TabelasScript.TabelaUnidades);

        public void InserirUnidade(string Abreviatura, string Descricao, string Observacao)
        {
            Dictionary<string, string> pCampos = new Dictionary<string, string>
            {
                { "abrev_unid", Abreviatura },
                { "desc_unid", Descricao },
                { "obs_unid", Observacao }
            };

            ExecutarSemRetorno(TabelasScript.ScriptInsert(TabelasScript.TabelaUnidades, pCampos));
        }

        public void AlterarUnidade(int pId, string Abreviatura, string Descricao, string Observacao)
        {
            Dictionary<string, string> pCampos = new Dictionary<string, string>
            {
                { "abrev_unid", Abreviatura },
                { "desc_unid", Descricao },
                { "obs_unid", Observacao }
            };

            ExecutarSemRetorno(TabelasScript.ScriptUpdate(TabelasScript.TabelaUnidades, pId, pCampos));
        }

        public void ExcluirUnidade(int pId) => ExcluirRegistro(pId, TabelasScript.TabelaUnidades);


        #endregion

        #region Grupo
        public DataSet ConsultarGrupos() => ConsultarTabela(TabelasScript.TabelaGrupos);

        public DataSet ConsultarGrupoPorId(int pId) => ConsultarTabelaPorId(pId, TabelasScript.TabelaGrupos);

        public void InserirGrupo(string Descricao, string Observacao, string MargemLucro)
        {
            Dictionary<string, string> pCampos = new Dictionary<string, string>
            {
                { "nome_grupo", Descricao },
                { "obs_grupo", Observacao },
                { "margem_grupo", MargemLucro }
            };

            ExecutarSemRetorno(TabelasScript.ScriptInsert(TabelasScript.TabelaGrupos, pCampos));
        }
        public void AlterarGrupo(int pId, string Descricao, string Observacao, string MargemLucro)
        {
            Dictionary<string, string> pCampos = new Dictionary<string, string>
            {
                { "nome_grupo", Descricao },
                { "obs_grupo", Observacao },
                { "margem_grupo", MargemLucro }
            };

            ExecutarSemRetorno(TabelasScript.ScriptUpdate(TabelasScript.TabelaGrupos, pId, pCampos));
        }

        public void ExcluirGrupo(int pId) => ExcluirRegistro(pId, TabelasScript.TabelaGrupos);
        #endregion

        #region SubGrupo
        public DataSet ConsultarSubGrupos() => ConsultarTabela(TabelasScript.TabelaSubGrupos);
        public DataSet ConsultarSubGrupo(int pId)
        {
            string sql = string.Concat("SELECT Sub.id_recno, grp.nome_grupo, Sub.nome_subgrupo, " +
                "Sub.margem_subgrupo FROM ", TabelasScript.TabelaSubGrupos, " Sub JOIN ", TabelasScript.TabelaGrupos, " grp ON Sub.id_grupo = grp.id_recno");

            if (pId > 0)
                sql += " where Sub.id_recno = " + pId.ToString();

            return ExecutaEPreencheDataset(sql);
        }
        public void InserirSubGrupo(string Descricao, int pGrupo, string MargemLucro)
        {
            Dictionary<string, string> pCampos = new Dictionary<string, string>
            {
                { "nome_subgrupo", Descricao },
                { "id_grupo", pGrupo.ToString() },
                { "margem_subgrupo", MargemLucro }
            };

            ExecutarSemRetorno(TabelasScript.ScriptInsert(TabelasScript.TabelaSubGrupos, pCampos));
        }

        public void AlterarSubGrupo(int pId, string Descricao, int pGrupo, string MargemLucro)
        {
            Dictionary<string, string> pCampos = new Dictionary<string, string>
            {
                { "nome_subgrupo", Descricao },
                { "id_grupo", pGrupo.ToString() },
                { "margem_subgrupo", MargemLucro }
            };

            ExecutarSemRetorno(TabelasScript.ScriptUpdate(TabelasScript.TabelaSubGrupos, pId, pCampos));
        }
        public void ExcluirSubGrupo(int pId) => ExcluirRegistro(pId, TabelasScript.TabelaSubGrupos);
        #endregion

        #region Produtos
        public DataSet ConsultarProdutos()
        {
            string sql = string.Concat("SELECT * FROM produtos P INNER JOIN GRUPOS G ON P.ID_GRUPO=G.ID_RECNO INNER JOIN SUBGRUPOS S ON P.ID_SUBGRUPO=S.ID_RECNO INNER JOIN UNIDADES U ON P.ID_UNIDADE=U.ID_RECNO");

            return ExecutaEPreencheDataset(sql);
        }

        public Produto ConsultarProdutoPorId(int pId)
        {
            string sql = string.Concat("SELECT * FROM produtos P INNER JOIN GRUPOS G ON P.ID_GRUPO=G.ID_RECNO INNER JOIN SUBGRUPOS S ON P.ID_SUBGRUPO=S.ID_RECNO INNER JOIN UNIDADES U ON P.ID_UNIDADE=U.ID_RECNO WHERE P.ID_RECNO =", pId);

            Produto produto = new Produto();
            DataSet ds = ExecutaEPreencheDataset(sql);
            produto.CarregarProduto(ds);

            return produto;
        }

        public void IncluirProduto(Produto pProduto)
        {
            Dictionary<string, string> pCampos = new Dictionary<string, string>
            {
                { "nome_produto", pProduto.Descricao },
                { "pcocompra_produto", pProduto.PrecoDeCompra.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) },
                { "pcovenda_produto", pProduto.PrecoDeVenda.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) },
                { "margem_produto", pProduto.MargemLucro.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)},
                { "id_unidade",  pProduto.IdUnidade.ToString() },
                { "id_grupo", pProduto.IdGrupo.ToString() },
                { "id_subgrupo", pProduto.IdSubGrupo.ToString() }
            };

            ExecutarSemRetorno(TabelasScript.ScriptInsert(TabelasScript.TabelaProdutos, pCampos));
        }

        public void AlterarProduto(Produto pProduto)
        {
            Dictionary<string, string> pCampos = new Dictionary<string, string>
            {
                { "nome_produto", pProduto.Descricao },
                { "pcocompra_produto", pProduto.PrecoDeCompra.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) },
                { "pcovenda_produto", pProduto.PrecoDeVenda.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) },
                { "margem_produto", pProduto.MargemLucro.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)},
                { "id_unidade",  pProduto.IdUnidade.ToString() },
                { "id_grupo", pProduto.IdGrupo.ToString() },
                { "id_subgrupo", pProduto.IdSubGrupo.ToString() }
            };

            ExecutarSemRetorno(TabelasScript.ScriptUpdate(TabelasScript.TabelaProdutos, pProduto.ID, pCampos));
        }

        public void ExcluirProduto(int pId) => ExcluirRegistro(pId, TabelasScript.TabelaProdutos);
        #endregion

        #region Pedidos

        public DataSet ConsultarPedidos() => ConsultarTabela(TabelasScript.TabelaPedidos);

        public DataSet ConsultarPedidosPorId(int pId) => ConsultarTabelaPorId(pId, TabelasScript.TabelaPedidos);

        public void InserirPedido(Pedido pPedido)
        {
            //TO DO: IMPLEMENTAR
            Dictionary<string, string> Campos = new Dictionary<string, string>
            {
                { "datapedido",     pPedido.dataPedido.ToString() },
                { "statuspedido",   pPedido.StatusPedido.ToString() },
                { "id_fonte",       pPedido.IdFonte.ToString() },
                { "dataprev",       pPedido.DataPrev.ToString("dd/MM/yyyy") },
                { "prazopgto",      pPedido.PrazoPagamento.ToString() },
                { "dataentrega",    pPedido.DataEntrega.ToString("dd/MM/yyyy") }, 
                { "dataconclusao",  pPedido.DataConclusao.ToString("dd/MM/yyyy") }, 
                { "id_produto",     pPedido.IdProduto.ToString() }, 
                { "qtdproduto",     pPedido.QuantidadeProduto.ToString() }, 
                { "vrcompra",       pPedido.ValorCompra.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) },  
                { "vrvenda",        pPedido.ValorVenda.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) }, 
                { "totalvenda",     pPedido.TotalVenda.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) }, 
                { "percentlucro",   pPedido.PercentualLucro.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) }
            };

            ExecutarSemRetorno(TabelasScript.ScriptInsert(TabelasScript.TabelaPedidos, Campos));
        }

        public void AlterarPedido(Pedido pPedido)
        {
            //TO DO: IMPLEMENTAR
            Dictionary<string, string> pCampos = new Dictionary<string, string>
            {
                { "datapedido",     pPedido.dataPedido.ToString() },
                { "statuspedido",   pPedido.StatusPedido.ToString() },
                { "id_fonte",       pPedido.IdFonte.ToString() },
                { "dataprev",       pPedido.DataPrev.ToString("dd/MM/yyyy") },
                { "prazopgto",      pPedido.PrazoPagamento.ToString() },
                { "dataentrega",    pPedido.DataEntrega.ToString("dd/MM/yyyy") },
                { "dataconclusao",  pPedido.DataConclusao.ToString("dd/MM/yyyy") },
                { "id_produto",     pPedido.IdProduto.ToString() },
                { "qtdproduto",     pPedido.QuantidadeProduto.ToString() },
                { "vrcompra",       pPedido.ValorCompra.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) },
                { "vrvenda",        pPedido.ValorVenda.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) },
                { "totalvenda",     pPedido.TotalVenda.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) },
                { "percentlucro",   pPedido.PercentualLucro.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) }
            };

            ExecutarSemRetorno(TabelasScript.ScriptUpdate(TabelasScript.TabelaPedidos, pPedido.ID, pCampos));
        }

        public void ExcluirPedido(int pId) => ExcluirRegistro(pId, TabelasScript.TabelaPedidos);
        #endregion

        #region CtasReceber

        public DataSet ConsultarContas() => ConsultarTabela(TabelasScript.TabelaCtasReceber);

        public DataSet ConsultarContaPorId(int pId) => ConsultarTabelaPorId(pId, TabelasScript.TabelaCtasReceber);

        public void InserirConta(ContaAReceber pContaAReceber)
        {
            //TO DO: IMPLEMENTAR
            Dictionary<string, string> pCampos = new Dictionary<string, string>
            {
               {" id_pedido=",      pContaAReceber.IdPedido.ToString() },
               {" id_fonte=",       pContaAReceber.IdFonte.ToString() },
               {" vlpedido=",       pContaAReceber.ValorPedido.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) },
               {" margempedido=",   pContaAReceber.MargemPedido.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) },
               {" dtvencto=",       pContaAReceber.DataVencimento.ToString("dd/MM/yyyy") },
               {" dtrecebto= ",     pContaAReceber.DataRecebimento.ToString("dd/MM/yyyy") }
            };

            ExecutarSemRetorno(TabelasScript.ScriptInsert(TabelasScript.TabelaCtasReceber, pCampos));
        }

        public void AlterarConta(ContaAReceber pContaAReceber)
        {
            //TO DO: IMPLEMENTAR
            Dictionary<string, string> pCampos = new Dictionary<string, string>
            {
               {" id_pedido=",      pContaAReceber.IdPedido.ToString() },
               {" id_fonte=",       pContaAReceber.IdFonte.ToString() },
               {" vlpedido=",       pContaAReceber.ValorPedido.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) },
               {" margempedido=",   pContaAReceber.MargemPedido.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) },
               {" dtvencto=",       pContaAReceber.DataVencimento.ToString("dd/MM/yyyy") },
               {" dtrecebto= ",     pContaAReceber.DataRecebimento.ToString("dd/MM/yyyy") }
            };

            ExecutarSemRetorno(TabelasScript.ScriptUpdate(TabelasScript.TabelaCtasReceber, pContaAReceber.ID, pCampos));
        }

        public void ExcluirConta(int pId) => ExcluirRegistro(pId, TabelasScript.TabelaCtasReceber);

        #endregion

        public DataSet ConsutarNCMs() => ConsultarTabela("tabelancm");
        #endregion

        #region Privado
        private DataSet ExecutaEPreencheDataset(string pSql)
        {
            DataSet dataSet = new DataSet();

            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(pSql, conn))
                        adapter.Fill(dataSet);
                }
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ExecutarSemRetorno(string pSql)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(pSql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        private void ExcluirRegistro(int pId, string pNomeTabela)
        {
            string sql = String.Format("DELETE FROM {0} WHERE id_recno={1}", pNomeTabela, pId);

            ExecutarSemRetorno(sql);
        }
        
        private DataSet ConsultarTabela(string pNomeTabela)
        {
            string sql = string.Concat("SELECT * FROM ", pNomeTabela);

            return ExecutaEPreencheDataset(sql);
        }
        
        private DataSet ConsultarTabelaPorId(int pId, string pNomeTabela)
        {
            string sql = string.Concat("SELECT * FROM ", pNomeTabela, " WHERE id_recno=", pId.ToString());

            return ExecutaEPreencheDataset(sql);
        }

        public void CriaTabelasBD()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                foreach (string script in new TabelasScript().Scripts)
                    new NpgsqlCommand(script, conn).ExecuteNonQuery();
            }

        }
        #endregion
    }
}
