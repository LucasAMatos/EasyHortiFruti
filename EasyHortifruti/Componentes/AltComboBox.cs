using EasyHortifruti.DML;
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

        public void CarregarValoresEnum<T>()
        {
            Items.Clear();
            foreach (T item in Enum.GetValues(typeof(T)))
            {
                var fieldInfo = item.GetType().GetField(item.ToString());
                var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
                string description = attributes.Length > 0 ? attributes[0].Description : item.ToString();

                Items.Add(description);
            }
            this.SelectedIndex = 0;
        }
    }
}
