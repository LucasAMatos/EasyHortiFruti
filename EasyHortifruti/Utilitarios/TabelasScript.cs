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
                                                classificacao INTEGER NOT NULL DEFAULT 0,
                                                nomefantasia character varying(50)  NOT NULL,
                                                razaosocial character varying(50)  NOT NULL,
                                                estadocivil INTEGER NOT NULL DEFAULT 0,
                                                contato character varying(15) NULL,
                                                dtnascaber date NULL,
                                                prazoPgto INT,
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

        private readonly string CreateCtasReceber = @"CREATE TABLE IF NOT EXISTS public.ctasreceber
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

        public static string TabelaNCM = "tabelancm";

        public readonly string CreateTabelaNCM = @"create table IF NOT EXISTS public.tabelancm 
                                                    (
                                                    	numero_ncm varchar(8),
                                                    	descricao_ncm varchar(255),
                                                    	CONSTRAINT tabelancm_pkey PRIMARY KEY (numero_ncm)
                                                    )";

        public readonly string ChamaProcNCM = "SELECT verificar_e_incluir()";

        public readonly string ProcTabelaNCM = 
            @"CREATE OR REPLACE FUNCTION verificar_e_incluir()
            RETURNS VOID AS $$
            BEGIN
                -- Verificar se há registro na tabela
                IF NOT EXISTS (SELECT 1 FROM tabelancm) THEN
                    -- Se não houver registro, incluir um novo
                    INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1012900','Cavalos vivos,exceto reprodutores de raca pura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1013000','Asininos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1019000','Outros asininos e muares,vivos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1022110','Bovinos reprodutores,de raca pura,prenhe ou com cria ao pe 4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1022190','Outros bovinos reprodutores,de raca pura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1022911','Outros bovinos para reprodução, prenhe ou com cria ao pe 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1022919','Outros bovinos domésticos para reprodução 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1022990','Outros bovinos domésticos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1023110','Búfalos reprodutores,de raca pura, prenhe ou com cria ao pe'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1023190','Outros búfalos reprodutores,de raca pura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1023911','Outros búfalos para reprodução, prenhe ou com cria ao pe 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1023919','Outros búfalos para reprodução 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1023990','Outros búfalos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1029000','Outros animais vivos da espécie bovina 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1031000','Suinos  reprodutores de raça pura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1039100','Outros suinos,vivos,de peso inferior a 50kg 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1039200','Outros suinos,vivos,de peso igual ou superior a 50kg 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1041011','Ovinos reprodutores,de raca pura,prenhe ou c/cria ao pe 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1041019','Outros ovinos,reprodutores,de raca pura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1041090','Outros ovinos,vivos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1042010','Caprinos reprodutores,de raca pura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1042090','Outros caprinos,vivos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1051110','Galos e galinhas,p<=185g,de linha pura/hibrida, p/reprod 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1051190','Outros galos e galinhas,vivos,de peso n/superior a 185g 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1051200','Peruas e perus,vivos,de peso nao superior a 185g 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1051300','Patos vivos,de peso<=185g 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1051400','Gansos, vivos,de peso<=185g 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1051500','Galinhas dangola (pintadas); vivos,de peso<=185g 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1059400','Outros galos e galinhas,vivos de peso>185g 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1059900','Patos,gansos,perus,peruas,pintadas,vivos,de peso>185g 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1061100','Primatas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1061200','Baleias, golfinhos e botos, peixes-boi e digongos, otárias e'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1061300','Camelos e outros camelídeos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1061400','Coelhos e lebres 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1061900','Outros animais mamíferos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1062000','Répteis incluídas as serpentes e as tartarugas marinhas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1063100','Aves de rapina 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1063200','Psitaciformes (incluídos os papagaios, os periquitos, as ara'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1063310','Avestruzes para reprodução 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1063390','Outros avestruzes, emus 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1063900','Outras aves 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1064100','Abelhas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1064900','Outro insetos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('1069000','Outros animais vivos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2011000','Carcacas e meias carcacas,de bovino,frescas ou refriger 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2012010','Quartos dianteiros,de bovino,n/desossad. frescos/refrig. 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2012020','Quartos traseiros,de bovino,n/desossados, frescos/refrig 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2012090','Outs.carnes de bovino,nao desossadas, frescas ou refrig. 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2013000','Carnes de bovino,desossadas,frescas ou refrigeradas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2021000','Carcacas e meias-carcacas,de bovino, congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2022010','Quartos dianteiros,de bovino,nao desossados, congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2022020','Quartos traseiros,de bovino,nao desossados, congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2022090','Outras carnes de bovino,nao desossadas, congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2023000','Carnes de bovino,desossadas,congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2031100','Carcacas e meias-carcacas,de suino,frescas ou refriger. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2031200','Pernas,pas,etc.de suino,n/desossados,frescos ou refrig. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2031900','Outras carnes,de suino,frescas ou refrigeradas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2032100','Carcacas e meias-carcacas,de suino, congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2032200','Pernas,pas e pedacos,de suinos,n/desossados, congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2032900','Outras carnes,de suino,congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2041000','Carcacas e meias-carcacas,de cordeiro, frescas ou refrig 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2042100','Carcacas e meias-carcacas,de ovino,frescas ou refriger. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2042200','Outras carnes,de ovino,nao desossadas, ]frescas ou refrig 4.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2042300','Carnes de ovino,desossadas,frescas ou refrigeradas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2043000','Carcacas e meias-carcacas,de cordeiro, congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2044100','Carcacas e meias-carcacas,de ovino, congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2044200','Outras carnes de ovino,nao desossadas, congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2044300','Carnes de ovino,desossadas,congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2045000','Carnes de caprino,frescas,refrigeradas ou congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2050000','Carnes de cavalo,asinino e muar,frescas, refrig.ou cong. 13.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2061000','Miudezas comestiveis,de bovino,frescas ou refrigeradas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2062100','Linguas de bovino,congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2062200','Figados de bovino,congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2062910','Rabos de bovino,congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2062990','Outras miudezas comestiveis,de bovino, congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2063000','Miudezas comestiveis,de suino,frescas ou refrigeradas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2064100','Figados de suino,congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2064900','Outras miudezas,comestiveis,de suino, congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2068000','Miudezas comestiveis,de ovino,etc. frescas/refrigeradas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2069000','Miudezas comestiveis,de ovino,caprino, etc.congeladas 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2071100','Carnes de galos/galinhas,n/cort.pedacos, frescas/refrig. 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2071200','Carnes de galos/galinhas,n/cortadas em pedacos,congel. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2071300','Pedacos e miudezas,de galos/galinhas, frescos/refriger. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2071400','Pedacos e miudezas,comest.de galos/galinhas, congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2072400','Carnes de peruas/perus,n/cort.pedacos, frescas/refriger. 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2072500','Carnes de peruas/perus,n/cortadas em pedacos,congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2072600','Carnes de peruas/perus,em pedacos,miudez. frescos/refrig 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2072700','Carnes de peruas/perus,em pedacos e miudezas,congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2074100','Carnes de patos, n/cort.em pedacos, frescas/refriger. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2074200','Carnes de patos,gansos,etc.n/cort.em pedacos,congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2074300','Figados gordos,de patos (foie gras);  frescos/refrig. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2074400','Outs.carnes/miudezas,de patos,frescas, refrig 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2074500','Outs.carnes,miudezas,de patos, congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2075100','Carnes de gansos n/cort.em pedacos, frescas/refriger. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2075200','Carnes de  gansos n/cort.em pedacos,congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2075300','Figados gordos,de gansos (foie gras);  frescos/ refrig. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2075400','Outs.carnes/miudezas,de gansos, frescas, refrig 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2075500','Outs.carnes,miudezas,de gansos, congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2076000','Carnes e miudezas comestíveis de galinhas dangola (pintadas)'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2081000','Carnes/miudezas,de coelhos/lebres,frescas/ refrig/congel 13.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2083000','Carnes e miudezas,de primatas,frescos/ refrig/congel 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2084000','Carnes e miudezas,de baleias,golfinhos e botos, peixes-boi e'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2085000','Carnes e miudezas,de répteis(incluidas as serpentes e as tar'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2086000','Carnes e miudezas,de camelos e outros camelídeos, frescos/ r'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2089000','Carnes e miudezas,de outs.animais,frescos/ refrig/congel 13.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2091011','Toucinho de porco sem partes magras, fresco/ refrigerado/ co'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2091019','Toucinho sem partes magras,salgado/ salmoura/ seco/defum. 4.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2091021','Gordura de porco,fresca,refrigerada ou congelada 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2091029','Gordura de porco,n/fundida,salgada,em salmoura,seca,etc 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2099000','Gordura de aves,n/fundida,fresca, refrigerada,congel.etc 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2101100','Pernas/pas/pedacos,de suino,n/desossados, salgados,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2101200','Barrigas e peitos,entremeados,de suino,salgados,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2101900','Outs.carnes de suino,salgadas ou em salmoura,secas,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2102000','Carnes de bovinos,salgadas/em salmoura/ secas/defumadas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2109100','Carnes e miudezas,de primatas,salgados,etc. 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2109200','Carnes e miudezas,de baleias,golfinhos e botos, peixes-boi e'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2109300','Carnes e miudezas,de répteis(incluidas as serpentes e as tar'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('2109900','Carnes e miudezas,de outros animais,salgados, etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3011110','Aruanã (peixe ornamental) 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3011190','Outros peixes ornamentais, vivos,  de água doce 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3011900','Outros peixes ornamentais vivos 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3019110','Trutas (salmo trutta e oncorhynchus); para reproducao 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3019190','Outros trutas (salmo trutta e oncorhynchus); vivas 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3019210','Enguias (anguilla spp.) para reproducao 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3019290','Outros enguias (anguilla spp.) vivas 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3019310','Carpas para reproducao 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3019390','Outros carpas vivas 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3019410','Atuns-azuis (thunnus thynnus, thunnus orientalis) para repro'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3019490','Outros atuns-azuis (thunnus thynnus, thunnus orientalis) 13.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3019510','Atuns-do-sul (thunnus maccoyii) para reprodução 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3019590','Outros  atuns-do-sul (thunnus maccoyii) 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3019911','Tilapias,peixes para reproducao 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3019912','Esturjões,peixes para reproducao 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3019919','Outros peixes vivos para reprodução 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3019991','Tilapias,peixes vivos 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3019992','Esturjões,peixes vivos 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3019999','Outros peixes vivos 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3021100','Trutas frescas,refrig.exc.files,outs. carnes, figados,etc 4.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3021300','Salmoes-do-pacifico, frescos,refrig. exc.files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3021400','Salmoes-do-atlantico, frescos,refrig. exc.files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3021900','Outros salmonideos frescos,refrig.exc. files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3022100','Linguados-gigantes,frescos,refrig.exc. files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3022200','Solhas ou patrucas,frescas,refrig.exc. files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3022300','Linguados frescos,refrig.exc.files,outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3022400','Pregado (psetta maxima); frescos,refrig.exc. files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3022900','Outros peixes chatos,frescos,refrig.exc. files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3023100','Atuns-brancos ou germoes,frescos/refriger. exc.files,etc 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3023200','Albacoras/atuns barbat.amarela,frescas/ refrig. exc.files 4.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3023300','Bonitos-listrados,etc.frescos,refrig.exc. files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3023400','Albacoras-bandolim (patutos) thunnus thinnus 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3023500','Atuns azuis (thunnus thinnus (…) 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3023600','Atuns do sul thunnus maccoyii 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3023900','Outs.atuns frescos,refrig.exc.files, outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3024100','Arenques frescos/refrigerados,exc. files,outs.carnes,etc 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3024210','Anchoitas frescos/refrigerados,exc. files,outs.carnes,etc 4.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3024290','Outras anchovas frescos/refrigerados,exc. files,outs.carnes,'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3024300','Sardinhas frescos/refrigerados,exc. files,outs.carnes,etc 4.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3024400','Cavalinhas frescos/refrigerados,exc. files,outs.carnes,etc 4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3024500','Chicharros frescos/refrigerados,exc. files,outs.carnes,etc 4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3024600','Bijupirás frescos/refrigerados,exc. files,outs.carnes,etc 4.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3024700','Espadartes frescos/refrigerados,exc. files,outs.carnes,etc 4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3025100','Bacalhau do atlantico (...);  bacalhau da groelandia (…) e ba'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3025200','Bacalhau haddoch ou lubina, frescos/refrigerados, exc.files,'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3025300','Bacalhau saithe frescos/refrigerados, exc.files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3025400','Merluzas e abróteas, frescos/refrigerados, exc.files,etc. 4.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3025500','Merluza do alasca, frescos/refrigerados, exc.files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3025600','Verdinhos (…);  frescos/refrigerados, exc.files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3025900','Outros peixes das fam. bregmacerotidae, gadidae, etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3027100','Tilápias frescas,refrig.exc.files,outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3027210','Bagres (...); frescas,refrig.exc.files,outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3027290','Outros bagres, frescas,refrig.exc.files, outs. carnes,etc. 4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3027300','Carpas,frescas,refrig.exc.files,outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3027400','Enguias, frescas,refrig.exc.files,outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3027900','Outros,frescas,refrig.exc.files,outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028100','Esqualos frescos,refrig.exc.files,outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028200','Raias, frescos,refrig.exc.files, outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028310','Merluzas-negras (dissostichus eleginoides) 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028320','Merluzas antárticas (dissostichus mawsoni) 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028400','Robalos, frescos,refrig.exc.files, outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028500','Pargos ou sargos, frescos,refrig.exc.files, outs. carnes,etc'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028911','Agulhões (stiophorus spp., tetrapturus spp., makaira spp.) 4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028912','Pargos (lutjanus purpureus0 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028921','Cherne-poveiro (polyprion americanus);  frescos ou refrigerad'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028922','Garoupas (acanthistius spp) 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028923','Esturjões (ascipenser baeri) 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028924','Peixes-rei (atherindae spp) 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028931','Curimatas (prochilodus spp.);  fresco ou refrigerado 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028932','Tilapias, fresco ou refrigerado 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028933','Surubins (pseudoplatystoma spp.);  fres. ou refrig. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028934','Traíras (hoplias malabaricus & h. cf. lacerdae) 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028935','Piaus (leporinus spp.);  fresco ou refrigerado 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028936','Tainhas, fresco ou refrigerado 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028937','Pirarucu (arapaima gigas);  fresco ou refrigerado 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028938','Pescadas, fresco ou refrigerado 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028941','Piramutabas, fresco ou refrigerado 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028942','Douradas, fresco ou refrigerado 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028943','Pacus, fresco ou refrigerado 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028944','Tambaquis, fresco ou refrigerado 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028945','Tambacu fresco ou resfriado 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3028990','Outs.peixes frescos,refrig.exc.files, outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3029000','Figados,ovas e semen,de peixes,frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3031100','Salmoesvermelhos,congelados,exc.files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3031200','Oiutros salmoes do pacífico ,congelados, exc.files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3031300','Salmoes-do-atlantico e danubio,congelados, exc.files,etc 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3031400','Trutas (salmo trutta,etc.) congeladas, exc.files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3031900','Outs.salmonideos congelados,exc.files,outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3032300','Tilapias 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3032410','Bagres congelados,exc.files,outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3032490','Outros bagres congelados,exc.files,outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3032500','Carpas congelados,exc.files,outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3032600','Enguias congeladas,exc.files,outs.carnes, figados,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3032900','Outros tilapias, bagres, perca-do-nilo (...);  congeladas,exc'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3033100','Linguados-gigantes congelados,exc.files. outs. carnes,etc 4.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3033200','Solhas ou patrucas,congeladas,exc.files, outs. carnes,etc 4.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3033300','Linguados congelados,exc.files,outs.carnes, figados,etc. 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3033400','Pregados,congelados,exc.files, outs. carnes,etc 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3033900','Outs.peixes chatos,congelados,exc.files, outs. carnes,etc 4.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3034100','Albacoras brancas,congelados, exc. files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3034200','Albacoras/laje,congeladas, exc.files,etc 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3034300','Bonitos-listrados,etc.congelados, exc.files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3034400','Albacoras-bandolin (patudos) congelados, exc.files, outs. ca'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3034500','Atuns-azuis (...);  congelados,exc.files, outs.carnes, figado'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3034600','Atuns do sul congelados,exc.files, outs. carnes,figados,etc'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3034900','Outs.atuns congelados,exc.files,outs. carnes, figados,etc 4.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3035100','Arenques congelados,exc.files,outs. carnes, figados,etc. 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3035300','Sardinhas, (…) anchovetas, congeladas, exc.files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3035400','Cavalinhas,congeladas, exc. files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3035500','Chicharros,congeladas, exc. files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3035600','Bijupirás,congeladas, exc. files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3035700','Espadartes congelados,exc.files,outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3036300','Bacalhau do atlantico,bacalhau da groelandia (...);  congelad'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3036400','Haddocks congelados,exc.files,outs. carnes, figados,etc 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3036500','Saithe congelados,exc.files,outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3036600','Merluzas e abroteas,congeladas, exc.files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3036700','Merluzas do alasca,congeladas, exc.files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3036800','Verdinhos,congelados, exc.files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3036910','Merluzas rosadas congelados,exc.files,outs. carnes, etc. 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3036990','Outros peixes das famílias bregmacerotidae (...);  congelados'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038111','Tubaroes-azuis inteiros,congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038112','Tubaroes-azuis, congelad.eviscerad. s/cabeca, s/barbatana 4.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038113','Tubaroes-azuis,congelados,em pedacos, com pele 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038114','Tubaroes-azuis,congelados,em pedacos, sem pele 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038119','Outros  tubaroes-azuis congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038190','Outs.peixes esqualos,congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038200','Raias,congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038311','Merluzas negras congelados,exc.files, outs. carnes, etc. evi'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038312','Merluzas negras congelados,exc.files, outs. carnes,etc. cabe'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038319','Outras merluzas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038321','Meluzas do antartico evisceradas, sem cabeça e sem cauda 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038322','Merluzas do antartico – cabeças 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038329','Outras merluzas do antartico 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038400','Robalos congeladas,exc. files,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038910','Corvinas congeladas,exc.files,outs.carnes, figados,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038920','Pescadas congeladas,exc.files,outs.carnes, figados,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038931','Agulhões congelados,exc.files,outs. carnes, etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038932','Pargos congelados,exc.files,outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038933','Peixes-sapo congelados,exc.files,outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038941','Chernes-poveiro congelados,exc.files,outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038942','Garoupas congelados,exc.files,outs. carnes, etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038943','Tainhas congelados,exc.files,outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038944','Esturjões congelados,exc.files,outs. carnes, etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038945','Peixes-rei congelados,exc.files,outs. carnes, etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038946','Nototenias congelados,exc.files,outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038951','Curimatãs congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038952','Tilapias congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038953','Surubins congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038954','Trairas congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038955','Piaus congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038956','Pirarucus congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038957','Anchoitas congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038961','Piramutabas congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038962','Douradas congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038963','Pacus congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038964','Tambaquis congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038965','Tambacus congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3038990','Outs.peixes congelados,exc.files,outs. carnes,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3039000','Figados,ovas e semen,de peixes,congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3043100','Files de tilapias,frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3043210','Files de bagres,frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3043290','Files de outros bagres,frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3043300','Files de perca-do-nilo,frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3043900','Outros files,frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3044100','Files e outs.carnes de salmões do pacífico,frescos ou refrig'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3044200','Files e outs.carnes de trutas,frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3044300','Files e outs.carnes de peixes chatos,frescos ou refrigerados'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3044400','Files e outs.carnes de peixes da família  das bregmacerotida'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3044500','Files e outs.carnes de espadarte,frescos ou refrigerados 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3044600','Files e outs.carnes de merluza-negra e merluza-antártica,fre'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3044910','Files e outs.carnes de cherne-poveiro, frescos ou refrigerad'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3044920','Files e outs.carnes de garoupa,frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3044990','Files e outs.carnes de outros peixes,frescos ou refrigerados'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3045100','Files e outs.carnes de tilápias,frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3045200','Files e outs.carnes de salmonídeos,frescos ou refrigerados 4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3045300','Files e outs.carnes de peixes da família  das bregmacerotida'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3045400','Files e outs.carnes de espadarte,frescos ou refrigerados 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3045500','Files e outs.carnes de merluza-negra e merluza-antártica,fre'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3045900','Files e outs.carnes de peixes,frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3046100','Files de tilápias,congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3046210','Files de bagre,congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3046290','Files de outros bagres,congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3046300','Files de perca-do-nilo,congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3046900','Files de outras tilápias,congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3047100','Bacalhau do atlantico,bacalhau da groelandia (...);  files co'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3047200','Haddocks,  files  congelados. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3047300','Saithe, files  congelados. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3047400','Merluzas e abroteas,  files congelados. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3047500','Merluzas do alasca,  files,  congelados. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3047900','Outros peixes das famílias bregmacerotidae (...);   files, co'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3048100','Salmões do pacífico (...);   files, congelados. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3048200','Trutas,  files, congelados. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3048300','Peixes chatos,  files congelados. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3048400','Espadarte,  files congelados. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3048510','Merluza negra,  files congelados. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3048520','Merluza antártica,  files congelados. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3048600','Arenques,  files, congelados. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3048700','Atuns (...);  bonito listrado (...);   files, congelados. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3048910','Pargo, files congelados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3048920','Cherne-poveiro,  files, congelados. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3048930','Garoupas,  files, congelados. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3048940','Tubarão azul,  files, congelados. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3048990','Files de outros peixes, congelados. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3049100','Outros carnes de espadartes,congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3049211','Outros carnes de merluzas negras, congeladas – bochechas (ch'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3049212','Outros carnes de merluzas negras, congeladas – colares (coll'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3049219','Outros carnes de merluzas negras,congeladas – outros 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3049221','Outros carnes de merluzas do antártico ,congeladas – bochech'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3049222','Outros carnes de merluzas do antartico,congeladas – colares'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3049229','Outros carnes de merluzas doantartico,congeladas – outros 4.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3049300','Outros carnes de tilápias,congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3049400','Outros carnes de merluza do alasca,congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3049500','Outros carnes de peixes da família das bregmacerotidae (...)'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3049900','Outros carnes de peixes,congeladas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3051000','Farinhas,pos e pellets de peixes, próprios p/ alimentacao  h'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3052000','Figados,ovas e semen,de peixes,secos, defumados,etc. 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3053100','Tilápias (...); secos, salgados/ salmoura, n/defum 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3053210','Bacalhaus do atlantico, bacalhau da groelândia (…);  secos, s'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3053220','Saithes(polachius virens);  secos, salgados/ salmoura, n/defu'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3053290','Outros peixes da família das bregmacerotidae (...);  secos, s'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3053910','Ling(molva molva) e zarbo, secos, salgados/ salmoura, n/defu'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3053990','Outros files de peixes,secos, salgados/ salmoura,n/defum 13.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3054100','Salmoes-do-pacifico,do atlantico e do danubio, defumados, me'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3054200','Arenques defumados,mesmo em files 14.69'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3054300','Trutas defumadas,mesmo em files 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3054400','Tilápias defumadas,mesmo em files 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3054910','Bacalhaus (gadus) defumados,mesmo em files 14.69'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3054920','Saithes (pollachius virens);  lings (molva molva) e zarbos (b'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3054990','Outros peixes defumados,mesmo em files 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3055100','Bacalhaus (gadus) secos,mesmo salgados mas n/defumados 14.69'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3055910','Bacalhaus (gadidae) secos,mesmo salgados,nao defumados 14.69'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3055990','Outs.peixes secos,mesmo salgados mas nao defumados 14.69'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3056100','Arenques salgados,nao secos,nao defumados e em salmoura 14.6'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3056200','Bacalhaus (gadus) salgados,n/secos, n/defumados,salmoura 14.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3056300','Anchovas salgadas,nao secas,nao defumadas e em salmoura 13.4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3056400','Tilápias, bagres, carpas (…) salgados n/secos, n/defum e em'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3056910','Saithes(polachius virens); lings e zarbos(brosme brosme) 13.4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3056990','Outros peixes salgados n/secos, n/defum e em salmoura 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3057100','Barbatanas de tubarão 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3057200','Cabeças, caudas, bexigas, natatórias, de peixes 14.69'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3057900','Outros desperdícios comestíveis de peixes secos,mesmo salgad'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3061110','Lagostas inteiras(palinurus,panulirus e jasus) congeladas 13'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3061190','Outras lagostas (palinurus,panulirus e jasus) congeladas 13.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3061200','Lavagantes (homards)(homarus spp) congelados 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3061400','Caranguejos congelados 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3061500','Lagostas norueguesas congeladas 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3061610','Camaroes de água fria inteiros congelados 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3061690','Outros camaroes de água fria congelados 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3061710','Outros camaroes inteiro congelados 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3061790','Outros camaroescongelados 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3061910','Camaroes krillcongelados 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3061990','Outs.crustaceos congel.incl.farinhas,etc. p/alim.humana 13.4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3062100','Lagostas (palinurus,panulirus e jasus) nao congeladas 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3062200','Lavagantes (homards)(homarus spp) nao congelados 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3062400','Caranguejos nao congelados 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3062500','Lagosta norueguesa nao congel. 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3062600','Camaroes de água fria não congelados 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3062700','Outros camaroes nao congelados 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3062910','Lagostas de água doce não congeladas (cherax quadricarinatus'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3062990','Outs.crustaceos nao congel.incl. farinhas p/alim.humana 13.4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3071100','Ostras vivas,frescas,refrigeradas 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3071900','Ostras congeladas,secas,etc. 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3072100','Vieiras,outs.mariscos (pecten,etc) vivos, frescos,refrig 13.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3072900','Vieiras,outs.mariscos (pecten,etc) congelados,secos,etc 13.4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3073100','Mexilhoes (mytilus,perna) vivos,frescos, refrigeraos 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3073900','Mexilhoes (mytilus,perna) congelados,secos, algados,etc 13.4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3074100','Sibas,sepiolas,potas e lulas,vivos,frescos, refrigerados 13.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3074911','Lulas (ommastrephes,loligo,etc);  congelados 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3074919','Sibas (chocos)(etc) e sepiolas,congelados 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3074990','Sibas,sepiolas,potas e lulas,secos,salgados, em salmoura 13.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3075100','Polvos (octopus spp) vivos,frescos ou refrigerados 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3075910','Polvos (octopus spp) congelados 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3075990','Polvos (octopus spp) secos,salgados ou em salmoura 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3076000','Caracois,exceto.os do mar,vivos,frescos, refrigerados,etc. 1'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3077100','Ameijoas, berbigões e arcas (...); vivos, frescos, refrig. 13'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3077900','Ameijoas, berbigões e arcas (...);  congelados,secos,etc. 13.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3078100','Abalones,vivos,frescos,refrig. 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3078900','Abalones ,congelados,secos,etc. 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3079100','Outs.moluscos,invertebr.aquaticos,vivos, frescos ,refrig. 13'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3079900','Outs.moluscos,invertebr.aquaticos,congelados,secos,etc. 13.4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3081100','Pepinos-do-mar, vivos, frescos ou refrigerados 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3081900','Pepinos-do-mar,congelados,secos,etc. 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3082100','Ouriços-do-mar, vivos, frescos ou refrigerados 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3082900','Ouriços do mar,congelados,secos,etc. 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3083000','Medusas (águas vivas) (…) 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('3089000','Outros inveetebrados aquáticos, exceto crustáceos e moluscos'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4011010','Leite uht,cont.materia gorda<=1%,nao concentrado,n/adoc 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4011090','Outs.leites e cremes,mater.gorda <=1%, n/concentr.n/adoc. 4.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4012010','Leite uht,1%<materia gorda<=6%,nao  concentrado,n/adoc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4012090','Outs.leites e cremes,1%<mat.gorda<=6%,n/ concentr.n/adoc 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4014010','Leite cont.materia gorda >6%, mas não superior a 10%, não co'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4014021','Creme de leite,uht,materia gorda>6% mas não superior a 10%,'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4014029','Outs.cremes de leite,materia gorda>6% mas não superior a 10%'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4015010','Leite cont.materia gorda>10%,nao concentrado, n/adocicado 4.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4015021','Creme de leite,uht,materia gorda>10%,nao concentr.n/adoc 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4015029','Outs.cremes de leite,materia gorda>10%, n/concentr.n/adoc 4.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4021010','Leite em po,mat.gorda<=1,5%,arsenio<5ppm, concentr.adoc. 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4021090','Outs.leites,cremes,em po,mat.gorda<=1,5%, concentr.adoc. 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4022110','Leite integral,em po,materia gorda>1.5%, concentr.n/adoc 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4022120','Leite parc.desnat.em po,mat.gorda>1.5%, concentr.n/adoc. 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4022130','Creme de leite,em po,materia gorda>1.5%, concentr.n/adoc 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4022910','Leite integral,em po,etc.materia gorda>1.5%, adocicado 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4022920','Leite parcialm.desnatado,em po,materia gorda>1.5%,adoc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4022930','Creme de leite,em po,etc.materia gorda>1.5%, adocicado 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4029100','Outs.leites,cremes de leite,concentrados, n/adocicados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4029900','Outs.leites,cremes de leite,concentrados, adocicados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4031000','Iogurte 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4039000','Leitelho,leite,creme de leite,coalhados, fermentados,etc 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4041000','Soro de leite,modificado ou nao,mesmo concentrado,adoc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4049000','Outs.prods.constituidos do leite,mesmo adocicados,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4051000','Manteiga 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4052000','Pastas de espalhar (barrar) de prods. proven. do leite 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4059010','Oleo butirico de manteiga (butter oil) 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4059090','Outros materias gordas provenientes do leite 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4061010','Queijo tipo mussarela,fresco (nao curado) 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4061090','Outs.queijos frescos (nao curados); incl. requeijao,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4062000','Queijos ralados ou em po,de qualquer tipo 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4063000','Queijos fundidos,exceto ralados ou em po 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4064000','Queijos de pasta mofada (azul) 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4069010','Queijos cont.teor de umidade<36%,em peso (massa dura) 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4069020','Queijos cont.36%<=teor de umidade<46%,(massa semidura) 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4069030','Queijos cont.46%<=teor de umidade<55%,(massa macia) 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4069090','Outros queijos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4071100','Ovos de galinha,para incubacao 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4071900','Ovos de outs.aves,para incubacao 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4072100','Outs.ovos de aves,com casca,frescos, aves da espécie gallus'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4072900','Outs.ovos de aves,com casca,frescos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4079000','Outs.ovos de aves,com casca,conservados,cozidos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4081100','Gemas de ovos,secas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4081900','Outras gemas de ovos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4089100','Ovos de aves,sem casca,secos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4089900','Outs.ovos de aves,sem casca 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4090000','Mel natural 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('4100000','Outros produtos comestiveis de origem animal 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5010000','Cabelos em bruto e desperdicios de cabelo 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5021011','Cerdas de porco,lavadas,alvejadas ou desengorduradas 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5021019','Outros cerdas de porco e seus desperdicios 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5021090','Cerdas de javali e seus desperdicios 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5029010','Pelos de texugo e outs.pelos p/escovas, pinceis,etc. 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5029020','Desperdicios de pelos 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5040011','Tripas de bovinos,frescas,refrig.congel. salg.defumadas 13.4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5040012','Tripas de ovinos,frescas,refrig.congel. salgad.defumadas 13.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5040013','Tripas de suinos,frescas,refrig.congel. salgad.defumadas 13.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5040019','Tripas de outs.animais,exc.peixes,frescas, refrig.etc. 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5040090','Bexigas e estomagos,de animais,exc.peixes, frescas,etc. 13.4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5051000','Penas para enchimento ou estofamento,e penugem 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5059000','Peles e outs.partes de aves,com suas penas, penugem,etc. 13.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5061000','Osseina e ossos acidulados 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5069000','Outs.ossos e nucleos corneos,em bruto, desengord.etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5071000','Marfim,seus pos e desperdicios 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5079000','Carapacas de tartarugas,chifres,galhadas, cascos,etc. 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5080000','Coral,conchas,carapacas de moluscos,etc.em bruto,prepar 13.4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5100010','Pancreas de bovinos,p/prepar.prod. farmaceut.frescas,etc 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5100090','Outs.substancias de animais,p/prepar.prods. farmaceuts. 13.4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5111000','Semen de bovino 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5119110','Ovas de peixes,fecundadas para reproducao 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5119190','Outs.prods.de peixes,etc.improprios p/aliment.humana 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5119910','Embrioes de animais 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5119920','Semen animal (exceto bovino) 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5119930','Ovos de bicho-da-seda 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5119991','Crinas e seus desperdícios, mesmo em mantas, com ou sem supo'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('5119999','Outs.prods.de animais,improprios p/alimentacao humana 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6011000','Bulbos,tuberculos,rizomas,etc.em repouso vegetativo 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6012000','Bulbos,tuberculos,etc.em veget.em flor,muda de chicoria 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6021000','Estacas nao enraizadas e enxertos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6022000','Arvores,arbustos e silvados,de frutos comestiveis 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6023000','Rododendros e azaleias,enxertados ou nao 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6024000','Roseiras,enxertadas ou nao 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6029010','Micelios de cogumelos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6029021','Mudas de orquideas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6029029','Mudas de outs.plantas ornamentais 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6029081','Mudas de cana-de-acucar 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6029082','Mudas de videira 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6029083','Mudas de cafe 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6029089','Mudas de outs.plantas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6029090','Outros plantas vivas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6031100','Rosas e seus botoes,frescos,cortados p/buques,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6031200','Cravos e seus botoes,frescos,cortados p/buques,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6031300','Orquideas e seus botoes,frescos,cortados p/buques,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6031400','Crisântemos e seus botoes,frescos,cortados p/buques,etc. 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6031500','Lírios e seus botoes,frescos,cortados p/buques,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6031900','Outs flores e seus botoes,frescos,cortados p/buques,etc. 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6039000','Flores e seus botoes,secos,etc.cortados p/buques,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6042000','Folhagem, folhas, ramos e outras partes de plantas, sem flor'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('6049000','Folhagem, folhas, ramos e outras partes de plantas, sem flor'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7011000','Batatas para semeadura (batata semente) 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7019000','Outros batatas frescas ou refrigeradas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7020000','Tomates,frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7031011','Cebolas para semeadura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7031019','Outros cebolas frescas ou refrigeradas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7031021','Echalotes para semeadura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7031029','Outros echalotes frescas ou refrigeradas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7032010','Alho para semeadura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7032090','Outros alhos frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7039010','Alho-porro e outs.prods.horticolas aliaceos,p/semeadura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7039090','Outs.alhos-porros,prods.horticolas aliaceos,frescos,etc 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7041000','Couve-flor e brocolos,frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7042000','Couve-de-bruxelas,fresca ou refrigerada 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7049000','Couves,repolho,etc.do genero brassica, frescos,refrig. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7051100','Alfaces repolhudas,frescas ou refrigeradas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7051900','Outros alfaces frescas ou refrigeradas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7052100','Chicorias witloof,frescas ou refrigeradas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7052900','Outros chicorias,frescas ou refrigeradas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7061000','Cenouras e nabos,frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7069000','Beterrabas,rabanetes e outs.raizes,frescas, refrigeradas 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7070000','Pepinos e pepininhos cornichons,frescos, refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7081000','Ervilhas (pisum sativum); frescas ou refrigeradas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7082000','Feijoes (vigna,phaseolus spp) frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7089000','Outros legumes de vagem,frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7092000','Aspargos frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7093000','Berinjelas frescas ou refrigeradas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7094000','Aipo fresco ou refrigerado,exc.aipo-rabano 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7095100','Cogumelos frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7095900','Outros cogumelos frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7096000','Pimentoes e pimentas,frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7097000','Espinafres frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7099100','Alcachofras frescas ou refrigeradas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7099200','Azeitonas,frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7099300','Abóboras, abobrinhas e cabaças (curcubita spp.) 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7099911','Milho doce,para semeadura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7099919','Milho doce,fresco ou refrig.exc.p/semeadura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7099990','Outros produtos horticolas,frescos ou refrigerados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7101000','Batatas congeladas,nao cozidas ou cozidas em agua/vapor 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7102100','Ervilhas congeladas,nao cozidas/cozidas em agua/vapor 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7102200','Feijoes congelados,nao cozidos ou cozidos em agua/vapor 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7102900','Outs.legumes de vagem,congel.n/cozidos/ cozidos agua/etc 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7103000','Espinafres congelad.n/cozidos ou cozidos em agua/vapor 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7104000','Milho doce congelado,n/cozido ou cozido em agua/vapor 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7108000','Outs.prods.horticolas congel.n/cozidos/ cozidos agua/etc 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7109000','Misturas de prods.horts.cong.n/cozidos/ cozidos agua/etc 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7112010','Azeitonas conserv.com agua salgada 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7112020','Azeitonas conserv.com agua sulfurada/adic.de outs.subst 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7112090','Outros azeitonas conservadas transitoriamente 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7114000','Pepinos e pepininhos  cornichons 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7115100','Cogumelos (agaricus) 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7115900','Outs.cogumelos 5.44'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7119000','Outros produtos horticolas,misturas de produtos hoticolas 4.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7122000','Cebolas secas,incl.pedacos,fatias,po,etc. s/qq.out.prep. 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7123100','Cogumelos (agaricus); secos,incl.pedacos, etc.s/qq.out.prep 4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7123200','Orelhas-de-judas,secos,incl.pedacos,etc. s/qq.out.prep 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7123300','Tremelas,secos,incl.pedacos,etc.s/qq.out. prep 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7123900','Outros cogumelos e trufas,secos,incl. pedacos,etc.s/qq.out.p'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7129010','Alho comum em po sem qualquer outro preparo 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7129090','Outs.prods.horts/misturas,secos,incl.pedacos,fatias,etc 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7131010','Ervilhas (pisum sativum); secas,em graos,para semeadura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7131090','Outros ervilhas (pisum sativum); secas,em graos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7132010','Grao-de-bico,seco,para semeadura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7132090','Outros graos-de-bico,secos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7133110','Feijoes (vigna mungo ou radiata) secos,para semeadura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7133190','Outs.feijoes (vigna mungo ou radiata); secos,em graos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7133210','Feijao adzuki,seco,para semeadura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7133290','Outros feijoes adzuki,secos,em graos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7133311','Feijao comum,preto,seco,para semeadura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7133319','Outros feijoes comuns,pretos,secos,em graos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7133321','Feijao comum,branco,seco,para semeadura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7133329','Outros feijoes comuns,brancos,secos,em graos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7133391','Outros feijoes comuns,secos,para semeadura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7133399','Outros feijoes comuns,secos,em graos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7133410','Feijão-bambara (vigna subterranea ou voandzeia subterranea)'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7133490','Outros feijoes-bambara (vigna subterranea ou voandzeia subte'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7133510','Feião fradinho seco ,para semeadura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7133590','Outros feijoes fradinho ,secos,em graos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7133910','Outs.feijoes (vigna ou phaseolus); secos,para semeadura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7133990','Outros feijoes (vigna ou phaseolus); secos,em graos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7134010','Lentilhas secas,para semeadura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7134090','Outros lentilhas secas,em graos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7135010','Favas e fava forrageira,secas,para semeadura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7135090','Outros favas e fava forrageira,secas,em graos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7136010','Feijões-guando,secos,em graos,para semeadura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7136090','Outros feijões-guando,secos,em graos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7139010','Outs.legumes de vagem,secos,em graos,para semeadura 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7139090','Outros legumes de vagem,secos,em graos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7141000','Raizes de mandioca,frescas,refrigeradas, congel.ou secas 4.2'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7142000','Batatas-doces,frescas,refrigeradas, congeladas ou secas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7143000','Inhames (...); frescos,etc.e medula de sagueiro 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7144000','Taros (...); frescos,etc.e medula de sagueiro 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7145000','Mangaritos (...); frescos,etc.e medula de sagueiro 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('7149000','Outs.raizes,tuberculos,frescos,etc.e medula de sagueiro 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8011100','Cocos dessecados 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8011200','Cocos na casca interna (endocarpo) 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8011900','Outros cocos frescos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8012100','Castanha-do-para,fresca ou seca,com casca 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8012200','Castanha-do-para,fresca ou seca,sem casca 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8013100','Castanha de caju,fresca ou seca,com casca 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8013200','Castanha de caju,fresca ou seca,sem casca 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8021100','Amendoas frescas ou secas,com casca 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8021200','Amendoas frescas ou secas, sem casca 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8022100','Avelas (corylus spp) frescas ou secas,com casca 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8022200','Avelas (corylus spp) frescas ou secas, sem casca 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8023100','Nozes frescas ou secas,com casca 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8023200','Nozes frescas ou secas, sem casca 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8024100','Castanhas (castanea spp) frescas ou secas, com casca 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8024200','Castanhas (castanea spp) frescas ou secas, sem casca 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8025100','Pitácios com casca, frescos ou secos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8025200','Pitácios sem casca, frescos ou secos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8026100','Nozes de macadâmia,frescas ou secas, com casca 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8026200','Nozes de macadâmia,frescas ou secas, sem casca 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8027000','Nozes de cola (...); frescas ou secas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8028000','Nozes de areca (...); frescas ou secas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8029000','Outros frutas de casca rija,frescas ou secas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8031000','Bananas da terra  frescas ou secas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8039000','Outras bananas frescas ou secas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8041010','Tamaras frescas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8041020','Tamaras secas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8042010','Figos frescos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8042020','Figos secos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8043000','Abacaxis frescos ou secos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8044000','Abacates frescos ou secos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8045010','Goiabas,frescos ou secos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8045020','Mangas,frescos ou secos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8045030','Mangostoes 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8051000','Laranjas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8052000','Tangerinas,mandarinas,satsumas,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8054000','Toranjas e pomelos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8055000','Limoes (citrus limon, citrus limonum) e limas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8059000','Outros citricos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8061000','Uvas frescas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8062000','Uvas secas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8071100','Melancias frescas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8071900','Meloes frescos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8072000','Mamoes (papaias) frescos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8081000','Macas frescas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8083000','Peras frescas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8084000','Marmelos frescos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8091000','Damascos frescos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8092100','Cerejas ácidas, frescas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8092900','Outras cerejas frescas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8093010','Pessegos frescos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8093020','Brugnons e nectarinas,frescos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8094000','Ameixas e abrunhos,frescos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8101000','Morangos frescos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8102000','Framboesas,amoras e amoras-framboesas,frescas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8103000','Groselhas, incluindo o cassis, frescos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8104000','Airelas,mirtilos e outs.frutas genero vaccinium,frescos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8105000','Quivis kiwis,frescos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8106000','Durioes frescos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8107000','Caquis (...) frescos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8109000','Outros frutas frescas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8111000','Morangos congelados,nao cozidos/cozidos em agua/vapor 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8112000','Framboesas,amoras,groselhas,congeladas,cozidas ou nao 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8119000','Outs.frutas congeladas,n/cozidas,cozidas em agua/vapor 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8121000','Cerejas conservadas em agua salgada, sulfurada,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8129000','Outs.frutas conservadas em agua salgada, sulfurada,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8131000','Damascos secos 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8132010','Ameixas secas,com caroco 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8132020','Ameixas secas,sem caroco 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8133000','Macas secas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8134010','Peras secas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8134090','Outros frutas secas 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8135000','Misturas de frutas secas ou de frutas de casca rija 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('8140000','Cascas de citricos,meloes,melancias,frescas, secas,etc. 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9011110','Cafe nao torrado,nao descafeinado,em grao 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9011190','Cafe nao torrado,nao descafeinado,exceto em grao 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9011200','Cafe nao torrado,descafeinado 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9012100','Cafe torrado,nao descafeinado 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9012200','Cafe torrado,descafeinado 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9019000','Cascas,peliculas de cafe e sucedaneos do cafe 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9021000','Cha verde (nao fermentado); em embalagens imediatas<=3kg 13.4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9022000','Cha verde (nao fermentado); apresentado em qq.out.forma 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9023000','Cha preto (fermentado/parcialm.); embalag. imediatas<=3kg 13.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9024000','Cha preto (fermentado/parcialm.) apresent. qq.out.forma 13.4'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9030010','Mate simplesmente cancheado 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9030090','Outros tipos de mate 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9041100','Pimenta piper,seca 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9041200','Pimenta piper,triturada ou em po 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9042100','Pimentoes e pimentas capsicum/pimenta, secos, não triturados'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9042200','Pimentoes e pimentas capsicum/pimenta, secos, triturados ou'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9051000','Baunilha, não triturados nem em pó 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9052000','Baunilha, triturados ou em  po 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9061100','Canela (cinnamomum zeylanicum blume) ,nao trituradas nem em'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9061900','Outras canela e flores de caneleira,nao trituradas nem em po'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9062000','Canela e flores de caneleira,trituradas ou em po 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9071000','Cravo-da-india (frutos,flores e pedunculos) não triturados n'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9072000','Cravo-da-india (frutos,flores e pedunculos);  triturados ou e'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9081100','Noz-moscada, não triturados nem em pó 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9081200','Noz-moscada, triturados ou em  po 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9082100','Macis, não triturados nem em pó 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9082200','Macis, triturados ou em  po 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9083100','Amomos e cardamomos, não triturados nem em pó 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9083200','Amomos e cardamomos, triturados ou em pó 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9092100','Sementes de coentro, não trituradas nem em pó 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9092200','Sementes de coentro, trituradas ou em pó 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9093100','Sementes de cominho, não trituradas nem em pó 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9093200','Sementes de cominho, trituradas ou em pó 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9096110','Sementes de anis (anis verde);  não trituradas nem em pó 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9096120','Sementes de badiana (anis estrelado);  não trituradas nem em'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9096190','Sementes de funcho e bagas de zimbro, não trituradas nem em'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9096210','Sementes de anis (anis verde);  trituradas ou em pó 4.20'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9096220','Sementes de badiana (anis estrelado);  trituradas ou em pó 4.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9096290','Sementes de funcho e bagas de zimbro, trituradas ou em pó 4.'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9101100','Gengibre, não trituradas nem em pó 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9101200','Gengibre, trituradas ou em pó 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9102000','Acafrao 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9103000','Acafrao-da-terra (curcuma) 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9109100','Misturas de especiarias 13.45'); 
            INSERT INTO tabelancm (numero_ncm, descricao_ncm) VALUES ('9109900','Outros especiarias 13.45');
                END IF;
            END;
            $$ LANGUAGE plpgsql;";


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
                CreateCtasReceber,
                CreateTabelaNCM,
                ProcTabelaNCM,
                ChamaProcNCM
            };
        }

    }
}
