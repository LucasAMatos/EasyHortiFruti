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
        public bool Alterar => Id > 0;
    }
}
