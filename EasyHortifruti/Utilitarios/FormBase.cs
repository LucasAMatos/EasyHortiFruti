using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyHortifruti
{
    public class FormBase : System.Windows.Forms.Form
    {
        public int Id { get; set; }
        public int idunidade { get; set; }
        public int idgrupo { get; set; }
        public int idsubgrupo { get; set; }

        public string NomeTabelaBD { get; set; }
    }
}
