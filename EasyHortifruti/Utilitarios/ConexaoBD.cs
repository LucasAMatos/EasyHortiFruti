using EasyHortifruti.DML;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Web;
using System.Windows.Forms;
using static EasyHortifruti.DML.Pedido;

namespace EasyHortifruti

{
    public class ConexaoBD
    {
        private readonly string connectionString;

        #region Constructor

        public ConexaoBD()
        {
            connectionString = "Host=localhost;Username=Admin;Password=2125071216;Database=EasyHortifruti";
        }

        #endregion Constructor

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

        public DataSet ConsultarGeralPorClassificacao(Classificacao pClassificacao)
        {
            string sql = "select * from geral where classificacao = " + ((int)pClassificacao).ToString();

            return ExecutaEPreencheDataset(sql);
        }

        public void InserirGeral(Geral pGeral)
        {
            Telefone fone = pGeral.Telefones.First(x => x.TipoTelefone == TipoTelefone.pessoal);
            Telefone celular = pGeral.Telefones.First(x => x.TipoTelefone == TipoTelefone.celular);

            Dictionary<string, string> pCampos = new Dictionary<string, string>
            {
                { "tppessoa", pGeral.TipoPessoa == TPFJ.Fisica ? "F" : "J" },
                { "classificacao", ((int)pGeral.Classificacao).ToString() },
                { "nomefantasia", pGeral.NomeFantasia },
                { "razaosocial", pGeral.TipoPessoa == TPFJ.Fisica ? pGeral.NomeCompleto : pGeral.RazaoSocial },
                { "estadocivil", ((int)pGeral.EstadoCivil).ToString() },
                { "sexo", ((int)pGeral.Sexo).ToString() },
                { "contato", pGeral.Contato },
                { "dtnascaber", pGeral.DtNascFundacao.ToString("dd/MM/yyyy") },
                { "cnpj_cpf", pGeral.TipoPessoa == TPFJ.Fisica ? pGeral.CPF : pGeral.CNPJ },
                { "ie_rg", pGeral.TipoPessoa ==  TPFJ.Fisica ? pGeral.RG : pGeral.IE },
                { "inscrmunicipal", pGeral.InscricaoMunicipal },
                { "dddfone", fone.DDD },
                { "fone", fone.Numero },
                { "dddcel", celular.DDD },
                { "celular", celular.Numero },
                { "cep", pGeral.Endereco.CEP },
                { "logradouro", pGeral.Endereco.Logradouro },
                { "numero", pGeral.Endereco.Numero.ToString() },
                { "complemento", pGeral.Endereco.Complemento },
                { "bairro", pGeral.Endereco.Bairro },
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
            Telefone fone = pGeral.Telefones.First(x => x.TipoTelefone == TipoTelefone.pessoal);
            Telefone celular = pGeral.Telefones.First(x => x.TipoTelefone == TipoTelefone.celular);

            Dictionary<string, string> pCampos = new Dictionary<string, string>
            {
                { "tppessoa", pGeral.TipoPessoa == TPFJ.Fisica ? "F" : "J" },
                { "classificacao", ((int)pGeral.Classificacao).ToString() },
                { "nomefantasia", pGeral.NomeFantasia },
                { "razaosocial", pGeral.TipoPessoa == TPFJ.Fisica ? pGeral.NomeCompleto : pGeral.RazaoSocial },
                { "estadocivil", ((int)pGeral.EstadoCivil).ToString() },
                { "sexo", ((int)pGeral.Sexo).ToString() },
                { "contato", pGeral.Contato },
                { "dtnascaber", pGeral.DtNascFundacao.ToString("dd/MM/yyyy") },
                { "cnpj_cpf", pGeral.TipoPessoa == TPFJ.Fisica ? pGeral.CPF : pGeral.CNPJ },
                { "ie_rg", pGeral.TipoPessoa ==  TPFJ.Fisica ? pGeral.RG : pGeral.IE },
                { "inscrmunicipal", pGeral.InscricaoMunicipal },
                { "dddfone", fone.DDD },
                { "fone", fone.Numero },
                { "dddcel", celular.DDD },
                { "celular", celular.Numero },
                { "cep", pGeral.Endereco.CEP },
                { "logradouro", pGeral.Endereco.Logradouro },
                { "numero", pGeral.Endereco.Numero.ToString() },
                { "complemento", pGeral.Endereco.Complemento },
                { "bairro", pGeral.Endereco.Bairro },
                { "cidade", pGeral.Endereco.Cidade },
                { "uf", pGeral.Endereco.UF },
                { "pontoreferencia", pGeral.PontoReferencia },
                { "email", pGeral.Email },
                { "prazoPgto", pGeral.PrazoPagamento.ToString() }
            };

            ExecutarSemRetorno(TabelasScript.ScriptUpdate(TabelasScript.TabelaGeral, pGeral.ID, pCampos));
        }

        public void ExcluirGeral(int pId) => ExcluirRegistro(pId, TabelasScript.TabelaGeral);

        #endregion Geral

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

        #endregion Unidades

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

        #endregion Grupo

        #region SubGrupo

        public DataSet ConsultarSubGrupos() => ConsultarTabela(TabelasScript.TabelaSubGrupos);

        public DataSet ConsultarSubGrupo(int pId)
        {
            string sql = string.Concat("SELECT Sub.nome_subgrupo, grp.nome_grupo,  " +
                "Sub.margem_subgrupo,Sub.id_recno FROM ", TabelasScript.TabelaSubGrupos, " Sub JOIN ", TabelasScript.TabelaGrupos, " grp " +
                "ON Sub.id_grupo = grp.id_recno");

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

        #endregion SubGrupo

        #region Produtos

        public DataSet ConsultarProdutos()
        {
            string sql = string.Concat("SELECT * FROM produtos P LEFT JOIN GRUPOS G ON P.ID_GRUPO=G.ID_RECNO LEFT JOIN SUBGRUPOS S ON P.ID_SUBGRUPO=S.ID_RECNO LEFT JOIN UNIDADES U ON P.ID_UNIDADE=U.ID_RECNO");

            return ExecutaEPreencheDataset(sql);
        }

        public DataSet ConsultarListaDeProdutos()
        {
            string sql = string.Concat("SELECT nome_produto FROM produtos");

            return ExecutaEPreencheDataset(sql);
        }

        public Produtos ConsultarObjetoProdutos()
        {
            string sql = string.Concat("SELECT * FROM produtos P LEFT JOIN GRUPOS G ON P.ID_GRUPO=G.ID_RECNO LEFT JOIN SUBGRUPOS S ON P.ID_SUBGRUPO=S.ID_RECNO LEFT JOIN UNIDADES U ON P.ID_UNIDADE=U.ID_RECNO");

            Produtos produtos = new Produtos();
            DataSet ds = ExecutaEPreencheDataset(sql);
            produtos.CarregarProdutos(ds);

            return produtos;
        }

        public Produto ConsultarProdutoPorId(int pId)
        {
            string sql = $"SELECT * FROM produtos P LEFT JOIN GRUPOS G ON P.ID_GRUPO=G.ID_RECNO LEFT JOIN SUBGRUPOS S ON P.ID_SUBGRUPO=S.ID_RECNO INNER JOIN UNIDADES U ON P.ID_UNIDADE=U.ID_RECNO WHERE P.ID_RECNO ={pId}";

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
                { "id_subgrupo", pProduto.IdSubGrupo.ToString() },
                { "ncm", pProduto.NCM}
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
                { "id_subgrupo", pProduto.IdSubGrupo.ToString() },
                { "ncm", pProduto.NCM}
            };

            ExecutarSemRetorno(TabelasScript.ScriptUpdate(TabelasScript.TabelaProdutos, pProduto.ID, pCampos));
        }

        public void ExcluirProduto(int pId) => ExcluirRegistro(pId, TabelasScript.TabelaProdutos);

        public void AtualizarValorCompraVenda(Tuple<int, decimal, decimal> novoValorProduto)
        {
            string sql = $"" +
                $"UPDATE {TabelasScript.TabelaProdutos} SET " +
                $"pcocompra_produto = {novoValorProduto.Item3.ToString().Replace(',', '.')}," +
                $"pcovenda_produto = {novoValorProduto.Item2.ToString().Replace(',', '.')} " +
                $"WHERE ID_RECNO={novoValorProduto.Item1}";
            ExecutarSemRetorno(sql);
        }

        #endregion Produtos

        #region Pedidos

        public DataSet ConsultarPedidos()
        {
            string sql = string.Concat("SELECT G.nomefantasia AS nCliente,P.datapedido,P.dataentrega,P.totalcompra," +
                "P.vlrlucro,P.totalcompra-vlrlucro AS valorCompra,P.statuspedido,P.Obspedido AS valorCompra FROM pedidos P " +
                "LEFT JOIN GERAL G ON P.id_geral = G.id_recno");

            return ExecutaEPreencheDataset(sql);
        }

        public DataSet ConsultarClientePedido()
        {
            string sql = string.Concat(
                "SELECT CASE WHEN TPPESSOA='J' THEN nomefantasia ELSE RAZAOSOCIAL END as NOME_GRID,* FROM ",
                TabelasScript.TabelaPedidos, " ped INNER JOIN ",
                TabelasScript.TabelaGeral, " grl ON ped.id_geral = grl.id_recno"
            );

            return ExecutaEPreencheDataset(sql);
        }

        public DataSet ConsultarPedidosComFiltros(int pCliente, string pStatusPedido)
        {
            string sql = "select id_recno,dataconclusao,id_geral,totalvenda,vlrlucro,prazopgto,dataentrega,round(((vlrlucro * 100)/totalvenda),2) as perclucro from pedidos";

            if (pCliente >= 0)
                sql += " where id_geral=" + pCliente;

            if (!string.IsNullOrEmpty(pStatusPedido))
            {
                sql += sql.Contains("where") ? " and" : " where";
                sql += " statuspedido=" + pStatusPedido;
            }

            return ExecutaEPreencheDataset(sql);
        }

        public Pedidos ConsultarObjetoPedidos()
        {
            string sql = string.Concat("SELECT G.nomefantasia AS nCliente,P.datapedido,P.dataentrega,P.totalcompra,P.vlrlucro," +
                "P.totalcompra-vlrlucro AS valorCompra,P.statuspedido,P.Obspedido AS valorCompra FROM pedidos P LEFT JOIN GERAL G " +
                "ON P.id_geral = G.id_recno");

            Pedidos pedido = new Pedidos();
            DataSet ds = ExecutaEPreencheDataset(sql);
            pedido.CarregarPedidos(ds);

            return pedido;
        }

        public Pedido ConsultarClientePedidoPorId(int pId)
        {
            string sql = string.Concat("SELECT ped.id_recno,ped.id_geral, ped.datapedido,grl.razaosocial AS nCliente,ped.statuspedido,ped.prazopgto,ped.dataprev,",
                                        "ped.dataentrega,ped.dataconclusao,ped.obspedido,ped.totalcompra,ped.descpedido,ped.totalvenda,",
                                        "ped.vlrlucro FROM ", TabelasScript.TabelaPedidos, " ped INNER JOIN ", TabelasScript.TabelaGeral,
                                        " grl ON ped.id_geral = grl.id_recno");

            if (pId > 0)
                sql += " where ped.id_recno = " + pId.ToString();

            Pedido pedido = new Pedido();
            pedido.CarregaPedido(ExecutaEPreencheDataset(sql));
            return pedido;
        }

        //public DataSet ConsultarPedidosPorId(int pId) => ConsultarTabelaPorId(pId, TabelasScript.TabelaPedidos);

        public void InserirPedido(Pedido pPedido)
        {
            //TO DO: IMPLEMENTAR
            Dictionary<string, string> Campos = new Dictionary<string, string>
            {
                { "datapedido",     pPedido.DataPedido.ToString() },
                { "id_geral",       pPedido.IdPessoa.ToString() },
                { "statuspedido",   pPedido.StatusPedido.ToString() },
                { "prazopgto",      pPedido.PrazoPagamento.ToString() },
                { "dataprev",       pPedido.DataPrev.ToString("dd/MM/yyyy") },
                { "dataentrega",    pPedido.DataEntrega.ToString("dd/MM/yyyy") },
                { "dataconclusao",  pPedido.DataConclusao.ToString("dd/MM/yyyy") },
                { "obspedido",      pPedido.Observacoes },
                { "totalcompra",    pPedido.TotalPedido.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) },
                { "descpedido",     pPedido.ValorDesconto.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) },
                { "totalvenda",     pPedido.TotalGeral.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) },
                { "vlrlucro",       pPedido.ValorLucro.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) }
            };

            int IDPedido = ExecutarRetornaID(TabelasScript.ScriptInsert(TabelasScript.TabelaPedidos, Campos));

            foreach (ItemPedido item in pPedido.Itens)
            {
                Dictionary<string, string> CamposItens = new Dictionary<string, string>
                {
                    { "idpedido",  IDPedido.ToString() },
                    { "idproduto", item.Id_Produto.ToString() } ,
                    { "idunidade", item.Id_unidade.ToString() },
                    { "qtdeitem",  item.Quantidade.ToString() },
                    { "vlcusto",   item.Valor_custo.ToString().Replace(",",".") },
                    { "vltotitem", item.Total_item.ToString().Replace(",",".") } ,
                    { "vllucro",   item.Valor_lucro.ToString().Replace(",",".") }
                };

                ExecutarSemRetorno(TabelasScript.ScriptInsert(TabelasScript.TabelaItensPedido, CamposItens));
            }
        }

        public void AlterarPedido(Pedido pPedido)
        {
            //TO DO: IMPLEMENTAR
            Dictionary<string, string> pCampos = new Dictionary<string, string>
            {
                { "datapedido",     pPedido.DataPedido.ToString() },
                { "id_geral",       pPedido.IdPessoa.ToString() },
                { "statuspedido",   pPedido.StatusPedido.ToString() },
                { "prazopgto",      pPedido.PrazoPagamento.ToString() },
                { "dataprev",       pPedido.DataPrev.ToString("dd/MM/yyyy") },
                { "dataentrega",    pPedido.DataEntrega.ToString("dd/MM/yyyy") },
                { "dataconclusao",  pPedido.DataConclusao.ToString("dd/MM/yyyy") },
                { "obspedido",      pPedido.Observacoes },
                { "totalcompra",    pPedido.TotalPedido.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) },
                { "descpedido",     pPedido.ValorDesconto.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) },
                { "totalvenda",     pPedido.TotalGeral.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) },
                { "vlrlucro",       pPedido.ValorLucro.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) }
            };

            ExecutarSemRetorno(TabelasScript.ScriptUpdate(TabelasScript.TabelaPedidos, pPedido.ID, pCampos));
        }

        public void ExcluirPedido(int pId) => ExcluirRegistro(pId, TabelasScript.TabelaPedidos);

        #endregion Pedidos

        #region ItensPedido

        public List<ItemPedido> ConsultarItensPedido(int pId)
        {
            string sql = $"Select * from {TabelasScript.TabelaItensPedido} itp inner join {TabelasScript.TabelaProdutos} prd on itp.idproduto = prd.id_recno inner join {TabelasScript.TabelaUnidades} und on itp.idunidade = und.id_recno where idpedido={pId}";

            DataSet dsItens = ExecutaEPreencheDataset(sql);

            List<ItemPedido> itensPedido = new List<ItemPedido>();

            if (dsItens?.Tables.Count > 0 && dsItens.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in dsItens.Tables[0].Rows)
                {
                    ItemPedido item = new ItemPedido
                    {
                        Id_Produto = Convert.ToInt32(dr["idproduto"]),
                        Id_unidade = Convert.ToInt32(dr["idunidade"]),
                        DescrProduto = dr["nome_produto"].ToString(),
                        Unidade = dr["abrev_unid"].ToString(),
                        Quantidade = Convert.ToInt32(dr["qtdeitem"]),
                        Valor_custo = Convert.ToDecimal(dr["vlcusto"]),
                        Valor_lucro = Convert.ToDecimal(dr["vllucro"]),
                        Total_item = Convert.ToDecimal(dr["vltotitem"]),
                        Id_item = Convert.ToInt32(dr["id_recno"])
                    };

                    itensPedido.Add(item);
                }
            }
            return itensPedido;
        }

        #endregion ItensPedido

        #region CtasReceber

        public DataSet ConsultarContas() => ConsultarTabela(TabelasScript.TabelaCtasReceber);

        public DataSet ConsultarTiposConta() => ConsultarTabela(TabelasScript.TabelaTiposConta);

        public DataSet ConsultarContaPorId(int pId) => ConsultarTabelaPorId(pId, TabelasScript.TabelaCtasReceber);

        public void InserirConta(ContaAReceber pContaAReceber)
        {
            //TO DO: IMPLEMENTAR
            Dictionary<string, string> pCampos = new Dictionary<string, string>
            {
               {" id_pedido=",      pContaAReceber.IdPedido.ToString() },
               {" id_geral=",       pContaAReceber.IdGeral.ToString() },
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
               {" id_geral=",       pContaAReceber.IdGeral.ToString() },
               {" vlpedido=",       pContaAReceber.ValorPedido.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) },
               {" margempedido=",   pContaAReceber.MargemPedido.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) },
               {" dtvencto=",       pContaAReceber.DataVencimento.ToString("dd/MM/yyyy") },
               {" dtrecebto= ",     pContaAReceber.DataRecebimento.ToString("dd/MM/yyyy") }
            };

            ExecutarSemRetorno(TabelasScript.ScriptUpdate(TabelasScript.TabelaCtasReceber, pContaAReceber.ID, pCampos));
        }

        public void ExcluirConta(int pId) => ExcluirRegistro(pId, TabelasScript.TabelaCtasReceber);

        #endregion CtasReceber

        public DataSet ConsutarNCMs() => ConsultarTabela("tabelancm");

        #endregion Tabelas

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
            catch (Exception)
            {
                throw;
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

        private int ExecutarRetornaID(string pSql)
        {
            pSql += " RETURNING id_recno";
            int novoId;

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(pSql, conn))
                {
                    novoId = (int)cmd.ExecuteScalar();
                }
            }

            return novoId;
        }

        private void ExcluirRegistro(int pId, string pNomeTabela)
        {
            string sql = String.Format("DELETE FROM {0} WHERE id_recno={1}", pNomeTabela, pId);

            ExecutarSemRetorno(sql);
        }

        private DataSet ConsultarTabela(string pNomeTabela)
        {
            string sql = $"SELECT * FROM {pNomeTabela}";

            return ExecutaEPreencheDataset(sql);
        }

        private DataSet ConsultarTabelaPorId(int pId, string pNomeTabela)
        {
            string sql = $"SELECT * FROM {pNomeTabela} WHERE id_recno={pId}";

            return ExecutaEPreencheDataset(sql);
        }

        public void CriaTabelasBD()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                //  foreach (string script in new TabelasScript().Scripts)
                //new NpgsqlCommand(script, conn).ExecuteNonQuery();
            }
        }

        #endregion Privado

        #endregion Métodos
    }
}