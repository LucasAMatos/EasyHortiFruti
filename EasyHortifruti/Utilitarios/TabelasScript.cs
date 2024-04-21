using EasyHortifruti.DML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EasyHortifruti
{
    public class TabelasScript
    {
        public List<string> Scripts;

        public static string TabelaUnidades = "unidades";

        private string CreateUnidades = @"CREATE TABLE IF NOT EXISTS public.unidades
                                            (
                                                abrev_unid character varying(6)  NOT NULL,
                                                desc_unid character varying(20)  NOT NULL,
                                                obs_unid character varying(30)  NOT NULL,
                                                id_recno integer NOT NULL GENERATED ALWAYS AS IDENTITY 
	                                            ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
                                                CONSTRAINT id_recno PRIMARY KEY (id_recno)
                                                    INCLUDE(id_recno)
                                            )";

        public static string TabelaProdutos = "produtos";

        private string CreateProdutos = @"CREATE TABLE IF NOT EXISTS public.produtos
                                            (
                                                nome_produto character varying(30) ,
                                                pcocompra_produto numeric NOT NULL,
                                                pcovenda_produto numeric NOT NULL,
                                                margem_produto double precision NOT NULL,
                                                id_unidade integer NOT NULL,
                                                id_grupo integer NULL,
                                                id_subgrupo integer NULL,
                                                id_recno integer NOT NULL GENERATED ALWAYS AS IDENTITY 
	                                            ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
                                                CONSTRAINT uq_id_produto UNIQUE (id_recno),
                                                CONSTRAINT fk_grupo_id FOREIGN KEY (id_grupo)
                                                    REFERENCES public.grupos (id_recno),
                                                CONSTRAINT fk_subgrupo_id FOREIGN KEY (id_subgrupo)
                                                    REFERENCES public.subgrupos (id_recno),
                                                CONSTRAINT fk_unidade_id FOREIGN KEY (id_unidade)
                                                    REFERENCES public.unidades (id_recno)
                                            )";

        public static string TabelaPedidos = "pedidos";

        private string CreatePedidos = @"CREATE TABLE IF NOT EXISTS public.pedidos
                                            (
                                                datapedido date,
                                                statuspedido character varying(10)  NOT NULL,
                                                id_fonte integer NOT NULL,
                                                dataprev date NULL,
                                                prazopgto date NOT NULL,
                                                dataentrega date NOT NULL,
                                                dataconclusao date NULL,
                                                id_produto integer NOT NULL,
                                                qtdproduto character varying(6)  NOT NULL,
                                                vrcompra numeric NOT NULL,
                                                vrvenda numeric NOT NULL,
                                                totalvenda numeric NOT NULL,
                                                percentlucro character(3) NULL,
                                                id_recno integer NOT NULL GENERATED ALWAYS AS IDENTITY 
	                                            ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
                                                CONSTRAINT uq_id_pedidos UNIQUE (id_recno),
                                                CONSTRAINT fk_fonte_id FOREIGN KEY (id_fonte)
                                                    REFERENCES public.geral (id_recno),
                                                CONSTRAINT fk_produto_id FOREIGN KEY (id_produto)
                                                    REFERENCES public.produtos (id_recno)
                                            )";

        public static string TabelaGrupos = "grupos";

        private string CreateGrupos = @"CREATE TABLE IF NOT EXISTS public.grupos
                                            (
                                                nome_grupo character varying(15)  NOT NULL,
                                                obs_grupo character varying(50) NULL,
                                                margem_grupo double precision NULL,
                                                id_recno integer NOT NULL GENERATED ALWAYS AS IDENTITY 
	                                            ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
                                                CONSTRAINT uq_id_grupo UNIQUE (id_recno)
                                            )";

        public static string TabelaSubGrupos = "subgrupos";

        private string CreateSubGrupos = @"CREATE TABLE IF NOT EXISTS public.subgrupos
                                            (
                                                id_grupo integer NOT NULL,
                                                nome_subgrupo character varying(15)  NOT NULL,
                                                margem_subgrupo double precision NULL,
                                                id_recno integer NOT NULL GENERATED ALWAYS AS IDENTITY 
	                                            ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
                                                CONSTRAINT uq_idsubgrupo UNIQUE (id_recno),
                                                CONSTRAINT fk_grupo_id FOREIGN KEY (id_grupo)
                                                    REFERENCES public.grupos (id_recno)
                                            )";

        public static string TabelaGeral = "geral";

        private string CreateGeral = @"CREATE TABLE IF NOT EXISTS public.geral
                                            (
                                                tppessoa character(1)  NOT NULL,
                                                classificacao character varying(15)  NOT NULL,
                                                nomefantasia character varying(50)  NOT NULL,
                                                razaosocial character varying(50)  NOT NULL,
                                                contato character varying(15) NULL,
                                                dtnascaber date NULL,
                                                cnpj character(14)  NOT NULL,
                                                inscrestadual character(14) NULL,
                                                inscrmunicipal character(14) NULL,
                                                cpf character(11)  NOT NULL,
                                                rg character varying(15)  NOT NULL,
                                                orgexpedidor character(3) NULL,
                                                ufrgexped character(2) NULL,
                                                dddfone character(2) NULL,
                                                fone character(9) NULL,
                                                dddcel character(2)  NOT NULL,
                                                celular character(9)  NOT NULL,
                                                cep character(8)  NOT NULL,
                                                logradouro character varying(30)  NOT NULL,
                                                numero character varying(10)  NOT NULL,
                                                complemento character varying(30) NULL,
                                                bairro character varying(30)  NOT NULL,
                                                cidade character varying(30)  NOT NULL,
                                                uf character(2)  NOT NULL,
                                                pontoreferencia character varying(30) NULL,
                                                email character varying(30) NULL,
                                                id_recno integer NOT NULL GENERATED ALWAYS AS IDENTITY 
	                                            ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
                                                CONSTRAINT uq_id_recno UNIQUE (id_recno)
                                            )";

        public static string TabelaCtasReceber = "ctasReceber";

        private string CreateCtasReceber = @"CREATE TABLE IF NOT EXISTS public.ctasreceber
                                            (
                                                id_pedido integer NOT NULL,
                                                id_fonte integer NOT NULL,
                                                vlpedido numeric(2,0) NOT NULL,
                                                margempedido double precision NOT NULL,
                                                dtvencto date NOT NULL,
                                                dtrecebto date NOT NULL,
                                                id_recno integer NOT NULL GENERATED ALWAYS AS IDENTITY 
                                                ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
                                                CONSTRAINT fk_fonte_id FOREIGN KEY (id_fonte)
                                                    REFERENCES public.geral (id_recno),
                                                CONSTRAINT fk_pedido_id FOREIGN KEY (id_pedido)
                                                    REFERENCES public.pedidos (id_recno)
                                            )";

        public TabelasScript()
        {
            Scripts = new List<string>
            {
                CreateUnidades,
                CreateGeral,
                CreateGrupos,
                CreateSubGrupos,
                CreateProdutos,
                CreatePedidos,
                CreateCtasReceber
            };
        }

        public static string ScriptInsert(string pTabela, Dictionary<string, string> pCampos)
        {
            return string.Concat(
                "INSERT INTO ", pTabela,
                    " (" + string.Join(", ", pCampos.Keys),
                ") VALUES",
                    " ('" + string.Join("', '", pCampos.Values), "')");
        }
        public static string ScriptUpdate(string pTabela, int pID, Dictionary<string, string> pCampos)
        {
            string retorno = string.Concat("UPDATE ", pTabela, " SET ");

            foreach (KeyValuePair<string, string> keyValuePair in pCampos)
            {
                retorno += string.Concat("\n" + keyValuePair.Key, "='", keyValuePair.Value, "', ");
            }

            retorno = string.Concat(retorno.Substring(0, retorno.Length - 2), " WHERE ID_RECNO =", pID.ToString());

            return retorno;
        }
    }
}
