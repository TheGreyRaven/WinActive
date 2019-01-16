using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WinActive
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            outputBox.MouseWheel += new MouseEventHandler(outputBox_MouseWheel);
            SendLog("WinActive loaded!");
        }

        List<string> datafolders = new List<string>()
        {
            "32-bit", "64-bit"
        };

        void outputBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (outputBox.SelectionStart > 10)
                {
                    outputBox.SelectionStart -= 10;
                    outputBox.ScrollToCaret();
                }
            }
            else
            {
                outputBox.SelectionStart += 10;
                outputBox.ScrollToCaret();
            }
        }

        private void activateButton_Click(object sender, EventArgs e)
        {
            activateButton.Enabled = false;
            SendLog("Preparing activation.");

            if (Directory.Exists(Path.GetTempPath() + "\\WinActiveData"))
            {
                SendLog("Data folder found.");
            }
            else
            {
                SendLog("Data folder did not exist, creating...");
            }

            foreach (string folder in datafolders)
            {
                SendLog("Checking if " + folder + " folder exists...");
                if (Directory.Exists(Path.GetTempPath() + "\\WinActiveData\\" + folder))
                {
                    SendLog(folder + " folder found!");
                }
                else
                {
                    SendLog(folder + " folder not found, creating...");
                    Directory.CreateDirectory(Path.GetTempPath() + "\\WinActiveData\\" + folder);
                }
            }

            SendLog("Extracting resources...");
            Functions.WriteResources();
            SendLog("Resources successfully extracted!");
            SendLog("Starting activation process.");
            ExecuteCommand();
        }

        void ExecuteCommand()
        {
            var processInfo = new ProcessStartInfo(Path.GetTempPath() + "\\WinActiveData\\KMS_VL_ALL.cmd", " / c ");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;
            var process = Process.Start(processInfo);
            process.EnableRaisingEvents = true;

            process.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
                SendLog(e.Data);
            process.BeginOutputReadLine();

            process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
                SendLog("[ERROR]: " + e.Data);

            process.BeginErrorReadLine();
            process.WaitForExit();

            SendLog("Finished activating products!");
            SendLog("Thank you for using WinActive!");
            process.Close();

            Directory.Delete(Path.GetTempPath() + "\\WinActiveData", true);

            activateButton.Enabled = true;
        }

        private void SendLog(string Text)
        {
            string timeStamp = Functions.GetTimestamp(DateTime.Now);

            outputBox.Text += "[" + timeStamp + "]: " + Text + Environment.NewLine;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void githubButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/TheGreyRaven/WinActive");
        }

        private void mdlButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://forums.mydigitallife.net/threads/remade-winactive-a-simple-kms-activator.78836/");
        }
    }
}
