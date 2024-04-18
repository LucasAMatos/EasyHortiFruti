using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyHortifruti
{
    public class Caracter
    {
        public static bool OnlyNr(KeyPressEventArgs e)
        {
            return (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));
        }
    }
}
