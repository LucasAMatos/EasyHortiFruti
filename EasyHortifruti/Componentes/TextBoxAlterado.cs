using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyHortifruti.Componentes
{
    public partial class TextBoxAlterado : TextBox
    {
        // Adicionando uma propriedade personalizada
        public bool Obrigatorio { get; set; }

        public string Caption { get; set; }

        public bool Criticar { 
            get 
            {
                return Obrigatorio && string.IsNullOrEmpty(Text);
            } 
        }
        public TextBoxAlterado()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
