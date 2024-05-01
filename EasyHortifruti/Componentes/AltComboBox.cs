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
    public partial class AltComboBox : UserControl
    {
        #region Propriedades
        public bool Obrigatorio { get; set; }

        public bool Criticar
        {
            get
            {
                return Obrigatorio && string.IsNullOrEmpty(comboBox1.Text);
            }
        }

        public string Caption
        {
            get
            {
                return label.Text;
            }
            set
            {
                label.Text = value;
            }

        }

        public ComboBox.ObjectCollection Items
        {
            get { return comboBox1.Items; }
        }

        public string SelectedText
        {
            get { return comboBox1.SelectedText; }
            set { comboBox1.SelectedText = value; }
        }

        public override string Text
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }


        public object SelectedItem
        {
            get { return comboBox1.SelectedItem; }
            set { comboBox1.SelectedItem = value; }
        }

        public int SelectedIndex
        {
            get { return comboBox1.SelectedIndex; }
            set { comboBox1.SelectedIndex = value; }
        }
        
        public AutoCompleteMode AutoCompleteMode
        {
            get { return comboBox1.AutoCompleteMode; }
            set { comboBox1.AutoCompleteMode = value; }
        }

        public AutoCompleteSource AutoCompleteSource
        {
            get { return comboBox1.AutoCompleteSource; }
            set { comboBox1.AutoCompleteSource = value; }
        }

        public bool FormattingEnabled
        {
            get { return comboBox1.FormattingEnabled; }
            set { comboBox1.FormattingEnabled = value; }
        }

        public ComboBoxStyle DropDownStyle
        {
            get { return comboBox1.DropDownStyle; }
            set { comboBox1.DropDownStyle = value; }
        }

        public Font FonteCaption
        {
            get
            {
                return label.Font;
            }
            set
            {
                label.Font = value;
            }
        }

        public event EventHandler SelectedIndexChanged;
        #endregion

        #region Constructor
        public AltComboBox()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        public void CarregarDescricoesEnum<T>()
        {
            comboBox1.Items.Clear();
            foreach (T item in Enum.GetValues(typeof(T)))
            {
                var fieldInfo = item.GetType().GetField(item.ToString());
                var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
                string description = attributes.Length > 0 ? attributes[0].Description : item.ToString();

                comboBox1.Items.Add(description);
            }
            comboBox1.SelectedIndex = 0;
        }

        public void CarregarValoresEnum<T>()
        {
            comboBox1.Items.Clear();
            foreach (T item in Enum.GetValues(typeof(T)))
            {
                comboBox1.Items.Add(item.ToString());
            }
            comboBox1.SelectedIndex = 0;
        }

        public void SelecionarIndexPeloConteudo(string pItem)
        {
            if (pItem != null)
                comboBox1.SelectedIndex =  comboBox1.Items.IndexOf(pItem);
        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectedIndexChanged != null)
                SelectedIndexChanged(sender, e);
        }

        private void label_Click(object sender, EventArgs e)
        {
        }
    }
}
