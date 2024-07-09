using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            try
            {
                string backupFilePath = Path.Combine(backupDirectory, backupFileName);
                string command = $"pg_dump --file \"{backupFilePath}\" --dbname \"{_connectionString}\"";

                ExecuteCommand(command);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao realizar o backup: {ex.Message}");
            }
        }

        private void ExecuteCommand(string command)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd", $"/c {command}")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(processStartInfo))
            {
                process.WaitForExit();
                string result = process.StandardOutput.ReadToEnd();
                Console.WriteLine(result);
            }
        }
    }

}

