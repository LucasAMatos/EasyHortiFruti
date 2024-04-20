using EasyHortifruti.Componentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace EasyHortifruti
{
    public class FormBase : System.Windows.Forms.Form
    {
        internal int Id { get; set; }
        internal bool Alterar => Id > 0;

        internal void Criticar(Control pControl = null)
        {
            try
            {
                if (pControl == null)
                    pControl = this;

                foreach (Control c in pControl.Controls)
                {
                    if (c is TextBoxAlterado tb && tb.Criticar)
                    {
                        if(string.IsNullOrEmpty(tb.Caption))
                            throw new Exception(string.Concat(tb.Name, " é Obrigatório"));
                        throw new Exception(string.Concat(tb.Caption, " é Obrigatório"));
                    }
                    // Se o controle tiver controles filhos, chama recursivamente o método
                    if (c.HasChildren)
                    {
                        this.Criticar(c);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
