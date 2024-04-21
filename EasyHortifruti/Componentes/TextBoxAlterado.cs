using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyHortifruti.Componentes
{
    public partial class TextBoxAlterado : TextBox
    {
        #region Propriedades
        public bool Obrigatorio { get; set; }

        public string Caption { get; set; }

        public string Value { get; set; }

        public TipoCampo Tipo { get; set; }

        public bool Criticar {
            get
            {
                return Obrigatorio && string.IsNullOrEmpty(Text);
            }
        }
        #endregion

        #region Construtor
        public TextBoxAlterado()
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
                    Value = Regex.Replace(Text, @"\D+", "");
                    break;
                default:
                    Value += Text;
                    break;
            }
        }
        private void FormataCampos(object sender, KeyEventArgs e)
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
                    break;
                default:
                    break;
            }
            this.SelectionStart = this.Text.Length;
        }
        #endregion
        #region Enum
        public enum TipoCampo { 
            TEXTO,
            CPF,
            CNPJ,
            TELEFONE,
        }
        #endregion
    }
}
