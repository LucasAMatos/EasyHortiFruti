using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EasyHortifruti.Componentes
{
    public partial class AltComboBox : ComboBox
    {
        #region Propriedades
        public bool Obrigatorio { get; set; }

        public string Caption { get; set; }

        public bool Criticar
        {
            get
            {
                return Obrigatorio && SelectedIndex < 0;
            }
        }
        #endregion
        public AltComboBox()
        {
            InitializeComponent();
        }

        public AltComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
