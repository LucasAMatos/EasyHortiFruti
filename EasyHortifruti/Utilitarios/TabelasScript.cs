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

        private string CreateUnidade = @"CREATE TABLE IF NOT EXISTS public.unidades
                                            (
                                                abrev_unid character varying(6) NOT NULL,
                                                desc_unid character varying(20) NOT NULL,
                                                obs_unid character varying(30) NOT NULL,
                                                id_recno integer NOT NULL GENERATED ALWAYS AS IDENTITY,
                                                PRIMARY KEY (id_recno)
                                            )";

        public TabelasScript()
        {
            Scripts = new List<string>
            {
                CreateUnidade
            };
        }
    }
}
