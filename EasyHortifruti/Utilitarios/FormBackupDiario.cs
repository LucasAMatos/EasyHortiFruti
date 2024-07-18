using System;
using System.IO;
using System.Windows.Forms;

namespace EasyHortifruti.Utilitarios
{
    public partial class FormBackupDiario : Form
    {
        private BackupService _backupService;

        public FormBackupDiario()
        {
            InitializeComponent();
            string connectionString = "Host=localhost;Username=Admin;Password=2125071216;Database=EasyHortifruti";
            _backupService = new BackupService(connectionString);

        }

        private void BtLocalizar_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    TxtBackupPath.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void BtGravarBackup_Click(object sender, EventArgs e)
        {
            string backupDirectory = TxtBackupPath.Text;

            if (!Directory.Exists(backupDirectory))
            {
                MessageBox.Show("Por favor, selecione um caminho válido para o backup.");
                return;
            }

            string backupFileName = $"backup_{DateTime.Now:yyyyMMddHHmmss}.dump";
            try
            {
                _backupService.BackupDatabase(backupFileName, backupDirectory);
                MessageBox.Show("Backup realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar o backup: {ex.Message}");
            }

            this.Close();

        }

        private void BtCancelarBackup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
