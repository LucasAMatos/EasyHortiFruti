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

        private Dictionary<int, string> itemDicionario;
        internal Dictionary<int, string> ItemDicionario
        {
            get
            {
                if (itemDicionario == null)
                    itemDicionario = new Dictionary<int, string>();
                return itemDicionario;
            }
            set
            {
                itemDicionario = value;
            }
        }

        internal Array DataSource { get; set; }

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


        public string SelectedItem
        {
            get
            {
                if (comboBox1.SelectedItem == null)
                    return null;
#pragma warning disable CS0253 // Possível comparação de referência inesperada; o lado direito precisa de conversão
                return itemDicionario.First(x => x.Value == comboBox1.SelectedItem).Value;
#pragma warning restore CS0253 // Possível comparação de referência inesperada; o lado direito precisa de conversão
            }
            set { comboBox1.SelectedItem = value; }
        }

        public int SelectedIndex
        {
            get
            {
                if (comboBox1.SelectedItem == null)
                    return -1;
#pragma warning disable CS0253 // Possível comparação de referência inesperada; o lado direito precisa de conversão
                return itemDicionario.First(x => x.Value == comboBox1.SelectedItem).Key;
#pragma warning restore CS0253 // Possível comparação de referência inesperada; o lado direito precisa de conversão
            }
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

                this.Add((int)Convert.ChangeType(item, typeof(int)), description);
            }
            comboBox1.SelectedIndex = 0;
        }

        public void CarregarValoresEnum<T>()
        {
            comboBox1.Items.Clear();
            foreach (T item in Enum.GetValues(typeof(T)))
            {
                this.Add((int)Convert.ChangeType(item, typeof(int)), item.ToString());
            }
            comboBox1.SelectedIndex = 0;
        }

        public void SelecionarIndexPeloEnum(int pItem)
        {
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf(itemDicionario.First(x => x.Key == pItem).Value);
        }

        public void SelecionarIndexPeloConteudo(string pItem)
        {
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf(pItem);
        }

        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedIndexChanged != null)
                SelectedIndexChanged(sender, e);
        }

        public void Clear()
        {
            if (itemDicionario == null)
                itemDicionario = new Dictionary<int, string>();
            itemDicionario.Clear();
            comboBox1.Items.Clear();
        }

        public void Add(int pKey, string pValue)
        {
            if (itemDicionario == null)
                itemDicionario = new Dictionary<int, string>();
            itemDicionario.Add(pKey, pValue);
            comboBox1.Items.Add(pValue);
        }
    }
}
