using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyHortifruti.Componentes
{
    public partial class AltTextBox : TextBox
    {
        #region Propriedades
        public bool Obrigatorio { get; set; }

        public string Caption { get; set; }

        private string iValue;
        public string Value
        {
            get
            {
                if (iValue == null)
                    PreencheValue(null, null);
                return iValue;
            }
            set
            {
                iValue = value;
            }
        }

        public TipoCampo Tipo { get; set; }

        public bool Criticar
        {
            get
            {
                return Obrigatorio && string.IsNullOrEmpty(Text);
            }
        }
        #endregion

        #region Construtor
        public AltTextBox()
        {
            this.KeyUp += PreencheValue;

            this.KeyUp += FormataCampos;

            InitializeComponent();
        }
        #endregion

        #region Metodos

        private void PreencheValue(object sender, KeyEventArgs e)
        {
            switch (Tipo)
            {
                case TipoCampo.TELEFONE:
                case TipoCampo.CEP:
                    iValue = Regex.Replace(Text, @"\D+", "");
                    break;
                case TipoCampo.CNPJ:
                case TipoCampo.CPF:
                    iValue = Regex.Replace(Text, @"\D+", "");
                    break;

                default:
                    iValue += Text;
                    break;
            }
        }
        private void FormataCampos(object sender, EventArgs e)
        {
            switch (Tipo)
            {
                case TipoCampo.TELEFONE:
                    if (Value.Length == 0)
                    {
                        Text = string.Empty;
                    }
                    else if (Value.Length <= 2)
                    {
                        Text = string.Format("({0})", Value.Substring(0, Value.Length));
                    }
                    else if (Value.Length <= 6)
                    {
                        Text = string.Format("({0}) {1}", Value.Substring(0, 2), Value.Substring(2, Value.Length - 2));
                    }
                    else if (Value.Length <= 10)
                    {
                        Text = string.Format("({0}) {1}-{2}", Value.Substring(0, 2), Value.Substring(2, 4), Value.Substring(6, Value.Length - 6));
                    }
                    else
                        Text = string.Format("({0}) {1}-{2}", Value.Substring(0, 2), Value.Substring(2, 5), Value.Substring(7, 4));

                    this.SelectionStart = this.Text.Length;
                    if (Value.Length == 1 || Value.Length == 2)
                        this.SelectionStart = this.Text.Length - 1;
                    break;
                case TipoCampo.CEP:
                    Text = Value.Length > 5 ? string.Format("{0}-{1}", Value.Substring(0, 5), Value.Substring(5, Value.Length - 5)) : Value;
                    this.SelectionStart = this.Text.Length;
                    break;
                case TipoCampo.CPF:
                    MaxLength = Value.Length == 11 ? 14 : 15;
                    Value = Value.Trim('0').PadLeft(11, '0');
                    Text = string.Empty;
                    if (Value.TrimStart('0').Length > 0)
                        Text = Regex.Replace(Value, @"(\d{3})(\d{3})(\d{3})(\d{2})", @"$1.$2.$3-$4");
                    this.SelectionStart = this.Text.Length;
                    this.TextAlign = HorizontalAlignment.Right;
                    break;
                case TipoCampo.CNPJ:
                    MaxLength = Value.Length == 15 ? 19 : 20;
                    Value = Value.Trim('0').PadLeft(15, '0');
                    Text = string.Empty;
                    if (Value.TrimStart('0').Length > 0)
                        Text = Regex.Replace(Value, @"(\d{3})(\d{3})(\d{3})(\d{4})(\d{2})", @"$1.$2.$3/$4-$5");
                    this.SelectionStart = this.Text.Length;
                    this.TextAlign = HorizontalAlignment.Right;
                    break;
                default:
                    this.SelectionStart = this.Text.Length;
                    break;
            }

        }

        #endregion
        #region Enum
        public enum TipoCampo
        {
            TEXTO,
            CPF,
            CNPJ,
            TELEFONE,
            CEP
        }
        #endregion
    }
}
