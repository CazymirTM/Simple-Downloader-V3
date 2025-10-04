using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Simple_Downloader_V3
{
    public partial class MainForm : Form
    {
        private WebClient webClient;
        private bool isDownloading = false;

        public MainForm()
        {
            InitializeComponent();

            comboBoxLaunchers.Items.Add("Epic Games");
            comboBoxLaunchers.Items.Add("Steam");
            comboBoxLaunchers.Items.Add("EA App");
            comboBoxLaunchers.Items.Add("GOG Galaxy");
            comboBoxLaunchers.Items.Add("Ubisoft Connect");
            comboBoxLaunchers.SelectedIndex = 0;
        }

        private string GetUrl(string launcher)
        {
            switch (launcher)
            {
                case "Epic Games":
                    return "https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi";
                case "Steam":
                    return "https://cdn.cloudflare.steamstatic.com/client/installer/SteamSetup.exe";
                case "EA App":
                    return "https://origin-a.akamaihd.net/EA-Desktop-Client-Download/installer-releases/EAappInstaller.exe";
                case "GOG Galaxy":
                    return "https://webinstallers.gog-statics.com/download/GOG_Galaxy_2.0.exe";
                case "Ubisoft Connect":
                    return "https://ubistatic3-a.akamaihd.net/orbit/launcher_installer/UbisoftConnectInstaller.exe";
                default:
                    return "";
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            if (isDownloading) return;
            string launcher = comboBoxLaunchers.SelectedItem.ToString();
            string url = GetUrl(launcher);
            string downloadsDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Downloads");
            Directory.CreateDirectory(downloadsDir);
            string fileName = Path.Combine(downloadsDir, launcher.Replace(" ", "_") + Path.GetExtension(url));

            progressBar.Value = 0;
            lblStatus.Text = $"Downloading {launcher}...";
            btnDownload.Enabled = false;
            btnCancel.Enabled = true;
            isDownloading = true;

            webClient = new WebClient();
            webClient.DownloadProgressChanged += (s, ev) =>
            {
                progressBar.Value = ev.ProgressPercentage;
            };
            webClient.DownloadFileCompleted += (s, ev) =>
            {
                lblStatus.Text = $"Downloaded {launcher}";
                btnDownload.Enabled = true;
                btnCancel.Enabled = false;
                isDownloading = false;
                try { System.Diagnostics.Process.Start(downloadsDir); } catch { }
            };

            try
            {
                await webClient.DownloadFileTaskAsync(new Uri(url), fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Error occurred";
                btnDownload.Enabled = true;
                btnCancel.Enabled = false;
                isDownloading = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (isDownloading && webClient != null)
            {
                webClient.CancelAsync();
                lblStatus.Text = "Download canceled";
                btnDownload.Enabled = true;
                btnCancel.Enabled = false;
                isDownloading = false;
            }
        }
    }
}
