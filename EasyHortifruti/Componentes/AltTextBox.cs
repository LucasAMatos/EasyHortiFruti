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
                if (iValue == null || string.IsNullOrEmpty(iValue.Trim()))
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
            this.KeyPress += PreencheValue;

            this.KeyPress += FormataCampos;

            this.LostFocus += PreencheValueLostFocus;
            InitializeComponent();
        }
        #endregion

        #region Metodos

        private void PreencheValue(object sender, KeyPressEventArgs e)
        {
            switch (Tipo)
            {
                case TipoCampo.TELEFONE:
                case TipoCampo.CEP:
                case TipoCampo.CNPJ:
                case TipoCampo.CPF:
                    if (e == null || char.IsDigit(e.KeyChar))
                    {
                        iValue = Regex.Replace(Text, @"[^\d]+", "");
                    }
                    break;

                default:
                    iValue += Text;
                    break;
            }
        }
        private void PreencheValueLostFocus(object sender, EventArgs e)
        {
            switch (Tipo)
            {
                case TipoCampo.TELEFONE:
                    iValue = Regex.Replace(Text, @"[^\d]+", "");
                    break;
                case TipoCampo.CEP:
                    iValue = Regex.Replace(Text, @"[^\d]+", "");
                    Text = Regex.Replace(iValue.PadRight(8, '0'), @"(\d{5})(\d{3})", @"$1-$2");
                    iValue = Regex.Replace(Text, @"[^\d]+", "");
                    break;
                case TipoCampo.CNPJ:
                    iValue = Regex.Replace(Text, @"[^\d]+", "");
                    Text = Regex.Replace(iValue.PadLeft(14, '0'), @"(\d{2})(\d{3})(\d{3})(\d{4})(\d{0,2})", @"$1.$2.$3/$4-$5");
                    break;
                case TipoCampo.CPF:
                    iValue = Regex.Replace(Text, @"[^\d]+", "");
                    Text = Regex.Replace(iValue.PadLeft(11, '0'), @"(\d{3})(\d{3})(\d{3})", @"$1.$2.$3-");
                    break;
                default:
                    iValue += Text;
                    break;
            }

        }
        private void FormataCampos(object sender, KeyPressEventArgs e)
        {
            switch (Tipo)
            {
                case TipoCampo.TELEFONE:
                    // Permite apenas números e teclas de controle (como Backspace)
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        return;
                    }

                    if (char.IsDigit(e.KeyChar))
                    {
                        if (Value.Length >= 10)
                            Text = Regex.Replace(Value, @"(^\d{0,2})(\d{0,5})(\d{0,4})", @"($1)$2-$3");
                        else if(Value.Length >= 6)
                            Text = Regex.Replace(Value, @"(^\d{0,2})(\d{0,4})(\d{0,4})", @"($1)$2-$3");
                        else if (Value.Length >= 2)
                            Text = Regex.Replace(Value, @"(^\d{0,2})", @"($1)");
                        else
                            Text = "(" + Value;
                    }
                    break;
                case TipoCampo.CEP:
                    // Permite apenas números e teclas de controle (como Backspace)
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        return;
                    }

                    if (char.IsDigit(e.KeyChar))
                        Text = Value.Length >= 5 ? string.Format("{0}-{1}", Value.Substring(0, 5), Value.Substring(5, Value.Length - 5)) : Value;
                    break;
                case TipoCampo.CPF:
                    // Permite apenas números e teclas de controle (como Backspace)
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        return;
                    }

                    if (char.IsDigit(e.KeyChar))
                    {
                        if (Value.Length >= 9)
                            Text = Regex.Replace(Value, @"(\d{3})(\d{3})(\d{3})", @"$1.$2.$3-");
                        else if (Value.Length >= 3)
                            Text = Regex.Replace(Value, @"(\d{3})", @"$1.");
                    }
                    break;
                case TipoCampo.CNPJ:
                    // Permite apenas números e teclas de controle (como Backspace)
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        return;
                    }

                    if (char.IsDigit(e.KeyChar))
                    {
                        if (Value.Length >= 12)
                            Text = Regex.Replace(Value, @"(\d{2})(\d{3})(\d{3})(\d{4})(\d{0,2})", @"$1.$2.$3/$4-$5");
                        else if (Value.Length >= 8)
                            Text = Regex.Replace(Value, @"(\d{2})(\d{3})(\d{3})(\d{0,4})", @"$1.$2.$3/$4");
                        else if (Value.Length >= 5)
                            Text = Regex.Replace(Value, @"(\d{2})(\d{3})(\d{0,3})", @"$1.$2.$3");
                        else if (Value.Length >= 2)
                            Text = Regex.Replace(Value, @"(\d{2})(\d{0,3})", @"$1.$2");
                        else
                            Text = Value;
                    }
                    break;
                default:
                    break;
            }
            this.SelectionStart = this.Text.Length;
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
