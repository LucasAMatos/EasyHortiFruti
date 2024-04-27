using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EasyHortifruti.Componentes
{
    public partial class AltTextBox : TextBox
    {
        #region Propriedades

        public bool Obrigatorio { get; set; }

        public string Caption { get; set; }

        public string Value
        {
            get
            {
                switch (Tipo)
                {
                    case TipoCampo.CEP:
                    case TipoCampo.CPF:
                    case TipoCampo.CNPJ:
                    case TipoCampo.TELEFONE:
                        return Regex.Replace(Text, @"[^\d]+", "");

                    default:
                        return Text;
                }
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

        #endregion Propriedades

        #region Construtor

        public AltTextBox()
        {
            this.KeyPress += FormataCampos;
            this.Leave += FormataCampoLeave;

            InitializeComponent();
        }

        #endregion Construtor

        #region Metodos

        private void FormataCampoLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Text))
                return;

            switch (Tipo)
            {
                case TipoCampo.TELEFONE:
                    Text = Value.Length <= 10 ? Regex.Replace(Value, @"(\d{2})(\d{0,4})(\d{0,4})", @"($1)$2-$3") : Regex.Replace(Value, @"(\d{2})(\d{0,5})(\d{0,4})", @"($1)$2-$3");
                    break;

                case TipoCampo.CEP:
                    Text = Regex.Replace(Value.PadRight(8, '0'), @"(\d{5})(\d{0,3})", @"$1-$2");
                    break;

                case TipoCampo.CNPJ:
                    Text = Regex.Replace(Value.PadLeft(14, '0'), @"(\d{2})(\d{3})(\d{3})(\d{4})(\d{0,2})", @"$1.$2.$3/$4-$5");
                    break;

                case TipoCampo.CPF:
                    Text = Regex.Replace(Value.PadLeft(11, '0'), @"(\d{3})(\d{3})(\d{3})", @"$1.$2.$3-");
                    break;

                default:
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
                        e.Handled = true;

                    if (char.IsDigit(e.KeyChar))
                    {
                        if (Value.Length < 11)
                        {
                            if (Value.Length >= 10)
                                Text = Regex.Replace(Value, @"(^\d{0,2})(\d{0,5})(\d{0,4})", @"($1)$2-$3");
                            else if (Value.Length >= 6)
                                Text = Regex.Replace(Value, @"(^\d{0,2})(\d{0,4})(\d{0,4})", @"($1)$2-$3");
                            else if (Value.Length >= 2)
                                Text = Regex.Replace(Value, @"(^\d{0,2})", @"($1)");
                            else
                                Text = "(" + Value;

                            this.SelectionStart = this.Text.Length;
                        }
                    }
                    return;

                case TipoCampo.CEP:
                    // Permite apenas números e teclas de controle (como Backspace)
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                        e.Handled = true;

                    if (char.IsDigit(e.KeyChar))
                        Text = Value.Length >= 5 ? string.Format("{0}-{1}", Value.Substring(0, 5), Value.Substring(5, Value.Length - 5)) : Value;

                    this.SelectionStart = this.Text.Length;
                    return;

                case TipoCampo.CPF:
                    // Permite apenas números e teclas de controle (como Backspace)
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                        e.Handled = true;

                    if (char.IsDigit(e.KeyChar))
                    {
                        if (Value.Length < 11)
                        {
                            Text += e.KeyChar;

                            if (Value.Length >= 9)
                                Text = Regex.Replace(Value, @"(\d{3})(\d{3})(\d{3})", @"$1.$2.$3-");
                            else if (Value.Length >= 3)
                                Text = Regex.Replace(Value, @"(\d{3})", @"$1.");
                            else
                                Text = Value;

                            this.SelectionStart = this.Text.Length;
                        }
                        e.Handled = true;
                    }
                    return;

                case TipoCampo.CNPJ:
                    // Permite apenas números e teclas de controle (como Backspace)
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                        e.Handled = true;

                    if (char.IsDigit(e.KeyChar))
                    {
                        if (Value.Length < 14)
                        {
                            Text += e.KeyChar;

                            if (Value.Length >= 12)
                                Text = Regex.Replace(Value, @"(\d{2})(\d{3})(\d{3})(\d{4})(\d{0,2})", @"$1.$2.$3/$4-$5");
                            else if (Value.Length >= 8)
                                Text = Regex.Replace(Value, @"(\d{2})(\d{3})(\d{3})(\d{0,4})", @"$1.$2.$3/$4");
                            else if (Value.Length >= 5)
                                Text = Regex.Replace(Value, @"(\d{2})(\d{3})(\d{0,3})", @"$1.$2.$3");
                            else if (Value.Length >= 3)
                                Text = Regex.Replace(Value, @"(\d{2})(\d{0,3})", @"$1.$2");

                            this.SelectionStart = this.Text.Length;
                        }
                        e.Handled = true;
                    }
                    return;

                case TipoCampo.MOEDA:
                    if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',') ||
                       (Text.Contains(',') && e.KeyChar == ','))
                    {
                        e.Handled = true;
                        return;
                    }
                    if (string.IsNullOrEmpty(Text) && e.KeyChar == ',')
                    {
                        e.Handled = true;
                        Text = "0,";
                        SelectionStart = Text.Length;
                        return;
                    }
                    if (!char.IsControl(e.KeyChar) && Text.Contains(',') && Text.Split(',')[1].Length == 2 && SelectionLength == 0)
                    {
                        e.Handled = true;
                        return;
                    }
                    if (e.KeyChar == 8 && SelectionLength > 0)
                    {
                        Text = Text.Remove(SelectionStart, SelectionLength);
                        SelectionStart = Text.Length;
                        SelectionLength = 0;
                        e.Handled = true;
                        return;
                    }
                    if (e.KeyChar == 8 && SelectionLength == 0)
                    {
                        if (Text.Length > 0)
                        {
                            Text = Text.Remove(SelectionStart - 1);
                            SelectionStart = Text.Length;
                            SelectionLength = 0;
                            e.Handled = true;
                            return;
                        }
                    }
                    return;

                default:
                    return;
            }
        }

        #endregion Metodos

        #region Enum

        public enum TipoCampo
        {
            TEXTO,
            CPF,
            CNPJ,
            TELEFONE,
            CEP,
            MOEDA
        }

        #endregion Enum
    }
}