using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EasyHortifruti.Componentes
{
    public partial class AltTextBox : UserControl
    {
        #region Propriedades

        public bool Obrigatorio { get; set; }

#pragma warning disable CS0108 // O membro oculta o membro herdado; nova palavra-chave ausente

        public event EventHandler TextChanged;

#pragma warning restore CS0108 // O membro oculta o membro herdado; nova palavra-chave ausente

        public bool Criticar
        {
            get
            {
                return Obrigatorio && string.IsNullOrEmpty(txtBox.Text);
            }
        }

        public TipoCampo Tipo { get; set; }

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
                        return Regex.Replace(txtBox.Text, @"[^\d]+", "");

                    default:
                        return txtBox.Text;
                }
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

        public Font FonteTexto
        {
            get
            {
                return txtBox.Font;
            }
            set
            {
                txtBox.Font = value;
            }
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

        public int SelectionStart
        {
            get
            {
                return txtBox.SelectionStart;
            }
            set
            {
                txtBox.SelectionStart = value;
            }
        }

        public int SelectionLength
        {
            get
            {
                return txtBox.SelectionLength;
            }
            set
            {
                txtBox.SelectionLength = value;
            }
        }

        public override string Text
        {
            get
            {
                return txtBox.Text;
            }
            set
            {
                txtBox.Text = value;
            }
        }

        public int MaxLength
        {
            get
            {
                return txtBox.MaxLength;
            }
            set
            {
                txtBox.MaxLength = value;
            }
        }

        public bool ReadOnly
        {
            get
            {
                return txtBox.ReadOnly;
            }
            set
            {
                txtBox.ReadOnly = value;
            }
        }

        public System.Windows.Forms.HorizontalAlignment TextAlign
        {
            get
            {
                return txtBox.TextAlign;
            }
            set
            {
                txtBox.TextAlign = value;
            }
        }

        public bool Multiline
        {
            get
            {
                return txtBox.Multiline;
            }
            set
            {
                txtBox.Multiline = value;
            }
        }

        #endregion Propriedades

        public AltTextBox()
        {
            InitializeComponent();
            txtBox.TextChanged += TextBox_TextChanged;
            txtBox.KeyDown += AltTextBox_Enter;
        }

        #region Eventos

        // Manipulador de eventos para o TextChanged do TextBox interno
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Dispare o evento TextChanged personalizado do UserControl
            OnTextChanged(EventArgs.Empty);
        }

        private void AltTextBox_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Impede que o caractere "Enter" seja inserido no controle atual
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        // Método para disparar o evento TextChanged personalizado do UserControl
#pragma warning disable CS0114 // O membro oculta o membro herdado; palavra-chave substituta ausente

        protected virtual void OnTextChanged(EventArgs e)
#pragma warning restore CS0114 // O membro oculta o membro herdado; palavra-chave substituta ausente
        {
            TextChanged?.Invoke(this, e);
        }

        #endregion Eventos

        #region Metodos

        private void FormataCampoLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Text))
                return;

            switch (Tipo)
            {
                case TipoCampo.TELEFONE:
                    Text = Value.Length <= 10 ? Regex.Replace(Value, @"(\d{2})(\d{0,4})(\d{0,4})", "($1)$2-$3") : Regex.Replace(Value, @"(\d{2})(\d{0,5})(\d{0,4})", "($1)$2-$3");
                    break;

                case TipoCampo.CEP:
                    Text = Regex.Replace(Value.PadRight(8, '0'), @"(\d{5})(\d{0,3})", "$1-$2");
                    break;

                case TipoCampo.CNPJ:
                    Text = Regex.Replace(Value.PadLeft(14, '0'), @"(\d{2})(\d{3})(\d{3})(\d{4})(\d{0,2})", "$1.$2.$3/$4-$5");
                    break;

                case TipoCampo.CPF:
                    Text = Regex.Replace(Value.PadLeft(11, '0'), @"(\d{3})(\d{3})(\d{3})", "$1.$2.$3-");
                    break;

                default:
                    break;
            }
        }

        private void FormataCampos(object sender, KeyPressEventArgs e)
        {
            switch (Tipo)
            {
                case TipoCampo.NUMERO:
                    // Permite apenas números e teclas de controle (como Backspace)
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                        e.Handled = true;
                    return;

                case TipoCampo.TELEFONE:
                    // Permite apenas números e teclas de controle (como Backspace)
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                        e.Handled = true;

                    if (char.IsDigit(e.KeyChar))
                    {
                        if (Value.Length < 11)
                        {
                            if (Value.Length >= 10)
                                Text = Regex.Replace(Value, @"(^\d{0,2})(\d{0,5})(\d{0,4})", "($1)$2-$3");
                            else if (Value.Length >= 6)
                                Text = Regex.Replace(Value, @"(^\d{0,2})(\d{0,4})(\d{0,4})", "($1)$2-$3");
                            else if (Value.Length >= 2)
                                Text = Regex.Replace(Value, @"(^\d{0,2})", "($1)");
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
                                Text = Regex.Replace(Value, @"(\d{3})(\d{3})(\d{3})", "$1.$2.$3-");
                            else if (Value.Length >= 3)
                                Text = Regex.Replace(Value, @"(\d{3})", "$1.");
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
                                Text = Regex.Replace(Value, @"(\d{2})(\d{3})(\d{3})(\d{4})(\d{0,2})", "$1.$2.$3/$4-$5");
                            else if (Value.Length >= 8)
                                Text = Regex.Replace(Value, @"(\d{2})(\d{3})(\d{3})(\d{0,4})", "$1.$2.$3/$4");
                            else if (Value.Length >= 5)
                                Text = Regex.Replace(Value, @"(\d{2})(\d{3})(\d{0,3})", "$1.$2.$3");
                            else if (Value.Length >= 3)
                                Text = Regex.Replace(Value, @"(\d{2})(\d{0,3})", "$1.$2");

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

        public void Clear()
        {
            txtBox.Clear();
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
            MOEDA,
            NUMERO
        }

        #endregion Enum
    }
}