using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace EasyHortifruti
{
    public class BackupService
    {
        private string _connectionString;

        public BackupService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void BackupDatabase(string backupFileName, string backupDirectory)
        {
            string database = "EasyHortifruti";
            string user = "Admin";
            string password = "2125071216";
            string host = "localhost"; // ou o endereço do seu servidor PostgreSQL
            string arquivoLocal = string.Concat(backupDirectory, "\\", backupFileName);
            // Configura a variável de ambiente PGPASSWORD para evitar que a senha seja solicitada
            Environment.SetEnvironmentVariable("PGPASSWORD", password);

            string args = $"-h {host} -U {user} -F c -b -v -f {arquivoLocal} {database}";

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "C:\\Program Files\\PostgreSQL\\16\\bin\\pg_dump.exe",
                Arguments = args,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            try
            {
                using (Process process = Process.Start(startInfo))
                {
                    process.WaitForExit();
                    if (process.ExitCode != 0)
                    {
                        MessageBox.Show($"Erro no backup: {process.StandardError.ReadToEnd()}");
                    }
                    else
                    {
                        MessageBox.Show("Backup realizado com sucesso.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}