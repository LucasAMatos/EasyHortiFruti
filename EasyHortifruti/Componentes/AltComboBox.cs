using System;
using System.ComponentModel;
using System.Windows.Forms;

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

        #endregion Propriedades

        public AltComboBox()
        {
            InitializeComponent();
        }

        public AltComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void CarregarDescricoesEnum<T>()
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

        public void CarregarValoresEnum<T>()
        {
            Items.Clear();
            foreach (T item in Enum.GetValues(typeof(T)))
            {
                Items.Add(item);
            }
            this.SelectedIndex = 0;
        }
    }
}