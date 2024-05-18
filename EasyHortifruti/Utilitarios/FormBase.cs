using EasyHortifruti.Componentes;
using Npgsql.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Data;

namespace EasyHortifruti
{
    public class FormBase : System.Windows.Forms.Form
    {
        internal int Id { get; set; }
        internal bool Alterar => Id > 0;

        internal void Criticar(Control pControl = null)
        {
            try
            {
                if (pControl == null)
                    pControl = this;

                foreach (Control c in pControl.Controls)
                {
                    if (c is AltTextBox tb && tb.Criticar)
                    {
                        if (string.IsNullOrEmpty(tb.Caption))
                            throw new Exception($"{tb.Name} é Obrigatório");
                        throw new Exception($"{tb.Caption} é Obrigatório");
                    }
                    if (c is AltComboBox cb && cb.Criticar)
                    {
                        if (string.IsNullOrEmpty(cb.Caption))
                            throw new Exception($"{cb.Name} é Obrigatório");
                        throw new Exception($"{cb.Caption} é Obrigatório");
                    }
                    // Se o controle tiver controles filhos, chama recursivamente o método
                    if (c.HasChildren)
                    {
                        this.Criticar(c);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal void Filtrar(DataGridView dgv, DataSet pDs, int SelectedIndex, string pFiltro)
        {
            try
            {
                string coluna = dgv.Columns[SelectedIndex].DataPropertyName;
                if (!string.IsNullOrEmpty(pFiltro))
                {
                    if (SelectedIndex == 14)
                        pDs.Tables["Table"].DefaultView.RowFilter = $"{coluna} = {pFiltro}";
                    else
                    {
                        switch (pDs.Tables["Table"].DefaultView.Table.Columns[SelectedIndex].DataType.ToString())
                        {
                            case "System.Int32":
                            case "System.Double":
                                pDs.Tables["Table"].DefaultView.RowFilter = $"{coluna} = {pFiltro}";
                                break;
                            default:
                                pDs.Tables["Table"].DefaultView.RowFilter = $"{coluna} LIKE '%{pFiltro}%'";
                                break;
                        }
                    }
                }
                else
                {
                    pDs.Tables["Table"].DefaultView.RowFilter = string.Empty;
                }

                dgv.DataSource = pDs.Tables["Table"].DefaultView;
            }
            catch
            {
            }
        }

        internal void LimparCampos(Control pControl = null)
        {
            try
            {
                if (pControl == null)
                    pControl = this;

                foreach (Control c in pControl.Controls)
                {
                    if (c is AltTextBox tb && tb.Criticar)
                    {
                        tb.Text = string.Empty;
                    }
                    if (c is AltComboBox cb && cb.Criticar)
                    {
                        cb.Text = string.Empty;
                    }
                    // Se o controle tiver controles filhos, chama recursivamente o método
                    if (c.HasChildren)
                    {
                        this.LimparCampos(c);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal void SalvarCSV(DataGridView grdCSV)
        {
            // Cria um objeto SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                // Define o filtro de arquivos para a caixa de diálogo (por exemplo, CSV)
                Filter = "Arquivos CSV (*.csv)|*.csv|Todos os arquivos (*.*)|*.*",
                FilterIndex = 1
            };

            // Exibe a caixa de diálogo "Salvar como"
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Obtém o caminho completo do arquivo selecionado
                    string filePath = saveFileDialog.FileName;

                    // Abre o arquivo para escrita
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        // Escreve o cabeçalho (nomes das colunas)
                        for (int i = 0; i < grdCSV.Columns.Count; i++)
                        {
                            writer.Write(grdCSV.Columns[i].HeaderText);
                            if (i < grdCSV.Columns.Count - 1)
                            {
                                writer.Write(",");
                            }
                        }
                        writer.WriteLine();

                        // Escreve os dados do grid no arquivo
                        foreach (DataGridViewRow row in grdCSV.Rows)
                        {
                            for (int i = 0; i < grdCSV.Columns.Count; i++)
                            {
                                writer.Write(row.Cells[i].Value);
                                if (i < grdCSV.Columns.Count - 1)
                                {
                                    writer.Write(",");
                                }
                            }
                            writer.WriteLine();
                        }
                    }

                    MessageBox.Show("Arquivo salvo com sucesso!", "Salvar arquivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal void ConfiguraGridPadrao(DataGridView pDataGridView)
        {
            pDataGridView.RowHeadersVisible = false;
            pDataGridView.AllowUserToAddRows = false;
            pDataGridView.AllowUserToDeleteRows = false;
            pDataGridView.ReadOnly = true;
            pDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            pDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
